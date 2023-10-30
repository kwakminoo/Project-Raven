using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SceneChangeBt()
    {
        switch(this.gameObject.name)
        {
            case "New Game":
                LodingController.LoadScene("Play");
                break;
            
            /*
            csae "Continue":
                LodingController.LoadScene("Load Game");
                break;

            case "Setting":
                LodingController.LoadScene("Title Setting");
                break;
            */
        }
    }
}
