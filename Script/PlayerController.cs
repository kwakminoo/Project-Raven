using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public string playerName;
    public Text Name;
    public int nowHP;
    public int HP; 
    public int Attack;

    // Start is called before the first frame update
    void Start()
    {
       Name.text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
