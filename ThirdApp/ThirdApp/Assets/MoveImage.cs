using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class MoveImage : MonoBehaviour
{
    [SerializeField] private Image image;

    private void Start()
    {
        image.rectTransform.DOLocalMoveX((758), 2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
