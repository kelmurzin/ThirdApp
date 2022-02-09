using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoveImage : MonoBehaviour
{
    [SerializeField] private Image _image;

    private void Start() => _image.rectTransform.DOLocalMoveX((758), 2f)
        .SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
}
