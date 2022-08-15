using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Кнопка для изменения синего оттенка.
/// </summary>
public class ButtonChangeBColor : ButtonClick
{
    public override void ButtonAction()
    {
        color.b = (byte)Random.Range(0, 255);
        changeColor.ChangeRGBColor(color);
    }
}
