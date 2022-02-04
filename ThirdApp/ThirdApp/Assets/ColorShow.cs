using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorShow : MonoBehaviour
{   
    [SerializeField] private Text textR;
    [SerializeField] private Text textG;
    [SerializeField] private Text textB;

    [SerializeField] private Button plus;
    [SerializeField] private Button minus;
    [SerializeField] private Slider _slider;

    private byte R;
    private byte G;
    private byte B;
      
    private GameObject objectSet;
    private Image image;
    private bool ActivePlus;
    private bool ActiveMinus;
    private Color32 _color;

    public void SetObject(GameObject obj)
    {
        objectSet = obj;           
        ChangeMat();
        image = null;
    }
    public void SetImage(Image im)
    {
        image = im;
        ChangeColor();
        objectSet = null;
    }

    public void ChangeB()
    {
        B = (byte)Random.Range(0, 255);

    }
    public void PlusR()
    {
        if (!ActivePlus)
        {
            ActivePlus = true;
        }
        else
            ActivePlus = false;

    }
    public void MinusR()
    {
        if (!ActiveMinus)
        {
            ActiveMinus = true;
        }
        else
            ActiveMinus = false;

    }



    private void ChangeMat()
    {
        _color = objectSet.GetComponent<MeshRenderer>().material.color;
        ColorSet();
    }
    private void ChangeColor()
    {
        _color = image.GetComponent<Image>().color;
        ColorSet();
    }

    private void ColorSet()
    {
        _slider.maxValue = 255;
        R = (byte)_color.r;
        G = (byte)_color.g;
        B = (byte)_color.b;
        _slider.value = G;
        textR.text = "R:" + R.ToString();
        textG.text = "G:" + G.ToString();
        textB.text = "B:" + B.ToString();
    }
    private void Update()
    {
        if (objectSet != null)
        {
            objectSet.GetComponent<MeshRenderer>().material.color = _color;
        }
        if(image !=null)
        {
            image.GetComponent<Image>().color = _color;
        }

            textR.text = "R:        " + R.ToString();
            textG.text = "G: " + G.ToString();
            textB.text = "B: " + B.ToString();
            _color = new Color32(R, G, B, 255);
            

            G = (byte)_slider.value;

            if (ActivePlus)
            {
                if (R < 255)
                {
                    R++;
                }
            }
            if (ActiveMinus)
            {
                if (R > 0)
                {
                    R--;
                }
            }
        
    }
    
}
