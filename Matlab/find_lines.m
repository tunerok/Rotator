function f = find_lines(max)

g = zeros(1,3);
g(1) = find_line(max(1,1),max(2,1),max(1,2),max(2,2));%1-x,2-y 
g(2) = find_line(max(1,3),max(2,3),max(1,4),max(2,4));

if (g(1) ~= 0)
   g(3) = g(2)/g(1);
else
    g(3) = g(2);
end

f = g;