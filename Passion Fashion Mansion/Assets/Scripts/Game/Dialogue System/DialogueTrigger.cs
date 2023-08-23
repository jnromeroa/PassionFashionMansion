using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DialogueTrigger : MonoBehaviour, IInteractable
{
    [SerializeField] protected Dialogue dialogue;
    public virtual void Interact()
    {
        TriggerDialogue(false);
    }
    public virtual void TriggerDialogue(bool endManually)
    {

        if (DialogueManager.instance.inProgress)
        {
            DialogueManager.instance.DisplayNextSentence();
        }
        else
        {
            DialogueManager.instance.StartDialogue(dialogue, endManually);
        }
    }
}
