using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour, IInteractable
{
    [SerializeField] Dialogue dialogue;

    public void Interact()
    {
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {

        if (DialogueManager.instance.inProgress)
        {
            DialogueManager.instance.DisplayNextSentence();
        }
        else
        {
            DialogueManager.instance.StartDialogue(dialogue);
        }
    }
}
