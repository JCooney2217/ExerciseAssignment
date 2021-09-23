using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeScript : MonoBehaviour
{
    /// <summary>
    /// /////////////////////////////////////////////////////
    /// Copy paste all of this
    /// Change "SingletonPattern everywhere for the name of your class.
    /// YOU'RE DONE. You can now use SingletonPattern.Instance.WhateverYouLike(); from ANYWHERE
    /// </summary>
    /// 
    private Vector3 startScale;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        startScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        UIManager.Instance.Score++;
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material.DOColor(Color.red, 0f);
        transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f), 1f).OnComplete(AfterClick);
    }
 
    private void AfterClick()
    {
        DOTween.Kill(transform);
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material.DOColor(Color.gray, 0.2f);
        transform.localScale = startScale;
    }

}
