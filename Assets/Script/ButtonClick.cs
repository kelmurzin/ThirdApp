using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Абстрактный класс кнопки, для изменения цвета.
/// </summary>
[RequireComponent(typeof(Button))]
public abstract class ButtonClick : MonoBehaviour
{
    [SerializeField] protected ChangeColor changeColor;
    protected Color32 color;

    private Button button;

    public abstract void ButtonAction();

    private void Start()
    {
        changeColor.onColorChange += GetColor;
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonAction);
    }

    private void GetColor(Color32 color32) => color = color32;

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ButtonAction);
        changeColor.onColorChange -= GetColor;

    }
}
