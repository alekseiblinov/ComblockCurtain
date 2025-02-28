# ComblockCurtain
--------------------------------
##	General description.

The control for WinForms and WPF is a panel with a hidden keyboard. 
The keyboard has a telephone format: a grid of buttons with numbers from 0 to 9 in the form of such an arrangement:
||||
|-|-|-|
|1|2|3|
|4|5|6|
|7|8|9|
||0||

Unlocks and clears the panel when entering a sequence of digits corresponding to the value of the *LOCKER_SEQUENCE* constant.
It can be used to hide Easter eggs in programs.

##	The composition of the project.

- **ComblockCurtainCommonLogic** - functions and data common to the ComblockCurtainControlWinForms and ComblockCurtainControlWpf controls.
- **ComblockCurtainControlWinForms** - a control for use in WinForms applications.
- **ComblockCurtainControlWpf** - a control for use in WPF applications.
- **ComblockCurtainTestAppWinForms** - a utility for testing the ComblockCurtainControlWinForms control.
- **ComblockCurtainTestAppWpf** - a utility for testing the ComblockCurtainControlWpf control.
