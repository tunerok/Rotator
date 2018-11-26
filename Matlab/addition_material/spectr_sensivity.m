cam = read_spec('vid_spec/vid_7_all_off.txt',25,0,350,765,1)
st = read_spec_st('vid_spec/halogen_1.txt',25,0,250,700,451)
cam = read_spec('vid_spec/vid_7_all_off.txt',25,0,350,765,1)
st = read_spec_st('vid_spec/halogen_1.txt',25,0,250,700,416)
plot(st{5},(st{4}./cam{4})/max((st{4}./cam{4})))
figure
plot(st{5},(st{4}./cam{4})/max((st{4}./cam{4})))
grid on
st = read_spec_st('vid_spec/halogen_1.txt',25,0,350,765,416)
figure
plot(st{5},(st{4}./cam{4})/max((st{4}./cam{4})))