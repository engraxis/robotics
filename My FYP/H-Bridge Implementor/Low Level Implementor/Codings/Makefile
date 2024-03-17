# MPLAB IDE generated this makefile for use with GNU make.
# Project: H_implementors_Codings.mcp
# Date: Thu Jan 31 22:48:28 2013

AS = MPASMWIN.exe
CC = mcc18.exe
LD = mplink.exe
AR = mplib.exe
RM = rm

H_implementors_Codings.cof : direct_hbridge_control.o
	$(LD) /p18F452 /l"C:\Program Files\Microchip\mplabc18\v3.40\lib" "direct_hbridge_control.o" /u_CRUNTIME /u_DEBUG /z__MPLAB_BUILD=1 /z__MPLAB_DEBUG=1 /o"H_implementors_Codings.cof" /M"H_implementors_Codings.map" /W

direct_hbridge_control.o : direct_hbridge_control.c ../../../../../../../Program\ Files/Microchip/mplabc18/v3.40/h/P18f452.h
	$(CC) -p=18F452 "direct_hbridge_control.c" -fo="direct_hbridge_control.o" -D__DEBUG -Ou- -Ot- -Ob- -Op- -Or- -Od- -Opa-

clean : 
	$(RM) "direct_hbridge_control.o" "H_implementors_Codings.cof" "H_implementors_Codings.hex"

