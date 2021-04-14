using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public Text winText;
    [SerializeField]
    private GameObject oldDoor, newDoor;
    public float doorX, doorY;

    Collider2D doorCollide;

    // Update is called once per frame
    void Start()
    {
        winText.text = "";
        
        doorCollide = newDoor.GetComponent<Collider2D>();
        doorCollide.enabled = false; 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log("key collided");
        if ((hitInfo.name == "Red Character") || (hitInfo.name == "Purple Character"))
        {   

            //Debug.Log("key should be gone");
            this.GetComponent<Renderer>().enabled = false;

            //when the player collects the key, add 10 points to the score
            UIManager.singleton.killCount =+ 10;
            UIManager.singleton.UpdateKillCounterUI();

            winText.text = "You've Unlocked the Door!";
            Invoke("openDoor", 2);
        }
        
    }

    public void openDoor()
    {
        Debug.Log("OpenDoor method");
        winText.text = " ";
        newDoor.transform.position = oldDoor.transform.position; 
        Destroy(oldDoor); 
        Instantiate(newDoor);
        doorCollide.enabled = true; 
    }

    public void setText(string newText)
    {
        winText.text = newText; 
    }

}
