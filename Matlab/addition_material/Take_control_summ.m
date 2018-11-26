function f = Take_control_summ(a1,a2,a3,a4,a5,a6)
%Take_control_summ подсчет контрольной суммы для любой команды. в хексе
zt = [hex2dec(a1), hex2dec(a2), hex2dec(a3), hex2dec(a4), hex2dec(a5), hex2dec(a6), 0];

r  = zt(1) + zt(2) + zt(3) + zt(4) +zt(5)+zt(6);
if r>255
    zt(7) = 512 - r;
else
    zt(7) = r;
end
f = zt;