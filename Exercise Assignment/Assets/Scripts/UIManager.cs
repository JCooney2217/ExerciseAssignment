using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class UIManager : MonoBehaviour
{
    public float Score = 0f;

    private static UIManager _instance;
    
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                UIManager singleton = GameObject.FindObjectOfType<UIManager>();
                if (singleton == null)
                {
                    GameObject go = new GameObject();
                    _instance = go.AddComponent<UIManager>();
                }
            }
            return _instance;
        }
    }

    // private CubeScript _CubeScript;

    public TextMeshProUGUI ScoreText;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ScoreText.text = Score.ToString();
    }
}
