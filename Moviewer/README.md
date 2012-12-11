Moviewer
=======

A wijet which can play videos. Allows the changing of opacity and setting the window on top of other windows to create a 'see-through' video wijet. Uses the Windows Media Player component to play videos.

Compiling
========

Project originally coded in VB.NET 2005 Express.

TODO
=====

**Implement the Ikonize feature. 'Pins' this wijet into the desktop. This requires the Ikonizer module (programmed in VB6). Half implemented
		Usage of Ikonizer module:
			Dim Ikonizer As IkonizerModule.Ikonizer = New IkonizerModule.Ikonizer()
			Dim Handle As Integer = cont_main.Handle.ToInt32() 'cont_main is a panel
			Ikonizer.Ikonize(Handle) 'Ikonizes cont_main (Working well)
			Ikonizer.SetTranslucent(Handle, 255, 200, 3) 'Sets an opacity to the ikonized cont_main via API calls
		Needs to code the wijet so that the cont_main panel can be moved to another position after being ikonized
**Code the favourite videos list
**Design an icon for the btnPin button (that pins the wijet to the top of the screen)
*Design an icon for the program

MISC
====

The PSD folder contains the PSD files for the graphics used in the wijet