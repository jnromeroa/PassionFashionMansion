using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
public class SplashScreen : MonoBehaviour
{
    [SerializeField] GameObject[] trollTexts = new GameObject[3];
    [SerializeField] UnityEvent OnClick;
    int clickCount = 0;
    public void Click()
    {
        if (clickCount == trollTexts.Length)
        {
            OnClick?.Invoke();
            return;
        }
        trollTexts[clickCount].SetActive(true);
        trollTexts[clickCount].GetComponent<RectTransform>().anchoredPosition = Mouse.current.position.ReadValue();
        clickCount++;
    }
}
