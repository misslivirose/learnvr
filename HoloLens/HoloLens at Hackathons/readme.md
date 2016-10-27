# HoloHackathon Kit
So you're attending a hackathon and you want to build for HoloLens? Awesome! We've got you covered with this step by step guide for working with Microsoft HoloLens at a hackathon.
 
![](https://ncmedia.azureedge.net/ncmedia/2016/07/MSHoloLens_Hero1_RGB.jpg)
 
## Before the Hackathon: Set Up Your Development Environment
Event wifi can be spotty, so you'll be best off if you download all of the necessary tools ahead of time. The full toolset will run best on Windows 10. 

You will need:
* Visual Studio 2015 with Update 3
* The Windows 10 SDK
* Unity HoloLens Technical Preview

Optionally, you will need:
* The HoloLens Emulator to test your applications on (Requires Win 10)

You should go to the [HoloLens Developer Site](https://developer.microsoft.com/en-us/windows/holographic/install_the_tools) to get the most up-to-date versions of each of the above tools. Using outdated versions of the tools may result in unexpected issues whem you build or deploy your apps.

If you do not have a Windows PC or laptop to develop on, you may have luck with one of the following options:

* Installing a Windows Partition on your machine through a tool like Bootcamp. 
* Setting up a [Windows 10 Virtual Machine](https://developer.microsoft.com/en-us/windows/downloads/virtual-machines)

## Get Familiar with HoloLens & Holograms
If you have a chance to walk through a few sample projects for HoloLens, you will be well-prepared for building your first Holographic application. Understanding how Gaze, Gesture, and Voice - the three main principles of HoloLens input - work will help you design your apps. 

[Check out some awesome things people are building](https://www.youtube.com/playlist?list=PLZCHH_4VqpRjjNTKMyrV-hu3iyUvDgou8)

[See things from a developer perspective](https://www.youtube.com/playlist?list=PLZCHH_4VqpRhwzNjMBHJOcfdMhYZzC0K2)

You should also bookmark the [HoloLens Developer main site](https://www.microsoft.com/microsoft-hololens/en-us/developers) and the [Holographic Academy](https://developer.microsoft.com/en-us/windows/holographic/academy) site, both of which will contain useful information about getting your own holographic applications up and running. 

## At the Hackathon: Getting Your Project Started
When it's time to program your application, the best way to get started with your app will probably be a clean Unity project. You'll also likely want to grab the HoloTookKit-Unity package from GitHub to use in your project. 

### Create a new Project
1. Double check that you have the [latest HoloLens Technical Preview from Unity](https://unity3d.com/partners/microsoft/hololens#download).

2. Download the [HoloToolKit-Unity](https://github.com/Microsoft/HoloToolkit-Unity/) project as a zip folder from GitHub. 

3. Open up the  HoloToolKit-Unity-master project in the Unity HoloLens Technical Preview. You should see two folders under your assets: HoloToolkit and HoloToolkit-Examples.

4. Select the HoloToolkit folder and right click to find 'Export Package'

5. Save your exported package somewhere you'll remember it and name it 'HoloToolkit'

6. In Unity, go to File > New Project to create your hackathon project folder. Save this somewhere you have access to, such as your Desktop or Documents folders.

7. In your Assets folder, right-click and Import Custom Package

8. Find your Holotoolkit.unityplugin file that you just imported and select it to import it into your new project. 

Next step: build some holograms! 

## Deploying to a HoloLens Device
When you have your project working in the emulator and you're ready to test on a device, you will need to do the following steps to connect and deploy to each device you are testing with:

1. Make sure that your computer and your HoloLens are both on the same WiFi network.

2. In Visual Studio, set your deployment target to 'Release', the architecture to 'x86', and the deployment player to 'Remote Machine'

3. On the HoloLens, make sure that the developer settings are enabled to allow project applications to run (Settings > Developer)

4. In the Settings > Network tab on the HoloLens, air tap on "Advanced Settings" and note your device IP Address

5. Launch your application in Visual Studio. The first time you set up a device, you will be prompted for the IP Address. Enter the HoloLens IP Address.

6. Once your device is connected, you will be promped in Visual Studio for a PIN. You can find this back in Settings > Developer > Pair. Once you enter the code and the device pairs to the computer, your application will begin deployment. 

## Uploading to GitHub
Unity projects with 3D assets can be really large, so you should set up your source control on your project for the following:
1. Include a [Unity .gitignore](https://github.com/github/gitignore/blob/master/Unity.gitignore) to your git configuration

2. Set up [Git Large File Storage](https://git-lfs.github.com/) to track your .scene files and models that are larger than 50.0MB

## Taking Care of your Device + Tips & Tricks
* When holding the HoloLens, take care to hold it by the arms of the device, not the band or the visor. You can clean off the front of the device with a dry screen cleaning cloth.

* Keep the device charging while not in use so that you don't have to worry about a low battery during testing

* Rest the device flat (upside-down from how you'd wear it on your head) when it isn't in use. Ideally, it should rest in the case, too.

* The [HoloLens App](https://www.microsoft.com/store/apps/9nblggh4qwnx) will allow you manage your device from your computer. You'll also be able to turn on remote capture to see the holograms as someone uses your app.


   