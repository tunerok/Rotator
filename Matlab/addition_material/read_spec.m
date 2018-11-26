function f = read_spec(filename,polynom_st,revers,x1,x2,step)
%чтение спектра из файла
%чтение спектра из скачанного файла, полином интерполируется на указанном
%промежутке в x1,x2(1,0 - все значения) с шагом в step, 
fileID = fopen(filename);
file = textscan(fileID,'%f %f %f %f');
R = file{2};
G = file{3};
B = file{4};

if revers > 0
    R = R(end:-1:1);
    G = G(end:-1:1);
    B = B(end:-1:1);
end

%qu = 5;
m = length(R);
result = zeros(1,m);
result_you = zeros(1,m);
y = zeros(1,m);


for i = 1:m
%     if (B(i)>0.85*255)
%         B(i) = B(i) - 0.3*255;
%     end
    result(i) = (R(i)+G(i)+B(i))/3;
    %result_you(i) = 0.299*R(i)+0.587*G(i)+0.114*B(i);
    y(i) = (i/10);
    %result_you(i) = (1/qu*sqrt(2*pi))*exp((-(i-555)*(i-555))/2*qu*qu);
   
end

if (x2<1)
   x2 = y(end); 
end

if (x1 == 1)
   x1 = y(1); 
end



y = y';
result = result';
%result_you = result_you';

x = x1:step:x2;
if (polynom_st>0)
p = polyfit(y,result,polynom_st); %точки, что, степень -> коэфф-ты полинома  ~20степень пока
res = polyval(p,x);      %полином проводим на сетке
else
    res = interp1(y,result,x,'spline');
end
% p = polyfit(y,R,polynom_st);
% R = polyval(p,x); 
% 
% 
% 
% p = polyfit(y,G,polynom_st);
% G = polyval(p,x); 
% 
% p = polyfit(y,B,polynom_st);
% B = polyval(p,x); 

% p = polyfit(y,result_you,polynom_st);
% result_you = polyval(p,x);

output{1} = R;
output{2} = G;
output{3} = B;
output{5} = x;

      %полином проводим на сетке


figure;
%subplot(2,2,1);
% hold on;
% plot(y,result, 'b.'); точки суммы
% title('Summ All');


hold on;
plot(x,res/255,'LineWidth',4,'Color',[0 0 0]);
%title('Summ All');
% %grid on;

%subplot(2,2,2);

%plot(y,result/255,'LineWidth',0.5,'Color',[0.35 0 0.61]);
%title('Summ YUV');
%grid on;



%subplot(2,2,[3,4]);
plot(y,R/255,'LineWidth',1,'Color',[1 0 0]);
hold on;
plot(y,G/255,'LineWidth',1,'Color',[0 0.5 0]);
plot(y,B/255,'LineWidth',1,'Color',[0 0 1]);
grid on;
%title(filename)

res = res/max(res);
figure
hold on;
plot(x,res/255,'LineWidth',2,'Color',[1 0 0]);
% figure
% plot(result_you,'LineWidth',0.5,'Color',[1 0 1]);

%title('Norm Spectr');

output{4} = res;
f = output


