using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textRef;
    [SerializeField]
    private float StartTimer = 60f;

    private void Awake()
    {
        _textRef.text = "60";
    }

    private void Update()
    {
        StartTimer -= Time.deltaTime;
        float seconds = Mathf.FloorToInt(StartTimer);
        _textRef.text = string.Format("{00}", seconds);

        if(StartTimer<20f)
        {
            _textRef.color = Color.red;
        }

        if(StartTimer<=0)
        {
            //Gameover Screen
        }
    }
}
