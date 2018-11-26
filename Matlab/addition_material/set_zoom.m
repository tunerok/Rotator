function  set_zoom(m, step, port_number)
%set_zoom зум с выбором порта

if(port_number==1)
    port = 'COM1';
elseif(port_number==2)
    port = 'COM2';
elseif(port_number==3)
    port = 'COM3';
elseif(port_number==4)
    port = 'COM4';
elseif(port_number==5)
    port = 'COM5';
elseif(port_number==6)
    port = 'COM6';
end;

% Find a serial port object.
obj1 = instrfind('Type', 'serial', 'Port', port, 'Tag', '');

% Create the serial port object if it does not exist
% otherwise use the object that was found.
if isempty(obj1)
    obj1 = serial(port);
else
    fclose(obj1);
    obj1 = obj1(1);
end

% Connect to instrument object, obj1.
fopen(obj1);



r = control_summ(m, step);



fwrite(obj1, r, 'uint8');
%id = fread(obj1);
ans = 'OK'


