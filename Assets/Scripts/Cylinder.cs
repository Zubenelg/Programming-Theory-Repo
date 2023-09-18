using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{
    public Cylinder(string name, Color color)
    {
        ShapeName = name;
        Color = color;
    }

    protected override void DisplayText() // POLYMORPHISM
    {
        var text = $"This is a Cylinder named {ShapeName}";
        InfoText.text = text ;
    }
}
