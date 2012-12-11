Moviewer
=======

A wijet which can play videos. Allows the changing of opacity and setting the window on top of other windows to create a 'see-through' video wijet. Uses the Windows Media Player component to play videos.

Compiling
========

Project originally coded in VB.NET 2005 Express.

TODO
=====
<ul>
<li>
Implement the Ikonize feature. 'Pins' this wijet into the desktop. This requires the Ikonizer module (programmed in VB6). Half implemented<br>
    Usage of Ikonizer module:
    <br><br>
			Dim Ikonizer As IkonizerModule.Ikonizer = New IkonizerModule.Ikonizer()<br>
			Dim Handle As Integer = cont_main.Handle.ToInt32() <i>'cont_main is a panel</i><br>
			Ikonizer.Ikonize(Handle) <i>'Ikonizes cont_main (Working well)</i><br>
			Ikonizer.SetTranslucent(Handle, 255, 200, 3) <i>'Sets an opacity to the ikonized cont_main via API calls</i><br><br>
		Needs to code the wijet so that the cont_main panel can be moved to another position after being ikonized<br>
</li>
<li>Code the favourite videos list</li>
<li>Design an icon for the btnPin button (that pins the wijet to the top of the screen)</li>
<li>Design an icon for the program</li>
</ul>

MISC
====

The PSD folder contains the PSD files for the graphics used in the wijet