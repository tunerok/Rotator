zt = [0.00004 0.00012 0.00040 0.0012 0.0040 0.0116 0.023 0.038 0.060 0.091 0.139 0.208 0.323 0.503 0.710 0.862 0.954 0.995 0.995 0.952 0.870 0.757 0.631 0.503 0.381 0.265 0.175 0.107 0.061 0.032 0.017 0.0082 0.0041 0.0021 0.00105 0.00052 0.00025 0.00012 0.00006 0.00003];
y = 380:9.75:760.25;
x = 380:1:770;
vq2 = interp1(y,zt,x,'spline');
% p = polyfit(y,zt,45);
% R = polyval(p,x); 
plot(x,vq2);
