function rgbtolambda(num)
%��������� ������������ ������������ �� �����������



vid = videoinput('winvideo', num, 'MJPG_320x240');
src = getselectedsource(vid);
%src.AnalogVideoFormat = 'pal_i';



while (true)
frame_p = getsnapshot(vid);
hsvp = rgb2hsv(frame_p);
h1 = hsvp(:,:,1); %��������� ���

v = hsvp(:,:,3);


%s1_p = hsvp(:,:,2);
%v1_p = hsvp(:,:,3);
m = size(h1);
h1_gr = h1*360; 

%������� � �������
for i = 1:1:m(1)  %��������� �������������� �����(������� ���� ��������� � ����������(������� ����� ==240))
    for j = 1:1:m(2)
        if(h1_gr(i,j)>330)
            h1_gr(i,j)=360-h1_gr(i,j);
        end
    end
end   
    l=(600-(600-475)*h1_gr/240); %����� ������� � ����� �����. 650 - ���� ����� �����, 475 - ��� ����� �����, 240 - �������� � ���
    colormap jet;
    
    %l = l*255/650;
    image(l,'CDataMapping','scaled'); %������
   % colorbar;
    
end