using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    private string m_ShapeName;
    [SerializeField]
    private Color m_Color;
    [SerializeField]
    private TMP_Text m_InfoText;

    private Renderer m_Renderer;

    public string ShapeName // ENCAPSULATION
    {
        get { return m_ShapeName; }
        protected set { m_ShapeName = value; }
    }

    public Color Color // ENCAPSULATION
    {
        get { return m_Color; }
        protected set { m_Color = value; }
    }

    public TMP_Text InfoText // ENCAPSULATION
    {
        get { return m_InfoText; }
        protected set { m_InfoText = value; }
    }

    public Renderer Renderer // ENCAPSULATION
    {
        get { return m_Renderer; }
        private set { m_Renderer = value; }
    }

    protected virtual void Awake()
    {
        Renderer = GetComponent<Renderer>();
        SetColor();
    }

    protected virtual void OnMouseDown()
    {
        DisplayText();
    }

    protected abstract void DisplayText();

    protected virtual void SetColor() // POLYMORPHISM // ABSTRACTION
    {
        Renderer.material.color = Color;
    }

    public virtual void SetColor(Color color) // POLYMORPHISM // ABSTRACTION
    {
        Color = color;
        Renderer.material.color = color;
    }

    public void SetName(string name) // ABSTRACTION
    {
        if(name.Length > 0)
        {
            ShapeName = name;
        }
        else
        {
            Debug.LogError("Name must have at least one character");
        }
    }
}
