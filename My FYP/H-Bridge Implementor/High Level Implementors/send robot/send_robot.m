function   send_robot(robot_command,arg1,arg2)
%SEND_ROBOT communicates with the robotic soldier by passing robot
%commands and the arguments that are necessary to perform that command 
%   Detailed explanation goes here
%---------------------------------------------------------------------------------
%Creating the serial port object
%---------------------------------------------------------------------------------
s=serial('COM4','baudrate',9600)
fopen(s);
%----------------------------------------------------------------------------------
%Sending the commands to the robot
%----------------------------------------------------------------------------------
pause(0.050);
fwrite(s,robot_command,'uchar');
pause(0.050);
fwrite(s,arg1,'uchar');
pause(0.050);
fwrite(s,arg2,'uchar');
pause(0.050);
%---------------------------------------------------------------------------------
%Closing and clearing the serial port object
%---------------------------------------------------------------------------------
fclose(s);
clear s;
end

