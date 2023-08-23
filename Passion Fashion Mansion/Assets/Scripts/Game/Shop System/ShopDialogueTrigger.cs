using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDialogueTrigger : DialogueTrigger
{
    [SerializeField] GameObject FocusedCamera;
    public override void Interact()
    {
        if (!DialogueManager.instance.inProgress)
        {
            TriggerDialogue(true);
            FocusedCamera.SetActive(true);
            Invoke(nameof(OpenShopUI), 1.5f);
            return;
        }

    }
    void OpenShopUI()
    {
        ShopUI.instance.Open(GetComponent<Shop>());
    }
}
