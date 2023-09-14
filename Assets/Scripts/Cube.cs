using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public Cube(string name, Color color)
    {
        ShapeName = name;
        Color = color;
    }

    protected override void DisplayText()
    {
        Debug.Log($"This is a Cube named {ShapeName}");
    }
}
