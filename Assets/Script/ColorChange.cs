using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ColorChange : MonoBehaviour
{
    public event Action<Color32> ColorChanged;

    [SerializeField] private Text _textR;
    [SerializeField] private Text _textG;
    [SerializeField] private Text _textB;

    [SerializeField] private Button _plus;
    [SerializeField] private Button _minus;
    [SerializeField] private Slider _slider;

    private byte _r, _g, _b;
           
    private bool _activePlus;
    private bool _activeMinus;
    private Color32 _color;

    public void ColorSet(Color32 color)
    {
        _color = color;
        ColorSet();
    }
 
    public void ChangeB() => _b = (byte)UnityEngine.Random.Range(0, 255);

    public void PlusR()
    {
        if (!_activePlus)
            _activePlus = true;
        else
            _activePlus = false;
    }

    public void MinusR()
    {
        if (!_activeMinus)
           _activeMinus = true;
        else
           _activeMinus = false;
    }

    private void ColorSet()
    {
        _slider.maxValue = 255;
        _r = (byte)_color.r;
        _g = (byte)_color.g;
        _b = (byte)_color.b;
        _slider.value = _g;
        _textR.text = "R:" + _r.ToString();
        _textG.text = "G:" + _g.ToString();
        _textB.text = "B:" + _b.ToString();
    }

    private void Update()
    {        
            _textR.text = "R:        " + _r.ToString();
            _textG.text = "G: " + _g.ToString();
            _textB.text = "B: " + _b.ToString();
            _color = new Color32(_r, _g, _b, 255);

            ColorChanged?.Invoke(_color);

            _g = (byte)_slider.value;

            if (_activePlus && _r < 255)
                _r++;
               
            if (_activeMinus && _r > 0)
                _r--;                   
    }
    
}
