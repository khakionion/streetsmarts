////////////
StreetSmarts
////////////
StreetSmarts is a utility for the mass renaming of files.

It uses its own scripting language, S^3.

To learn S^3, use the reference contained in the program.

//////////////////////
Compiling StreetSmarts
//////////////////////

On Windows, you must define PLATFORM_WIN when compiling.

On MacOS, make sure Mono is installed and use the gmcs command. You must define PLATFORM_MAC or the program will fail to compile:

	gmcs Form1.cs StreetSmartsRuleProcessor.cs -pkg:dotnet -out:StreetSmartsMac.exe -define:PLATFORM_MAC

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
