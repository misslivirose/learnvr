# Troubleshooting Your Application
While hackathon mentors are awesome++, there are a few things that you can do to try debugging your applications and get a head start on fixing issues you may run into.

## First Checks
Before you track down a mentor for help, go through the following checklist to make sure that you're not hitting some of the most basic bugs:

1. Check the version of Visual Studio 2015 you're running and make sure that Update 3 is installed.
2. Make sure that you have an up to date HoloLens Technical Preview Unity installation. You can check that you have a HoloLens build by going to Programs & Features > Unity and making sure that the version you are using has -HTP at the end of the name. Example: Unity HoloLens 5.4.0f3-HTP
3. Confirm that you have the Windows 10 SDK installed. You can check this by opening up Visual Studio, clicking 'New Project', and seeing if there is an option for Windows Universal under Visual C# (you don't have to actually create the project, just see if the option is there)
4. Enable developer mode on your local machine
5. See if the problem reproduces when you try a different deployment option (e.g. if you can't deploy over USB, try Wi-Fi, and vice-versa)
    
## Emulator Errors
* Unable to install emulator:
    * Check that you are running a supported version of Windows by going to System in Control Panel and making sure that you have a Pro, Enterprise, or Educational version of Windows 10
    * Make sure that your PC meets the [minimum requirements](https://developer.microsoft.com/en-us/windows/holographic/install_the_tools) for the HoloLens emulator
    * Turn on Hyper-V by searching "Turn Windows Features on or off" and following the steps for Hyper-V
    * Boot into your laptop's BIOS (or ask a mentor for help!) to make sure that you have Hardware-assisted [virtualization, SLAT, and DEP](https://developer.microsoft.com/en-us/windows/holographic/install_the_tools) turned on

## Unity Errors
* "Error building Player: IOException: Win32 IO returned 112" - this is an error that the OS will throw in Unity if you attempt to build your app without enough available disk space. Check that you room - sometimes applications and files build up! 

* Cannot convert from packagename.class.Example to Example - you may find an error similar to this in your project if your plugins have the same class names. To check if this is the case in your project, search your asset for the Example class that is throwing an error, and see if more than one script result shows up. If so, you may need to refactor one of them, or, alternatively, you can use the full packagename.class.Example class in the lines throwing an error to differentiate.

* Platform not found - if you try to build your application and see an error about the platform not being found, check:
    * That you have [set up your build target correctly](https://developer.microsoft.com/en-us/windows/holographic/holograms_100)   
    * The correct version of Visual Studio is installed
    * You have included the Windows 10 SDK      
    
* Unable to drag and drop objects from the Assets folder to your Hierarchy or Scene: This is likely due to a permissions issue. Check that your project is saved somewhere you have access, such as the Documents folder.

* Unity Bad Image Format: This may happen if Unity 

## Visual Studio Errors
* Unable to deploy to the device: Check and see that you have the correct build targets set and that you have successfully paired your 

* DEP0001: -1988945906. This error may occur if you are trying to deploy over USB and the Windows Phone IP Over USB service has been disabled in Services. Confirm that it is running by searching "Services" with Cortana. 

* Cannot connect to the HoloLens: make sure that your HoloLens has enabled the developer settings and is on the same network as your computer

You can also try checking [this list](http://katvharris.azurewebsites.net/blog/hololens-emulator-errors/) for additional troubleshooting tips related to deployment and emulator errors.

Lastly, you can search the [HoloLens Development Forum](https://forums.hololens.com/) to see if your error is similar to one that someone else may have had.
