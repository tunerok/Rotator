function resul(name,cut,level, h,b,invert,rot_lvl,limit_rot,del_gov_lvl,is_green)
%имя, сколько срезать, уровень бинаризации, расстояние, угл.поле,
%инвертировать, порог при подсчете пикселей, количество повторений, величина площади оставляемых бинарников(не менее), зеленое? 

im = imread(name);
%im1 = rgb2gray(im);
[g rot res pix_len cou im4 s] = geometry(im,cut,level,h,b,invert,rot_lvl,del_gov_lvl,is_green);
l = rgbtolambda(im);




% cmap1 = gray(2);
% cmap2 = jet(2);
% cmap = [cmap1;cmap2];
% colormap(cmap)


ax3 = subplot(2,3,1);
image(im);
title('Исходное изображение');

ax1 = subplot(2,3,2);
%colormap gray;
image(g,'CDataMapping','scaled');
colormap(ax1,gray)
title('Результат геометрической обработки');

ax2 = subplot(2,3,3);

    l(1) = 650;
    l(2) = 470;
    
   % imshow(g);
   image(l,'CDataMapping','scaled'); %строим
   colorbar;
   colormap(ax2,jet);
   title({'Результат выделения'; 'спектральной характеристики'});
%colormap jet;



x5 = size(cou);
x3 = 1:1:x5(2);
couse = 0;
step = 0;
max_c = 0;
min_c = 64000;

prev = cou(1);

for i = 2:1:x5(2)
    if ((cou(i) == prev) && (cou(i)>0))
        couse = couse + cou(i);
        step = step + 1;
        if ((step == limit_rot) && (couse>0))
            if (couse>max_c)
                max_c = couse;
                couse = 0;
                step = 0;
            end
            if ((couse<min_c) && (couse>0))
                min_c = couse;
                couse = 0;
                step = 0;
            end 
            step = 0;
            couse = 0;
        end
    else
        prev = cou(i);
        step = 0;
        couse = 0;
    end
end


max_c = max_c/limit_rot;
min_c = min_c /limit_rot;
subplot(2,3,4);
r = [s, rot, res, pix_len*res, 6.421,h,b, pix_len, max_c, min_c];

r = r';

t = uitable('Data', r,'ColumnName', {'Результат'}, 'RowName', {'S объекта, пикс.','Alpha, град.', 'L_o, пикс','L_o, м.','t, град','H, м.', 'b, град.','L_pix, м.', 'Макс., пикс.','Мин., пикс.'},'ColumnWidth',{110});


pos = get(subplot(2,3,4),'position');
delete(subplot(2,3,4));
set(t,'units','normalized');
set(t,'position',pos);

% t.Position(3) = t.Extent(3);
% t.Position(4) = t.Extent(4);

subplot(2,3,6)

x13 = 1:0.05:x5(2);
%rese = interp1(x3,cou,x13,'spline');
p = polyfit(x3,cou,20);
rese = polyval(p,x13);




% ff = diff(rese);
% 
% frfr = size(ff);
% 
% for i = 1:1:frfr(2)
%     if (ff(i) == 0)
%         maxq = i;
%     end
% end
% 
% for i = x5(2):-0.05:x5(2)
%     if (ff(i) == 0)
%         minq = i;
%     end
% end
% 
% maxq
% 
% minq

hold on;

plot(x3,cou,'r.');

plot(x13,rese,'b','LineWidth', 2);
ylim([4 15]);

 
n=length(x3); 
y1(1:n)=max_c;
y2(1:n)=min_c;

plot(x3,y1,'g','LineWidth', 2);
plot(x3,y2,'g','LineWidth', 2);
title({'График толщины повернутой линии'; 'с максимальным и минимальным значениями'});
hold off;

ax6 = subplot(2,3,5)
image(im4);
colormap(ax6,gray);
title({'Изображение повернутое'; 'на найденный угол'});
end