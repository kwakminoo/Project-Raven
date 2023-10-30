using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [Tooltip("장소 이름")]
    public string name;

    [Tooltip("스토리 대사 내용")]
    public string[] contexts;
}

[System.Serializable]
public class DialogueEvent
{
    //스토리 이름
    public string name;

    public Vector2 line;
    public Dialogue[] dialogues;
}