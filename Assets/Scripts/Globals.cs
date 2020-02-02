﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This is a class to store global variables 
// such as background file path, start point, and endpoint
// Found on https://forum.unity.com/threads/c-global-variables-available-to-all-scenes.544901/
// Although this is NOT considered good Object-Oriented programming
public static class Globals
{
    // Set image for background
    public static string backgroundFile = "/Materials/PunchbowlFallsU.png";

    // Set start point
    public static int startX = 3;
    public static int startZ = 4;

    // Set end point
    public static int endX = -3;
    public static int endZ = 0;

    // Set ball speed
    public static int ballSpeed = 10;

    // Declare timeText variable
    public static string timeText;
}
