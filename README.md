# project.mobilephone.retrievephotos
interface to interact with the files on your mobile phone, connected by USB

I needed a program to have an "easy" interaction with a mobile phone, it is quite difficult to explain to my uncle and aunt how to open explorer, go to the right folder, select the files, choose copy, browse to a local folder, create a new folder and "paste" them here.

I started by cloning this project:

https://github.com/jtorjo/external_drive_lib

John Torjo did I great job to use the Win32 API in C# #shoutout

Then I created a library, PhoneConnector, which uses this library.

I implemented a few items which I need from the external_drive_lib, so I can "abstract away" the library of John in my actual program.

Then I created the "UsbSync" C# program which uses my PhoneConnector library.

In the App.config file I configure all settings. If you set <add key="debug" value="true" /> then you can copy the path of the folder you select in the tree. You can use that value in the "mobile_photo" en "mobile_whatsapp" settings. And you can also set "preset_phone" if you have selected a phone in the first screen, so it auto-selects the next time you start searching for the connected phone.

Step 1: clone external_drive_lib of John Torjo and build it with Visual Studio.

Step 2: add the created DLL in the PhoneConnector project and build the PhoneConnector library with Visual Studio.

Step 3: add the PhoneConnector dll in the UsbSync project and build the project with Visual Studio.

Step 4: you should be ready to go, start UsbSync.exe. Good luck!

No Visual Studio on your pc? Get the Community Edition here: https://visualstudio.microsoft.com/downloads/