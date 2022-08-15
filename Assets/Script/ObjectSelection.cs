using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// Выбираем объект.
/// </summary>
public class ObjectSelection: MonoBehaviour,IPointerClickHandler
{
    [SerializeField] private GiveColor GiveColor;
    [SerializeField] private bool isImage;
   
    public void OnPointerClick(PointerEventData eventData) => GiveColor.GetObject(gameObject, isImage);
    
}
