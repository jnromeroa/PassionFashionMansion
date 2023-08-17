using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleUITranslation : MonoBehaviour
{
    [SerializeField] Vector2 rectTargetPosition;
    Vector2 rectOriginalPosition;
    [SerializeField] float durationSeconds;
    RectTransform rt;
    float time = 0;
    bool isTranslating = false;
    private void Start()
    {
        rt = GetComponent<RectTransform>();
        rectOriginalPosition = rt.anchoredPosition;
    }
    private void Update()
    {
        if (!isTranslating) return;
        if (time >= durationSeconds) return;
        time += Time.deltaTime;
        Debug.Log(time);
        rt.anchoredPosition = Vector2.Lerp(rectOriginalPosition, rectTargetPosition, time / durationSeconds);
        
    }
    [ContextMenu("Trigger")]
    public void Trigger()
    {
        isTranslating = true;
    }

}
