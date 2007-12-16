////////////
StreetSmarts
////////////
StreetSmarts is a utility for the mass renaming of files.

It uses its own scripting language, S^3.

To learn S^3, use the reference contained in the program.

//////////////////////
Compiling StreetSmarts
//////////////////////

Be sure and define your platform on the command line. You can use PLATFORM_WIN, PLATFORM_MAC, or PLATFORM LIN. If you don't the program will fail to compile.

MacOS Command Line: gmcs Form1.cs StreetSmartsRuleProcessor.cs -pkg:dotnet -out:StreetSmartsMac.exe -define:PLATFORM_MAC
Linux Command Line: gmcs Form1.cs StreetSmartsRuleProcessor.cs -out:StreetSmartsLin.exe -r:System.Windows.Forms -r:System.Drawing -r:System.Data -define:PLATFORM_LIN

///////////
What's New?
///////////

Version 0.9
-----------
Now compiles and runs in MacOS and Windows. A known MacOS issue is odd behavior when editing the S^3 script.

Version 0.2
-----------
Fixed an unhandled exception related to extended usage. Added the "prepend" and "append" instructions to S^3.

Version 0.1
-----------
First version.  I'm sure there's plenty of bugs.

Thanks, and enjoy!

./Khakionion
