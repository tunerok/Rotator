function rgbtolambda(num)
%выделение спектральной состовл€ющей из изображени€



vid = videoinput('winvideo', num, 'MJPG_320x240');
src = getselectedsource(vid);
%src.AnalogVideoFormat = 'pal_i';



while (true)
frame_p = getsnapshot(vid);
hsvp = rgb2hsv(frame_p);
h1 = hsvp(:,:,1); %выделение хуэ

v = hsvp(:,:,3);


%s1_p = hsvp(:,:,2);
%v1_p = hsvp(:,:,3);
m = size(h1);
h1_gr = h1*360; 

%перевод в градусы
for i = 1:1:m(1)  %отсечение повтор€ющегос€ круга(красный цвет переходит в фиолетовый(обычный порог ==240))
    for j = 1:1:m(2)
        if(h1_gr(i,j)>330)
            h1_gr(i,j)=360-h1_gr(i,j);
        end
    end
end   
    l=(600-(600-475)*h1_gr/240); %вывел перевод в длину волны. 650 - макс длина волны, 475 - мин длина волны, 240 - градаци€ в хуэ
    colormap jet;
    
    %l = l*255/650;
    image(l,'CDataMapping','scaled'); %строим
   % colorbar;
    
end