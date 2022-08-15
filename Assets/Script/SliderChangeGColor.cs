using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Слайдер для изменения зеленого оттенка.
/// </summary>
[RequireComponent(typeof(Slider))]
public class SliderChangeGColor : MonoBehaviour
{
    [SerializeField] private ChangeColor changeColor;
    [SerializeField] private int maxValue;
    Slider slider;
    Color32 color;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { SliderAction(); });
        changeColor.onColorChange += SliderValue;
        slider.maxValue = maxValue;
    }

    private void OnDestroy() => changeColor.onColorChange -= SliderValue;
    
    private void SliderValue(Color32 color32) 
    {
        color = color32;
        slider.value = color.g ;
    }

    private void SliderAction()
    {
        color.g = (byte)slider.value;
        changeColor.ChangeRGBColor(color);
    }
}
