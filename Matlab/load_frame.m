function s=load_frame(im, level)

frame = imread(im);
frame = rgb2gray(frame);

frame = im2bw(frame,level);


s=frame;