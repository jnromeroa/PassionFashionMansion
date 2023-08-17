using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SizePulseTMP : MonoBehaviour
{
    TMP_Text text;
    float time = 0;
    [SerializeField] float speed = 1f;
    [SerializeField] float intensity = 1f;
    float originalFontSize;
    float fontSize;
    void Start()
    {
        text = GetComponent<TMP_Text>();
        fontSize = text.fontSize;
        originalFontSize = fontSize;
    }


    void Update()
    {
        time += Time.deltaTime;
        fontSize =  originalFontSize+ intensity * Mathf.Sin(time * speed);
        text.fontSize = fontSize;
    }
}
