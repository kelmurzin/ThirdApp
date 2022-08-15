using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// Изменяем цвет.
/// </summary>
public class ChangeColor : MonoBehaviour
{
    public event Action<Color32> onColorChange;

    Color32 color32;
    
    public void ColorSet(Color32 color)
    {
        color32 = color;
        onColorChange(color32);
    }

    public void ChangeRGBColor(Color32 rgbColor) => onColorChange(rgbColor);
    
}
