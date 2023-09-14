using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public Sphere(string name, Color color)
    {
        ShapeName = name;
        Color = color;
    }

    protected override void DisplayText()
    {
        Debug.Log($"This is a Sphere named {ShapeName}");
    }
}
