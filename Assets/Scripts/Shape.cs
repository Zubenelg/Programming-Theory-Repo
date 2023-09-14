using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    private string m_ShapeName;
    [SerializeField]
    private Color m_Color;

    private Renderer m_Renderer;

    public string ShapeName
    {
        get { return m_ShapeName; }
        set { m_ShapeName = value; }
    }

    public Color Color
    {
        get { return m_Color; }
        protected set { m_Color = value; }
    }

    public Renderer Renderer
    {
        get { return m_Renderer; }
        private set { m_Renderer = value; }
    }

    private void Awake()
    {
        Renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        SetColor();
    }

    protected virtual void OnMouseDown()
    {
        DisplayText();
    }

    protected abstract void DisplayText();

    protected virtual void SetColor()
    {
        Renderer.material.color = Color;
    }

    public virtual void SetColor(Color color)
    {
        Renderer.material.color = color;
    }
}
