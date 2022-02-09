using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceObject : MonoBehaviour
{
    [SerializeField] private ColorChange _сolorChange;

    private GameObject _objectSet;
    private Image _image;

    private Color32 _color;
    
    public void ColorGet(Color32 color)
    {
        _color = color;

        if (_objectSet != null)
            _objectSet.GetComponent<MeshRenderer>().material.color = _color;
        
        if (_image != null)
            _image.GetComponent<Image>().color = _color;        
    }

    public void SetObject(GameObject obj)
    {
        _image = null;
        _objectSet = obj;
        ChangeMat();        
    }

    public void SetImage(Image im)
    {
        _objectSet = null;
        _image = im;
        ChangeColor();        
    }

    private void OnEnable()
    {
        _сolorChange.ColorChanged += ColorGet;
    }

    private void ChangeMat()
    {
        _color = _objectSet.GetComponent<MeshRenderer>().material.color;
        _сolorChange.ColorSet(_color);
    }

    private void ChangeColor()
    {
        _color = _image.GetComponent<Image>().color;
        _сolorChange.ColorSet(_color);
    }

    private void OnDisable()
    {
        _сolorChange.ColorChanged -= ColorGet;
    }
    
}
