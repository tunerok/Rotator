

%��������� ���� ���������� + ���������� �������� � ������

beep on;
pause on;
% 
prompt = '����� �����: ';
port = input(prompt);

% prompt = '����� �����: ';
% port_numb = input(prompt);

% com = 'COM';
% port_numb=int2str(port_numb);
% c = [com port_numb];
% cc = cell(1);
% cc{1} = c;
% 
% port = cc{1};

prompt = '��� ���������: ';
scl = input(prompt);

prompt = '���-�� ��������� �� �����: ';
numb = input(prompt);

prompt = '������ �: ';
start = input(prompt);

prompt = '��� ������������ �����: ';
name = input(prompt, 's');

disp('��������')

num_targ = start-1;%������� ���������

l = zeros(1,12);
i = 0;
T = 0;
stats = 1;
while stats > 0
    
    prompt = '����������? (1 - ����������, 0 - �����): ';
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
                 %������ ��� � �������� ������ ������
                l = s_MEAS_clvfxptacs_v1();
            catch
               warning('������ ��������! ��������� ������� ������!'); 
               disp(num_targ);
               beep;
               i = i - 1;
               num_targ = num_targ - 1;
               
               continue;
            end
                disp('������: ')
                disp(i);
                print_to_file(l, num_targ*scl, name); 
                disp('���������');
            
            if i==T
                
                disp('���� ������� ��������');
                beep;
                pause(0.5);
                beep;
            end
        end
    elseif stats == 0
       break;
        
       
    end
    
end

disp('��������� ���������: ');
disp(num_targ);
