

%измерение всех параметров + сохранение картинки с камеры

beep on;
pause on;
% 
prompt = 'номер порта: ';
port = input(prompt);

% prompt = 'Номер порта: ';
% port_numb = input(prompt);

% com = 'COM';
% port_numb=int2str(port_numb);
% c = [com port_numb];
% cc = cell(1);
% cc{1} = c;
% 
% port = cc{1};

prompt = 'Шаг двигателя: ';
scl = input(prompt);

prompt = 'Кол-во измерений за сеанс: ';
numb = input(prompt);

prompt = 'Начать с: ';
start = input(prompt);

prompt = 'Имя сохраняемого файла: ';
name = input(prompt, 's');

disp('Начинаем')

num_targ = start-1;%текущее измерение

l = zeros(1,12);
i = 0;
T = 0;
stats = 1;
while stats > 0
    
    prompt = 'Продолжить? (1 - продолжить, 0 - выход): ';
    stats = input(prompt);
    if stats == 1
        T = numb + num_targ;
        temp_targ = num_targ;
        i = num_targ;
        while i < T
            i = i + 1;
            num_targ = num_targ + 1;
            set_zoom(num_targ, scl,port);
            try
                 %меняем зум и начинаем искать меангр
                l = s_MEAS_clvfxptacs_v1();
            catch
               warning('Ошибка подсчета! Поменяйте условия съемки!'); 
               disp(num_targ);
               beep;
               i = i - 1;
               num_targ = num_targ - 1;
               
               continue;
            end
                disp('Удачно: ')
                disp(i);
                print_to_file(l, num_targ*scl, name); 
                disp('Сохранено');
            
            if i==T
                
                disp('Цикл успешно посчитан');
                beep;
                pause(0.5);
                beep;
            end
        end
    elseif stats == 0
       break;
        
       
    end
    
end

disp('Последнее измерение: ');
disp(num_targ);
