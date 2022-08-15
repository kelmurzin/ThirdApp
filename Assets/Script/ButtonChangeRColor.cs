using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// Кнопка для изменения красного оттенка.
/// </summary>
public class ButtonChangeRColor : ButtonClick,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private bool isMinus;
    private bool isHold;

    public override void ButtonAction()
    {
            if (isMinus && color.r > 0)
                color.r--;
            if (!isMinus && color.r < 255)
                color.r++;

        changeColor.ChangeRGBColor(color);
    }

    public void OnPointerDown(PointerEventData eventData) => isHold = true;
   
    public void OnPointerUp(PointerEventData eventData) => isHold = false;
    
    private void Update()
    {
        if (isHold)
            ButtonAction();
    }
}
