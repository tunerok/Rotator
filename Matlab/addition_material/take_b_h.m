function take_b_h(filename,X,Y)
%«апись значений размера кадра приход€щихс€ на один пиксель матрицы из
%дальности H и B угл. пол€.

fileID = fopen(filename,'r');
file = textscan(fileID,'%f %f %f %f %f %f %f %f %f %f %f %f %f');
h = file{7};
b = file{13};
m = length(h);
ac = zeros(1,m);
lx = zeros(1,m);
ly = zeros(1,m);
Pi=3.14;

alpha = 180*atan(X/Y)/Pi;

fid = fopen('b_h_l.txt', 'w');
if fid == -1 
    error('File is not opened'); 
end 


for i = 1:m
   %b(i)=b(i)*2;
   ac(i) = 2*h(i)*tan(b(i)*Pi/180);
   
   ly(i) = ac(i)*cos(alpha*Pi/180)/X;
   lx(i) = ac(i)*sin(alpha*Pi/180)/Y;
   fprintf(fid, '%.5f %.5f %.5f %.5f\r\n', b(i),h(i),ly(i),lx(i) ); 
end


fclose(fid);




