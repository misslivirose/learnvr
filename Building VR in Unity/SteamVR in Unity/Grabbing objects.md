# Grabbing objects

Creating interactions with your scene can be more complicated than it first appears. You need to parse the controller input, find the appropriate object, and attach it accordingly.

## Vive Grip

The easiest way to handle this boilerplate is with [Vive Grip](https://www.assetstore.unity3d.com/en/#!/content/62324). It provides a simple abstract for physics-based interactions as well as useful features like object highlighting and controller vibrations. This might appeal to you if you want to spend your time on the cool stuff unique to your game or if you're looking to understand how all the underlying systems work by example.

### Tutorials

[Basic usage](https://www.youtube.com/watch?v=NyKWBeC_pSI) - Setting up object grabbing and highlighting with some drag-and-drop scripts

[Interaction scripting](https://www.youtube.com/watch?v=kKnO8BSdpZQ) - Linking your code logic to object interactions

[Examples](https://github.com/JScott/ViveGrip/tree/master/Assets/ViveGrip/Examples) - Explanations of how to make the objects found in the demo scene

### Downloads

[Asset Store link](https://www.assetstore.unity3d.com/en/#!/content/62324) | [GitHub link](https://github.com/JScott/ViveGrip)

## SteamVR controller input

SteamVR handles its input through [Controller scripts](https://github.com/ValveSoftware/openvr/blob/master/unity_package/Assets/SteamVR/Scripts/SteamVR_Controller.cs). An [example usage script](https://github.com/ValveSoftware/openvr/blob/master/unity_package/Assets/SteamVR/Extras/SteamVR_TrackedController.cs) is provided to showcase how you might utilize it but it assumes you're very comfortable with complex code.

## Attaching objects

### Parenting

The simplest way to attach an object to the controller when you grab it is to use parenting. If you set the controller as the parent of the object then it will track all the movement that the controller does.

However, you'll be breaking the object hierarchy which runs certain risks. If you rely on parenting elsewhere or assume it for certain scripts then it may have unintended consequences. For example, if I parent a door knob to a door and use this method to grab it then I may end up ripping the knob right off the door as I'm relying on the hierarchy to keep it in place.

The grip will also be unbreakable which will cause light objects to easily plow through heavier ones. It's not very friendly to physics.

### FixedJoint

It's a little more work but often better to use a FixedJoint for your connection, which [SteamVR does in one of its example scenes](https://github.com/ValveSoftware/openvr/blob/master/unity_package/Assets/SteamVR/Extras/SteamVR_TestThrow.cs). It involves more code and understanding of Unity joint objects but it will maintain that connection without breaking the hierarchy.

This comes with certain limitations though. The object always stays relative to where your controller was when you grabbed it which may not be a natural feeling. It also can't enforce a certain rotation which might be important for items like keys or pictures. You might have experienced this in some VR titles as you clumsily rotate a picture around because it won't orient itself to face you.

You can also configure your grip to break under physics pressure by setting a threshold at which the joint gets destroyed.

### ConfigurableJoint

You can take this a step further with a ConfigurableJoint. It allows all sorts of positions, orientations, velocities, and restrictions. This means that it's also the most complicated. 3DBuzz has a [decent tutorial](https://www.3dbuzz.com/training/view/unity-fundamentals/physics/13-configurable-joint) about them and [Vive Grip's joint factory](https://github.com/JScott/ViveGrip/blob/master/Assets/ViveGrip/Scripts/Internal/ViveGrip_JointFactory.cs) is a good example of creating them from a script.

By utilizing the spring features, you can have objects try to move to your grip but still interact with heavier objects along the way. You can also set a breaking threshold like in a FixedJoint.
