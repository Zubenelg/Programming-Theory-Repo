using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void ChangeColor()
    {
        var shapes = FindObjectsOfType<Shape>();

        foreach (var shape in shapes)
        {
            shape.SetColor(RandomColor());
        }
    }

    private Color RandomColor()
    {
        return new Color(RandomValue(), RandomValue(), RandomValue());
    }

    private float RandomValue()
    {
        return Random.Range(0f, 1f);
    }
}
