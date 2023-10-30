using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Text txt_Dialogue;


    public void ShowDialogue()
    {
        txt_Dialogue.text = "";
    }

}
