# Rotator
Программа для поворота исходного изображения на определенный угол. Угол рассчитывается из лазерной проекции линии. Т.е. по подобному изображению можно определить относительное расстояние до каждой точки данной линии

Функция
resul(name,cut,level, h,b,invert,rot_lvl,limit_rot,del_gov_lvl,is_green)

имя файла изобр-ия, сколько срезать рамкой, уровень бинаризации, расстояние до объекта, угл.поле, инвертировать поворотную область (0,1), порог при подсчете пикселей, количество повторений, величина площади оставляемых бинарников(не менее), линия зеленая(1,0) 