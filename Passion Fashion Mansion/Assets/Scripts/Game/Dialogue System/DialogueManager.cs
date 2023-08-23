using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    [SerializeField] GameObject dialogueBox;
    [SerializeField] TMP_Text nameTxt;
    [SerializeField] TMP_Text dialogueTxt;
    private Queue<string> sentences = new Queue<string>();
    [HideInInspector] public bool inProgress;
    bool endManually;
    private void Awake()
    {
        instance = this;
    }
    public void StartDialogue(Dialogue dialogue, bool endManually)
    {
        dialogueBox.SetActive(true);
        this.endManually = endManually;
        sentences.Clear();
        inProgress = true;
        nameTxt.text = dialogue.name;
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0 )
        {
            if (!endManually)
            {
                EndDialogue();
                return;
            }
            else return;

        }
        dialogueTxt.text = sentences.Dequeue();
        
    }

    public void EndDialogue()
    {
        sentences.Clear();
        dialogueBox.SetActive(false);
        inProgress = false;
    }
}
