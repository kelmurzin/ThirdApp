using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Получаем цвет.
/// </summary>
public class GiveColor : MonoBehaviour
{
    [SerializeField] private ChangeColor changeColor;

    private Image image;
    private MeshRenderer cube;
    private bool isImage;
    Color32 color;
    
    public void GetObject(GameObject gameObj,bool isIm)
    {
        isImage = isIm;
        if (isImage)
        {
            image = gameObj.GetComponent<Image>();
            color = image.color;
            changeColor.ColorSet(color);
        }
        else
        {
            cube = gameObj.GetComponent<MeshRenderer>();
            color = cube.material.color;
            changeColor.ColorSet(color);
        }
    }

    private void ColorSet(Color32 color32)
    {
        if (isImage)
            image.color = color32;
        else
            cube.material.color = color32;
    }

    private void Start() => changeColor.onColorChange += ColorSet;
    
    private void OnDestroy() => changeColor.onColorChange -= ColorSet;
    
}
