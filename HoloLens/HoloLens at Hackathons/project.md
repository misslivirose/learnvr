# Planning your Project
It's a hackathon - just about anything goes! That said, you usually have a certain amount of time to work on a project with a hackathon, so you want to make sure that you take some time to plan, scope, and build a project that works for your team in the time frame provided. Here are some things to get you started.

## Scoping your Project
Hackathons have a variable amount of time - you may have just 24 hours or fewer, or perhaps you're at a week-long hack event that gives you more flexibility with how large of a project you can build. Here are a few tips for scoping your project:

* Consider how much you'll need to ramp up. If this is your first experience ever using Unity or the Universal Windows Platform, build in a little extra time to familiarize yourself with the tools and the build process.

* Balance your team's expertise and plan accordingly. Especially during overnight hackathons, it can be easy to assume that the number of hours available to hack equals the number of hours you will spend working. Factor in time to rest (it's important!) and debug time to your plan.

* Spend some time up front deciding what you want to build and making sure everyone on your team is on board with it. Your team will likely need to take turns using the headset, so make sure that all members get a chance to try it out, talk out your project requirements, and fully understand what the hardware is capable of and what you're going to build. 

* Take advantage of the unique capabilities of the HoloLens right away in your project. Plan your experience in layers so that you have several milestones to reach. Include some of the HoloLens-specific capabilities in your early milestones so that even if you don't finish your entire plan, you'll have something to demo that uses the unique functionality of the device.

## Understanding the Device
While you're thinking about what you'd like to build for HoloLens, consider the characteristics of the device and how you can build for it. 

* The core building blocks of input for HoloLens are Gaze, Gesture, and Voice. Gaze, where a user is looking, is used to direct attention to a specific hologram within your scene, at which point you use the air-tap Gesture to confirm an action on that item. Voice commands can be used to perform additional tasks, contextually or globally, within your app.

* Play around with a few HoloLens applications from the Windows Store to get a sense of how different design options work

* Consider how immersive, 3D computing adds to your idea. What scenarios do mixed reality devices enable, and how can you build off of those? What features of the HoloLens will make these stand out?

## Adding Functionality
Think about additional services that you may want to use in your application. Take a look at some of the following scenarios that you may want to use in your HoloLens:

### Accessing the Camera
You may want to create an application that builds off of the images that the HoloLens sees. To do this, you will want to use the [Locatable Camera](https://developer.microsoft.com/en-us/windows/holographic/locatable_camera) object. This will allow you to access the camera on the HoloLens.

### Facial Detection
You can use Microsoft's [Cognitive Services](https://www.microsoft.com/cognitive-services) to work with facial detection and emotion APIs.

### Natural Language Processing
The [LUIS](http://luis.ai) platform allows you to train a system to understand and extract sentiments from natural human language and spoken phrases. LUIS is currently in beta and free to use.

### Using JSON
There are a number of different options for handling JSON file types or responses in Unity. One option is to use [Json.NET](https://github.com/SaladLab/Json.Net.Unity3D) for Unity3D. HoloLens requires the [UWP Workaround](https://github.com/SaladLab/Json.Net.Unity3D/blob/1bbe0d87a9515481c1fc4f7c62ac806320081eee/docs/UwpWorkaround.md) to work, so make sure that you're using the correct versions.

 