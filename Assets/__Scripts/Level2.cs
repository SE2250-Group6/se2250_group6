using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("collided");
        if ((hitInfo.name == "Red Character") || (hitInfo.name == "Purple Character"))
        {
            SceneManager.LoadScene("Level_2" );
        }

    }
}
