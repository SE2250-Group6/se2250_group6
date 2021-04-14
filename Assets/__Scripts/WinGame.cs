using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    public Text endText;

    // Start is called before the first frame update
    void Start()
    {
        endText.text = "";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log("key collided");
        if ((hitInfo.name == "Red Character") || (hitInfo.name == "Purple Character"))
        {
            
            endText.text = "Congrats You've Won The Game!";
            Invoke("mainMenu", 2); 
        }

    }

    void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
