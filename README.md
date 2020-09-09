# 1.7.6       
Fixed an issue where it was possible to enter invalid characters into Title ID Feild           
Fixed some UI Elements            
Changed \n to \r\n to make gmac output show properly on win10.           
Fixed Auto Update for REAL this time

Download: https://github.com/KuromeSan/GayMaker/releases/download/v1.7.6/GayMaker.1.7.6.zip

# 1.7.5    
Fixed a bug where /SH argument would allways = False regardles of what was set in project file
Fixed automatic updater

Download: https://github.com/KuromeSan/GayMaker/releases/download/V1.7.5/GayMaker.1.7.5.zip

# 1.7.3    
Fixed a bug where if you never opened "Global Game Settings" in GameMaker   
Then GayMaker would crash (IT WAS A STRANGE PARSER DIFFERNTAL xD)   
See issue #9    

Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.7.3.zip

# 1.7.2    
Fixed a bug where StandardError wasnt shown in output properly    
No longer requires %SCE_PSP2_SDK_DIR% to be defined when building YYC.   
    
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.7.2.zip   
     
# 1.7.1    
Fixed a bug where Errors from GMAssetCompiler wouldnt show in the output      
Now displays GMAssetCompiler and YYC Compile errors in a messagebox.    

Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.7.1.zip    

# 1.7  
Added a "Preferences" option
Added the ability to disable Update Checks  
Added the ability to not save last used settings  
Added the ability to not convert PNG's to indexed color  
Added the ability to use YYC! (Requires some efforts to do though)   
Added a seecret easter egg (try to find it!)  

Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.7.zip

# 1.6    
Added "Interpolate colors between pixels" to Global Game Settings  
Added "Scaling options" (Full Scale) and (Keep Aspect Ratio) options to Global Game Settings  
Added "Download More RAM" feature to allow you to allocate more memory to your application  
  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.6.zip
  
# 1.5.2
No-longer reliant on pngquant.exe (close #6)  
Added Early-Access builds to the Version Manager  

Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.5.2.zip  

# 1.5.1
Added version selection and version selector. - you can now use ANY version of GameMaker:Studio Since 1.4.1468.  
Files are downloaded from yoyo's servers!  
  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.5.1.zip  
  
# 1.5
Under "Global Game Settings" you can now simply press <ENTER> to apply settings, or <ESC> to cancel   
Disabled Windows Automatic DPI Scaling (see issue #8 to understand why i did this)    
Now using unmodified GMAssetCompiler. and simply ""Obtaining permission to execute"" (resolved #7)  
Fixed issue #5   
   
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.5.zip  

# 1.4.9999  
Fixes issue #4.  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.4.9999.zip  

# 1.4  
Inside "Global Game Settings we have:   
Enable/Disable rear touchpad  
Enable/Disable front touchscreen   
Change the Texture Paging Size *default: 2048* (stick to power's of 2 or u might break shit)  
  
Other changes:   
Program will check for updates   
Program will remember what images you last used (HKLU/Software/GayMaker)   
This system software update improves system performance.    
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.4.zip  
  
# 1.3  
Shader's can now be used, however you have to provide a copy of "psp2cgc.exe" yourself. - #3 can now be closed.  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.3.zip  
  
# 1.2  
UPDATED TO GAMEMAKER STUDIO 1.4.9999 - THANKS CELESTEBLUE FOR SOURCING THE EXPORT MODULE!!!  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.2.zip  
  
# 1.1
Fixes Issue #1 and Issue #2  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker%201.1.zip  

# 1.0
FIRST RELEASE WEW  
Download: https://bitbucket.org/SilicaAndPina/gaymaker/downloads/GayMaker.zip    

# GayMaker  
Homebrew GM:S Export tool  
  
Run the program. and browse to a GameMaker Studio project file (.gmx).  
you can also change the images, Title. and TitleID and then your game will be    
"compiled" for PSVITA and saved as a VPK to whereever you choose to save it  

Please show me any games you make with it! (though, please note i wont be too interested unless a girl dies)    

# Errors
When the PSVita GameMaker Runner encounters an error. the error dialog is printed to stdout rather than opening a message box.  
if its a critical error. the app will simply exit afterwards.. i recommend using a plugin to capture stdout for any serious development.   
take a look at [ShipLog](https://github.com/CelesteBlue-dev/PSVita-RE-tools/tree/master/ShipLog2.0/release) or [psp2shell](https://github.com/Cpasjuste/psp2shell)  

# Shaders
When you compile a project that uses Shaders for the first time. you'll be prompted to browse to 'psp2cgc.exe'  
This file will then be placed into the GayMaker install folder and you wont have to do it again after that.  
Shaders will compile into the GXP format. which will then work on the console itself.  

For *reasons*, i will not provide a link to psp2cgc.exe  
  
# Touchscreen  
To use touchscreen features, you have to enable "Use Rear Touch" and "Use Front Touch" in *Global Game Settings*  
Then you can use the mouse controls as touch inputs.  
  
Once enabled the touchscreen is mapped as a Mouse Device,  
so you can just use [Device Input](https://docs.yoyogames.com/source/dadiospice/002_reference/mouse,%20keyboard%20and%20other%20controls/device%20input/index.html)  
  
Devices 0~4 are for the front touchscreen  
and Devices 5~8 are for the rear touchscreen  
*It acturally supports multiple touches at a time~*  
  
# Controller Mapping 
  
To Check PSVita Controls use the [GamePad](https://docs.yoyogames.com/source/dadiospice/002_reference/mouse,%20keyboard%20and%20other%20controls/gamepad%20input/index.html) commands    
Here is what each control maps to:  

gp_face1 = CROSS  
gp_face2 = CIRCLE             
gp_face3 = SQUARE  
gp_face4 = TRIANGLE  
  
gp_shoulderl = L  
gp_shoulderr = R  
gp_shoulderlb = UNUSED  
gp_shoulderrb = UNUSED  
  
gp_select = SELECT  
gp_start = START  
  
gp_stickl = UNUSED  
gp_stickr = UNUSED  
  
gp_padu = DPAD UP  
gp_padd = DPAD DOWN  
gp_padl = DPAD LEFT  
gp_padr = DPAD RIGHT  
  
gp_axislh = LEFT ANOLOUGE HORIZONTAL AXIES  
gp_axislv = LEFT ANOLOUGE VERTICAL AXIES  
  
gp_axisrh = RIGHT ANOLOUGE HORIZONTAL AXIES  
gp_axisrv = RIGHT ANOLOUGE VERTICAL AXIES  
  
# Homebrew Repo  
This repository has some GameMaker: Studio Homebrew games / ports.   
https://bitbucket.org/SilicaAndPina/gm-shb  
  
# Credits  
Thanks @nikita_krapivin for testing things, and for finding a capible game   
Thanks to @CelesteBlue for patching some things   
Thanks Radziu, Dots-tb, for uh existing?  
Thanks "Wolfgang" for [PUBLICLY UPLOADING A GMS4VITA COMPILE LOG TO PASTEBIN - MUCH APRICIATED](https://pastebin.com/Api4EeRP)  
Thanks To the devs of ~~"Siralin2"~~ DnSpy for indirectly making this possible ;)   
