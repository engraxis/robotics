%%
% SUBJECT : ROBOTICS
% ASSIGNMENT : IMPLEMENTING FOLLOWING PARAMETERS ON PUMA-560 ROBOTIC
% MANIPULATOR:

% 1. FORWARD KINEMATICS
% 2. INVERSE KINEMATICS
% 3. JACOBIAN
% 4. SINGULARITY
% 5. WORKSPACE

clear all
clc

%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%          FORWARD KINEMATICS
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%      General Transformation Matrix
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
syms al a t d 
% al = alpha (i-1)
% a = a (i-1)
% t = theta (i)
% d = d (i-1)
Rx=[1 0 0 0; 0 cos(al) -sin(al) 0; 0 sin(al) cos(al) 0; 0 0 0 1];
Dx=[1 0 0 a; 0 1 0 0; 0 0 1 0; 0 0 0 1];
Rz=[cos(t) -sin(t) 0 0 ; sin(t) cos(t) 0 0; 0 0 1 0; 0 0 0 1];
Dz=[1 0 0 0 ; 0 1 0 0; 0 0 1 d; 0 0 0 1];
s_T = Rx * Dx * Rz * Dz;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Getting values of user defined parameters to be filled in D-H Table
L2 = 3;
L3 = 5;
D3 = 3;
D4 = 2;

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%             D-H TABLE 
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
syms s_a2 s_a3 s_d3 s_d4 s_theta1 s_theta2 s_theta3 s_theta4 s_theta5 s_theta6

%        al = alpha(i-1)    a = a(i-1)     d = d(i)        theta = theta(i-1)
D_H = [  0                  0              0               s_theta1;
         -pi/2              0              0               s_theta2;
         0                  s_a2           s_d3            s_theta3;
         -pi/2              s_a3           s_d4            s_theta4;
         pi/2               0              0               s_theta5;
         -pi/2              0              0               s_theta6  ];
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%    Developing Transformation Matrices 
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
s_T_1_0 = subs( s_T, {al,a,d,t} , {D_H(1,1) , D_H(1,2) , D_H(1,3) , D_H(1,4)} );
s_T_2_1 = subs( s_T, {al,a,d,t} , {D_H(2,1) , D_H(2,2) , D_H(2,3) , D_H(2,4)} );
s_T_3_2 = subs( s_T, {al,a,d,t} , {D_H(3,1) , D_H(3,2) , D_H(3,3) , D_H(3,4)} );
s_T_4_3 = subs( s_T, {al,a,d,t} , {D_H(4,1) , D_H(4,2) , D_H(4,3) , D_H(4,4)} );
s_T_5_4 = subs( s_T, {al,a,d,t} , {D_H(5,1) , D_H(5,2) , D_H(5,3) , D_H(5,4)} );
s_T_6_5 = subs( s_T, {al,a,d,t} , {D_H(6,1) , D_H(6,2) , D_H(6,3) , D_H(6,4)} );
% All Frames w.r.t Base Frames:
s_T_2_0 = s_T_1_0 * s_T_2_1;
s_T_3_0 = s_T_1_0 * s_T_2_1 * s_T_3_2;
s_T_4_0 = s_T_1_0 * s_T_2_1 * s_T_3_2 * s_T_4_3;
s_T_5_0 = s_T_1_0 * s_T_2_1 * s_T_3_2 * s_T_4_3 * s_T_5_4;
s_T_6_0 = s_T_1_0 * s_T_2_1 * s_T_3_2 * s_T_4_3 * s_T_5_4 * s_T_6_5;

% Forward Kinematics: Joint Space to Cartesian Space
theta1 = input('Enter 1st joint angle = ');
theta2 = input('Enter 2nd joint angle = ');
theta3 = input('Enter 3rd joint angle = ');
theta4 = input('Enter 4th joint angle = ');
theta5 = input('Enter 5th joint angle = ');
theta6 = input('Enter 6th joint angle = ');

