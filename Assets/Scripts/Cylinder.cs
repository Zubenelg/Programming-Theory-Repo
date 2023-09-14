using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public Cylinder(string name, Color color)
    {
        ShapeName = name;
        Color = color;
    }

    protected override void DisplayText()
    {
        Debug.Log($"This is a Cylinder named {ShapeName}");
    }
}
