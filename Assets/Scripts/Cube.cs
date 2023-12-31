using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    public Cube(string name, Color color)
    {
        ShapeName = name;
        Color = color;
    }

    protected override void DisplayText() // POLYMORPHISM
    {
        var text = $"This is a Cube named {ShapeName}";
        InfoText.text = text;
    }
}
