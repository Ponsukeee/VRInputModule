# VRInputModule
VRInputModule helps to input in VR applications that make with Unity.
## Description
You can send the input contents of the controller to objects with Collider contacting each controller or being hit by raycast.
## HTC VIVE
### Required Assets
SteamVR v2.0
### Usage
* Attach InputController and ViveInputDevice to the object to which SteamVR_Behaviour_Pose is attached.
* Attach a script that inherits IInputModule to the object you want to receive input and give Collider to the object.
## Sample
### Class inheriting IInputModule
    public class Sample : MonoBehaviour, IInputModule
    {
        public IInputModule HandleInput(InputType input, DeviceInfo deviceInfo)
        {
            if (input == InputType.Click)
            {
                //Process when pressed button assigned to Click
            }

            //Return null unless you want to pass another IInputModule
            return null;
        }

        public void OnSet()
        {
            //Process when the input can be received
        }

        public void OnUnset()
        {
            //Process when the input can not be received
        }
    }
