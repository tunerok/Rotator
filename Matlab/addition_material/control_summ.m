function f = control_summ(x, step)
%control_summ контрольная сумма для случая с зумом
x = x - 1;
x = x*step;
zt = [131 139 4 80 0 0 158];
if x > 255
    zt(3) = floor(x / 256);
    zt(4) = x - zt(3)*256;
else
    zt(3) = 0;
    zt(4) = x;
end  
r  = zt(1) + zt(2) + zt(3) + zt(4);
if r>255
    zt(7) = 512 - r;
else
    zt(7) = r;
end
f = zt;