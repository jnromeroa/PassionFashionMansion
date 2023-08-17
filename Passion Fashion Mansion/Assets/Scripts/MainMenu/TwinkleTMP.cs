using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TwinkleTMP : MonoBehaviour
{
    TMP_Text text;
    float time = 0;
    [SerializeField] float speed =1f;
    Color color;
    void Start()
    {
        text = GetComponent<TMP_Text>();
        color = text.color;
    }


    void Update()
    {
        time += Time.deltaTime;
        color.a = 1+Mathf.Sin(time*speed);
        text.color = color;
    }
}
