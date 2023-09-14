using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void DisplayText()
    {
        Debug.Log($"This is a {ShapeName}");
    }
}
