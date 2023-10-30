using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePaser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>();
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName);

        string[] data = csvData.text.Split(new char[]{'_'});

        for(int i = 1; i < data.Length;)
        {
            string[] row = data[i].Split(new char[]{','});

            Dialogue dialogue = new Dialogue();

            dialogue.name = row[0];

            List<string> contextsList = new List<string>();
            contextsList.Add(row[1]);

            Debug.Log(row[0]);
            Debug.Log(row[1]);

            if(++i < data.Length)
            {
                ;
            }

            dialogue.contexts = contextsList.ToArray();

            dialogueList.Add(dialogue);
        }
        
        return dialogueList.ToArray();
    }

}
