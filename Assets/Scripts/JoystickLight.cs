﻿/*
 * Mixer Unity SDK
 *
 * Copyright (c) Microsoft Corporation
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */
using Microsoft.Mixer;
using UnityEngine;
using UnityEngine.UI;

public class JoystickLight : MonoBehaviour
{
    public float speed;

    void Start()
    {
        // Call GoInteractive to connect to the Mixer service so you can start
        // recieving input.
        MixerInteractive.GoInteractive();
    }

    // Update is called once per frame
    void Update()
    {
        // Respond to joystick input from the viewer by calling GetJoystickX and GetJoystickY
        // and moving the player.
        if (MixerInteractive.GetJoystickX("joystick1") < 0)
        {
            print("ah");
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        else if (MixerInteractive.GetJoystickX("joystick1") > 0)
        {
            print("wah");
            transform.position += new Vector3(speed, 0, 0);
        }
        if (MixerInteractive.GetJoystickY("joystick1") < 0)
        {
            print("zah");
            transform.position += new Vector3(0, -1 * speed, 0);
        }
        else if (MixerInteractive.GetJoystickY("joystick1") > 0)
        {
            print("hah");
            transform.position += new Vector3(0, speed, 0);
        }
    }
}

