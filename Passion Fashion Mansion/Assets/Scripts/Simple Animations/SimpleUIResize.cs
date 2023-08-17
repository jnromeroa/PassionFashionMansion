using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleUIResize : MonoBehaviour
{
    [SerializeField] Vector2 rectTargetSize;
    Vector2 rectOriginalSize;
    [SerializeField] float durationSeconds;
    RectTransform rt;
    float time = 0;
    bool isResizing = false;
    private void Start()
    {
        rt = GetComponent<RectTransform>();
        rectOriginalSize = rt.sizeDelta;
    }
    private void Update()
    {
        if (!isResizing) return;
        if (time >= durationSeconds) return;
        time += Time.deltaTime;
        Debug.Log(time);
        rt.sizeDelta = Vector2.Lerp(rectOriginalSize, rectTargetSize, time / durationSeconds);

    }
    [ContextMenu("Trigger")]
    public void Trigger()
    {
        isResizing = true;
    }
}
