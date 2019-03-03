﻿using UnityEngine;
using Valve.VR.InteractionSystem;
using VRUtils.InputModuleVRUtils.Components;

namespace VRUtils.InputModule
{
public class InputDeviceAssignor : MonoBehaviour
{
    public enum DeviceType
    {
        Vive,
        KeyBoard,
    }

    public IInputDevice AssignInputDevice(DeviceType deviceType)
    {
        Destroy(this);
        switch (deviceType)
        {
            case DeviceType.Vive:
                return new ViveInputDeviceSupport(GetComponent<Hand>());
            case DeviceType.KeyBoard:
                return new KeyboardInput();
            default:
                return null;
        }
    }
}
}