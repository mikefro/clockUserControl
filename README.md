# clockUserControl
 Implementing an alarm clock using the UserControl Class with C #


This project is about creating and using personalised controls. 
You can find information on the personalised user controls and Events on the below links.

[UserControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.usercontrol?view=netframework-4.7.2)
[Events](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event) 
[Raise and consume Events](https://docs.microsoft.com/en-us/dotnet/standard/events/how-to-raise-and-consume-events)

In this case I have created a digital clock with an alarm that raises an event where user functions can be added by the programmer. See below screen shot of the User Control:

<p align="center">
  <img width="508" height="228" src="https://github.com/miquelpaucasesnoves/clockUserControl/blob/main/screenshots/screenshot.png">
</p>


## Installation: 

You can download the complete project if you wish to modify it for your own use.
Or you can go to the following link if you prefer to download and use the User Control directly [Digital Clock] clockcontrol/ …

- When using the User Control go to Toolbox list and click right and select Add Tab from the menu.

- Once you have created the new Tab click right and then click Choose Item on the menu.

- Click on the browser button and search for the library where you have downloaded.

- Click on the OK button and the User Control will appear on the Toolbox list.

- you can now drag the component to your project.

## Properties and characteristics of the Digital Clock

The Digital Clock has the following additional features:
- Boolean Format24hours; to set 12 or 24 hours as time format (djfgkjg)
- Alarm feature: for this to activate it is characterised by an hour and a minute. The User Control takes care of building the Alarm object.
- Features the event Alarm Activated where you can add the desired functions when the alarm is turned on.

## Support and new input

If you encounter problems when using the User Control or if you believe it can be improved, please do not hesitate to open an issue in the repository. Any feedback is welcome.

## Roadmap

Moving forward I would like to expand the User Control features. Some ideas are:

- Postpone alarm
- Option to add more than one alarm
- Choose the activation date

## License 

This project does not currently have any license
