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

    public TMP_Text InfoText
    {
        get { return m_InfoText; }
        protected set { m_InfoText = value; }
    }

    public Renderer Renderer
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

    protected virtual void SetColor()
    {
        Renderer.material.color = Color;
    }

    public virtual void SetColor(Color color)
    {
        Color = color;
        Renderer.material.color = color;
    }
}
