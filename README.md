## Overview
The program is a simulation of locating object such as automotive car in some closed space. The moving object is localized using RFID technology. The active sensors
are fixed to moving car and passive sensors are on the floor. Passive sensors which are in the range of active sensor are activated and by its ID we can get x and y coordinates. 
The application is made in C# language and allow users to test impact of RFID parameters on location accuracy. In program we set following parametrs:
###
* number of passive sensors
* range of active sensors
* number of destroyed sensors
* activation method (when more then one passive sensor in range of the active one)
* Type of control (select 'speeds')

After setting parameters users can control moving object by pressing arrows to change linear and rotate speeds. The current localization is shown on the screen. The simulation can be stopped by pressing 'space' button.
The real position is presented nearby to define a accuracy of the localization.

## Technical overwiev
* RFID
* WindowsForm
* C#