% Plotting the results after substiting values in 'symbol' variables
% Substitution
T_1_0 = subs(s_T_1_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_2_0 = subs(s_T_2_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_3_0 = subs(s_T_3_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_4_0 = subs(s_T_4_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_5_0 = subs(s_T_5_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_6_0 = subs(s_T_6_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
% Plotting
hold on; 
plot3([0          , T_2_0(1,4)] , [0          , T_2_0(2,4)] , [0          , T_2_0(3,4)] , 'y');
plot3([T_2_0(1,4) , T_3_0(1,4)] , [T_2_0(2,4) , T_3_0(2,4)] , [T_2_0(3,4) , T_3_0(3,4)] , 'g');
plot3([T_3_0(1,4) , T_4_0(1,4)] , [T_3_0(2,4) , T_4_0(2,4)] , [T_3_0(3,4) , T_4_0(3,4)] , 'r');
plot3([T_4_0(1,4) , T_5_0(1,4)] , [T_4_0(2,4) , T_5_0(2,4)] , [T_4_0(3,4) , T_5_0(3,4)] , 'c');
plot3([T_5_0(1,4) , T_6_0(1,4)] , [T_5_0(2,4) , T_6_0(2,4)] , [T_5_0(3,4) , T_6_0(3,4)] , 'm');
grid on;
legend('1st Link','2nd Link','3rd Link','4th Link','5th Link','6th Link');
xlabel('X - Axis');
ylabel('Y - Axis');
zlabel('Z - Axis');
title('6-DOF PUMA 560 (Forward Kinematics)');

%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%          INVERSE KINEMATICS
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

figure;

% Inverse Kinematics: Cartesian Space to Joint Space
px = input('Enter x coordinate = ');
py = input('Enter y coordinate = ');
pz = input('Enter z coordinate = ');

% Finding Inverse Kinematics using Inverse Transform Approach
% Performed Matrix Operations on Notebook

% Calculating theta1
theta1 = atan2(px,py) - atan2( D3 , sqrt(px^2+py^2-D3^2) );
% Calculating theta3
N = ( px^2 + py^2 + pz^2 - L2^2 - L3^2 - D4^2 - D3^2 ) / (2 * L2);
theta3 = atan2( sqrt(L3^2+D4^2-N^2) , N) - atan2(D4,L3);
% Calculating theta2
s23 = ( (-L3-L2*cos(theta3))*pz + (cos(theta1)*px+sin(theta1)*py) * (L2*sin(theta3)-D4) ) / ( pz^2+(cos(theta1)*px+sin(theta1)*py)^2);
c23 = ( (L2*sin(theta3)-D4)*pz - (L3+L2*cos(theta3))*(cos(theta1)*px+sin(theta1)*py) ) /  ( pz^2+(cos(theta1)*px+sin(theta1)*py)^2);
theta23 = atan2(s23,c23);
theta2 = theta23-theta3;
% Calculating theta4
theta4 = atan2((-T_6_0(1,3)*sin(theta1)+T_6_0(2,3)*cos(theta1)) , ((-T_6_0(1,3)*cos(theta1)*cos(theta2+theta3))-(T_6_0(2,3)*sin(theta1)*cos(theta2+theta3))+(T_6_0(3,3)*sin(theta2+theta3))));                 
% Calculating theta5
s5 = -T_6_0(1,3)*(cos(theta1)*cos(theta2+theta3)*cos(theta4)+sin(theta1)*sin(theta4))-T_6_0(2,3)*(sin(theta1)*cos(theta2+theta3)*cos(theta4)-cos(theta1)*sin(theta4))-T_6_0(3,3)*(sin(theta2+theta3)*cos(theta4));                                                                  
c5 = T_6_0(1,3)*(-cos(theta1)*sin(theta2+theta3))+T_6_0(2,3)*(-sin(theta1)*sin(theta2+theta3))+T_6_0(3,3)*(-cos(theta2+theta3));
theta5 = atan2(s5 , c5);
% Calculating theta6
s6 = T_6_0(1,1)*(-cos(theta1)*cos(theta2+theta3)*sin(theta4)+sin(theta1)*cos(theta4))-T_6_0(2,1)*(sin(theta1)*cos(theta2+theta3)*sin(theta4)+cos(theta1)*cos(theta4))+T_6_0(3,1)*(sin(theta2+theta3)*sin(theta4));
c6 = T_6_0(1,2)*(-cos(theta1)*cos(theta2+theta3)*sin(theta4)+sin(theta1)*cos(theta4))-T_6_0(2,2)*(sin(theta1)*cos(theta2+theta3)*sin(theta4)+cos(theta1)*cos(theta4))+T_6_0(3,2)*(sin(theta2+theta3)*sin(theta4)); 
theta6 = atan2(s6, c6);

% Plotting the results after substiting values in 'symbol' variables
% Substitution
T_1_0 = subs(s_T_1_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_2_0 = subs(s_T_2_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_3_0 = subs(s_T_3_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_4_0 = subs(s_T_4_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_5_0 = subs(s_T_5_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
T_6_0 = subs(s_T_6_0,{s_a2 , s_a3 , s_d3 , s_d4 , s_theta1 , s_theta2 , s_theta3 , s_theta4 , s_theta5 , s_theta6},{L2 , L3 , D3 , D4 , 3.14/180*theta1 , 3.14/180*theta2 , 3.14/180*theta3 , 3.14/180*theta4 , 3.14/180*theta5 , 3.14/180*theta6});
% Plotting
hold on; 
plot3([0          , T_2_0(1,4)] , [0          , T_2_0(2,4)] , [0          , T_2_0(3,4)] , 'y');
plot3([T_2_0(1,4) , T_3_0(1,4)] , [T_2_0(2,4) , T_3_0(2,4)] , [T_2_0(3,4) , T_3_0(3,4)] , 'g');
plot3([T_3_0(1,4) , T_4_0(1,4)] , [T_3_0(2,4) , T_4_0(2,4)] , [T_3_0(3,4) , T_4_0(3,4)] , 'r');
plot3([T_4_0(1,4) , T_5_0(1,4)] , [T_4_0(2,4) , T_5_0(2,4)] , [T_4_0(3,4) , T_5_0(3,4)] , 'c');
plot3([T_5_0(1,4) , T_6_0(1,4)] , [T_5_0(2,4) , T_6_0(2,4)] , [T_5_0(3,4) , T_6_0(3,4)] , 'm');
grid on;
legend('1st Link','2nd Link','3rd Link','4th Link','5th Link','6th Link');
xlabel('X - Axis');
ylabel('Y - Axis');
zlabel('Z - Axis');
title('6-DOF PUMA 560 (Forward Kinematics)');














