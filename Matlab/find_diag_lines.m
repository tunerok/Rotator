function f = find_diag_lines(max)
max_x_min_y = find_line(max(1,2),max(2,2),max(1,3),max(2,3));
max_x_max_y = find_line(max(1,1),max(2,1),max(1,3),max(2,3));

c = zeros(2);

if (max_x_min_y<max_x_max_y)
    c(2,1) = round((max(2,1)+max(2,4))/2);
    c(1,1) = round((max(1,1)+max(1,4))/2);
    c(2,2) = round((max(2,2)+max(2,3))/2);
    c(1,2) = round((max(1,2)+max(1,3))/2);
else
    c(2,1) = round((max(2,1)+max(2,3))/2);
    c(1,1) = round((max(1,1)+max(1,3))/2);
    c(2,2) = round((max(2,2)+max(2,4))/2);
    c(1,2) = round((max(1,2)+max(1,4))/2);
    
end

f = c;