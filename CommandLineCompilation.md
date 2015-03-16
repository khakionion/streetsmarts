# Introduction #

Sure, you could brew up a project/solution file. Regardless, here's how to compile StreetSmarts on the command-line.

_You must have Mono installed for non-Windows platforms!_

# MacOS #

_Make sure you have X11 installed!_

**`gmcs Form1.cs StreetSmartsRuleProcessor.cs -pkg:dotnet -out:StreetSmartsMac.exe -define:PLATFORM_MAC`**

# Linux #
**`gmcs Form1.cs StreetSmartsRuleProcessor.cs -out:StreetSmartsLin.exe -r:System.Windows.Forms -r:System.Drawing -r:System.Data -define:PLATFORM_LIN`**