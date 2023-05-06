using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MaterialColor
{
    Red,
    Blue
}

public class ColorSetter : MonoBehaviour
{
    [SerializeField]
    private MaterialColor m_Color;
    private Material m_Material;

    void Start()
    {
        m_Material = GetComponent<Renderer>().material;

        switch (m_Color)
        {
            case MaterialColor.Red:
                m_Material.EnableKeyword("RED");
                break;
            case MaterialColor.Blue:
                m_Material.EnableKeyword("BLUE");
                break;
        }
    }
}

