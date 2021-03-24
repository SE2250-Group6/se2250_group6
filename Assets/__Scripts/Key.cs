using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public Text winText;

    // Update is called once per frame
    void Start()
    {
        winText.text = "";
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log("key collided");
        if ((hitInfo.name == "Red Character") || (hitInfo.name == "Purple Character"))
        {
            //Debug.Log("key should be gone");
            Destroy(gameObject);
            winText.text = "You've Won!";
        }
        
    }

}
