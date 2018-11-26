function  take_spec(filename,filename_out,s1,s2,y1,y2,x1,x2)
%take_spec функция для работы с большим видео. 
%take_spec спектральная чувствительность


vid = VideoReader(filename);
height = vid.Height;
width = vid.Width;
counter = 0;
count_summ = zeros(1,3);
sr2 = zeros(1,3);
sr = zeros(1,3);
tek_sr = 0;
z = zeros(1, 20);

if s2 == 0
    s2 = vid.NumberOfFrames;
end

if x2 == 0
    x2 = width
end

if y2 == 0
    y2 = height
end



for iFrame = s1:s2;
    frame1 = read(vid, iFrame);
    frame=im2double(frame1);
    
           R = 255*frame(:,:,1);
           G = 255*frame(:,:,2);
           B = 255*frame(:,:,3);
           
           
           a = zeros(size(frame, 1), size(frame, 2));
           
           
           for y = y1:y2
               for x = x1:x2
                  if (counter > 9) && (sr(1,1) == 0)
                      sr(1,1) = (count_summ(1,1)/counter);
                      sr(1,2) = (count_summ(1,2)/counter);
                      sr(1,3) = (count_summ(1,3)/counter);
                      counter = 0;
                      count_summ(1,1) = 0;
                      count_summ(1,2) = 0;
                      count_summ(1,3) = 0;
                  elseif(counter > 9)
                      sr2(1,1) = (count_summ(1,1)/counter);
                      sr2(1,2) = (count_summ(1,2)/counter);
                      sr2(1,3) = (count_summ(1,3)/counter);
                      sr(1,1) = (sr2(1,1) + sr(1,1))/2;
                      sr(1,2) = (sr2(1,2) + sr(1,2))/2;
                      sr(1,3) = (sr2(1,3) + sr(1,3))/2;
                      counter = 0;
                      count_summ(1,1) = 0;
                      count_summ(1,2) = 0;
                      count_summ(1,3) = 0;
                  end
                  counter = counter + 1;
                  count_summ(1,1) = count_summ(1,1) + R(y,x);
                  count_summ(1,2) = count_summ(1,2) + G(y,x);
                  count_summ(1,3) = count_summ(1,3) + B(y,x);
               end
           end
           
%    figure;
%            image(frame);
% figure;
%            image(just_red);
%            figure;
%            image(just_green);
%            figure;
%            image(just_blue);

           %z(1,iFrame-4000+1) = sr;
           spec_print_to_file(sr,iFrame,filename_out);
end


