function f = find_coeff(x1,y1,x2,y2)
a = y1-y2;
b = x2 - x1;
c = x1*y2-x2*y1;
if b~= 0
   
    co(1) = -1*a/b;%k
    co(2) = -1*c/b;%b    
else 
    co(1) = -1;
    co(2) = -1;
end


f = co;