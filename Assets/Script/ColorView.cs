using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Отображаем текстом цвет. 
/// </summary>
public class ColorView : MonoBehaviour
{
    [SerializeField] private Text textR;
    [SerializeField] private Text textG;
    [SerializeField] private Text textB;
    [SerializeField] private ChangeColor changeColor;
    
    private void Start() => changeColor.onColorChange += UpdateAllTextColor;
    
    private void OnDestroy() => changeColor.onColorChange -= UpdateAllTextColor;
    
    private void UpdateAllTextColor(Color32 color)
    {
        textR.text = color.r.ToString();
        textG.text = color.g.ToString();
        textB.text = color.b.ToString();
    }
    
}
