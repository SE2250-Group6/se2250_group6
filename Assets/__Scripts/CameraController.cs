using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   //object that the camera should follow
    //public Transform target;



    //TestingStuff
    public Transform target;
    //private GameObject character;
    //private int characterSelected;
    // Start is called before the first frame update
   /* void Start()
    {
        

        int characterSelected = PlayerPrefs.GetInt("characterSelected");
        Debug.Log("Character Selected is" + characterSelected);
        if (characterSelected == 0)
        {
       
            target = GameObject.Find("Purple Charcter").transform; 
            Debug.Log("PurpleCharacter");
        }
        else if (characterSelected == 1)
        {

            target = GameObject.Find("Red Charcter").transform;
            Debug.Log("RedCharacter");
        }

        
    } */
    
    // Update is called once per frame
    void Update()
     {
         transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z); 
     } 

    /*void Update()
    {
        transform.position = new Vector2 (characterObjectList[charac])
    }*/
}
