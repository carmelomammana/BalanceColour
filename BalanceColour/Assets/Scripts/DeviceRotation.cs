using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DeviceRotation
{
    private static bool gyroInitialized = false;

    public static bool HasGyroscope
    {
        get
        {
            return SystemInfo.supportsGyroscope;
        }
    }

    public static Quaternion Get()
    {
        if (!gyroInitialized)
            InitGyro();

        return HasGyroscope ? ReadyGyroscopeRotation() : Quaternion.identity;
    }

    private static void InitGyro()
    {
        if (HasGyroscope)
        {
            Input.gyro.enabled = true;
            Input.gyro.updateInterval = 0.0167f;
        }
        gyroInitialized = true;
    }

    private static Quaternion ReadyGyroscopeRotation()
    {
        Quaternion q = new Quaternion(1, 1, 0, 0) * Input.gyro.attitude;//* new Quaternion(0, 0, 0, 0);
        return new Quaternion(q.x, q.z, -q.y, q.w);
    }
}
