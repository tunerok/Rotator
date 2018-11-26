function print_to_file(Y, i, name)
%запись в текстовый файл полученных измерений 
b = '.txt';

c = [name b];
cc = cell(1);
cc{1} = c;

%fid = fopen('1.txt', 'a'); 
fid = fopen(cc{1}, 'a'); 
if fid == -1 
    error('File is not opened'); 
end 
  
fprintf(fid, ' %i %.5f %.5f %.5f %.5f %.5f %.5f %.5f %.5f %.5f %.5f %.5f %.5f\r\n',i, Y'); 
fclose(fid);