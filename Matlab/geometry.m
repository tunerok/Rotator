function [f ro re pix_len cou r s] = geometry(frame2,cut,level,h,b,invert,lvl_rotated,gov,green)


%frame2 = imread(name);
%frame2 = rgb2gray(frame2);

if(green == 1)

im2 = frame2(:,:,2); % Green channel

im2 = 255*im2bw(im2,level);

im3 = medfilt2(im2, [15 15]);

im2 = im2 - im3;
im2 = im2bw(im2,0.5);

im2=bwmorph(im2, 'dilate');
im2=bwmorph(im2, 'bridge');

im2=bwareaopen(im2,gov); %del gov

im2=255*bwmorph(im2, 'bridge');

im2 = medfilt2(im2);

else
    im2 = rgb2gray(frame2);
    im2 = 255*im2bw(im2,level);

end

if (invert == 1)
    im4_t = im2;
im2 = 255 - im2;
else im4_t=im2;
end

%h = 2.8;
%b = 18;
rot_int = 0.3;
summ_co = 0.01;
coeff_por = 3;
ac = 2*h*tan((b/2)*pi/180);

[x,y] = size(im2);




for j = cut:1:y-cut
    for i = cut:1:x-cut
            frame(i-cut+1,j-cut+1) = frame2(i,j);
            im(i-cut+1,j-cut+1) = im2(i,j);
    end
end

[x,y] = size(im);


trigger = 0;

alpha = 180*atan(x/y)/pi;
pix_len = ac*sin(alpha*pi/180)/y;

max = find_dots(im,200);
r = find_lines(max);
res = 0;
rot = 0;

if (r(3)>1+rot_int)
    res = r(1);
    rot = 0;
    coeff = find_coeff(max(1,3),max(2,3),max(1,4),max(2,4));
    
end
if (r(3)<1-rot_int)
    res = r(2);
    rot = 90;
    coeff = find_coeff(max(1,1),max(2,1),max(1,2),max(2,2));
end

g = 1;

if res == 0
    cen = find_diag_lines(max);
    res = find_line(cen(1,1),cen(2,1),cen(1,2),cen(2,2));
    coeff = find_coeff(cen(1,1),cen(2,1),cen(1,2),cen(2,2));
    e_0_1 = abs(cen(2,1)-cen(2,2));%вертикаль
    e_0_2 = abs(cen(1,1)-cen(1,2));%горизонталь

    if(cen(1,1)<cen(1,2))
        g = -1;
    end
    
    if e_0_2 ~= 0
        
    rot = 90 - g*180*atan(e_0_1/e_0_2)/pi;
    else
        rot = 90;
    end
    
    trigger = 1;
    
    
    
end



im4 = imrotate(im4_t,rot);

[x1,y1] = size(im4);

counter = zeros(1,x1);

for j = 1:1:y1
    for i = 1:1:x1
        if im4(i,j)<lvl_rotated
            continue;
        else counter(j) = counter(j)+1;
        end
   end
end

r = im4;
cou = counter;

w = 3;




for j = 1:1:y+1
    for i = 1:1:x+1
        if (j < (round(coeff(1)*i)+round(coeff(2)))+ w) && (j > (round(coeff(1)*i)+round(coeff(2))) - w)
            res_im(i,j) = 250;
            im2(i,j) = 0;
        else
            res_im(i,j) = im2(i,j);
        end
    end
end

dd = im2/255;
s=bwarea(dd); 

rgbImage = cat(3, res_im, im2, im2);
pix_len = pix_len;
ro = rot;
re=res;

f = rgbImage;
% coeff
% image(res_im,'CDataMapping','scaled');
% colormap gray;
% rot
% res


