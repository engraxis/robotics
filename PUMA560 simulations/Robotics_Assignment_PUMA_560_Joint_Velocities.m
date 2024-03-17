% Appendix B : Calculating Joint Velocity when xdot = 5 m/s

clear all
clc

theta1 = 160;
theta2 = 45;
theta3 = 225;
theta4 = 170;
theta5 = 100;
a2 = 3;
a3 = 4;
d3 = 3;
d4 = 2;
s1 = sin(theta1);
s2 = sin(theta2);
s3 = sin(theta3);
s4 = sin(theta4);
s5 = sin(theta5);
c1 = cos(theta1);
c2 = cos(theta2);
c3 = cos(theta3);
c4 = cos(theta4);
c5 = cos(theta5);
s23 = sin(theta1+theta2);
c23 = cos(theta1+theta2);
Jv = [-s1*(a2*c2+a3*c23-d4*s23)-d3*c1 c1*(a2*s2-a3*s23-d4*c23) c1*(-a3*s23-d4*c23)   0       0               0;
       c1*(a2*c2+a3*c23-d4*s23)-d3*s1 c1*(a2*s2-a3*s23-d4*c23) c1*(-a3*s23-d4*c23)   0       0               0;
       0                              -a3*c23-a2*c2+d4*s23     -a3*c23-a2*c2+d4*s23  0       0               0];
Jw = [ 0                              -s1                      -s1                   c1*c23  -c1*c23*s4      -(c1*c23*c4+s1*s4)*s5-c1*s23*c5;
       0                              c1                       c1                    -s1*s23 s1*c23*s4-c1*c4 -(s1*c23*c4-c1*s4)*s5-s1*s23*c5;
       1                              0                        0                     -c23    -s23*s4         s23*c4*s5-c23*c5];
J = [ Jv ; Jw ];     

X = [5 ; 0 ; 0 ; 0 ; 0 ; 0];

theta_dot_matrix = inv(J) * X 