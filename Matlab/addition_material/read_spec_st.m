function s = read_spec_st(filename,polynom_st,revers,x1,x2,numb_of_dots)
%чтение спектра из скачанного файла, полином интерполируется на указанном
%промежутке в x1,x2(1,0 - все значения) с количеством точек step, 
fileID = fopen(filename);
file = textscan(fileID,'%f %f %f %f %f');

y = file{1};
%aver = file{2};
R = file{3};
G = file{4};
B = file{5};

if revers > 0
    R = R(end:-1:1);
    G = G(end:-1:1);
    B = B(end:-1:1);
end


m = length(R);

result = zeros(1,m);
result_you = zeros(1,m);
%y = zeros(1,m);


for i = 1:m
    result(i) = (R(i)+G(i)+B(i))/3;
    %result_you(i) = 0.299*R(i)+0.587*G(i)+0.114*B(i);
    %y(i) = (i)/10 ;
end

result = result';

if (x2<1)
   x2 = y(end); 
end

if (x1 == 1)
   x1 = y(1); 
end

x = x1:((x2-x1)/(numb_of_dots-1)):x2;

p = polyfit(y,result,polynom_st); %точки, что, степень -> коэфф-ты полинома  ~20степень пока
res = polyval(p,x);      %полином проводим на сетке

p = polyfit(y,R,polynom_st);
R = polyval(p,x); 

p = polyfit(y,G,polynom_st);
G = polyval(p,x); 

p = polyfit(y,B,polynom_st);
B = polyval(p,x); 

output{1} = R;
output{2} = G;
output{3} = B;
output{5} = x;

figure;
%subplot(2,2,1);
% hold on;
% plot(y,result, 'b.'); точки суммы
% title('Summ All');

hold on;
plot(x,res,'LineWidth',2,'Color',[1 1 0]);
title('Summ All');
%grid on;

%subplot(2,2,2);

plot(y,result,'LineWidth',0.5,'Color',[0.35 0 0.61]);
title('Summ YUV');
%grid on;

%subplot(2,2,[3,4]);
plot(x,R,'LineWidth',1,'Color',[1 0 0]);
hold on;
plot(x,G,'LineWidth',1,'Color',[0 0.5 0]);
plot(x,B,'LineWidth',1,'Color',[0 0 1]);
grid on;
title(filename)

res = res/max(res);
figure
hold on;
plot(x,res,'LineWidth',2,'Color',[0 0 1]);
title('Norm Spectr');

output{4} = res;

%plot(st{5},(st{4}./cam{4})/max((st{4}./cam{4}))) построение итогового
%графика камеры

s = output;


