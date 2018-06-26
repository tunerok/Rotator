function r = find_dots(im,level)
%im = imread(im);
%im = rgb2gray(im);
j = 0;
i = 0;
[x,y] = size(im);

y = y-1;
x = x-1;

max = zeros(2,4);
%max_y
for i = 1:1:y
    for j = 1:1:x
        if im(j,i)<level;
            max(1,1) = j;
            max(2,1) = i;
            break;
        end
    end
end

for i = y:-1:1 %min_y
    for j = 1:1:x
        if im(j,i)<level;
            max(1,2) = j;
            max(2,2) = i;
            break;
        end
    end
end

%max_x
for i = x:-1:1
    for j = 1:1:y
        if im(i,j)<level;
            max(1,3) = i;
            max(2,3) = j;
            break;
        end
    end
end

%min_x
for i = 1:1:x
    for j = 1:1:y
        if im(i,j)<level;
            max(1,4) = i;
            max(2,4) = j;
            break;
        end
    end
end

r = max;