using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectedToggle: MonoBehaviour
{
    private GameObject[] characterObjectList;
    public CameraController cameraController;

    // Start is called before the first frame update
    void Start()
    {
        characterObjectList = new GameObject[transform.childCount];

        //Fill the array with character objects
        for (int i = 0; i < transform.childCount; i++)
        {
            characterObjectList[i] = transform.GetChild(i).gameObject;
        }
        //Toggle of their renderer
        foreach (GameObject go in characterObjectList)
        {
            go.SetActive(false);
        }

        int characterSelected = PlayerPrefs.GetInt("characterSelected");

        characterObjectList[characterSelected].SetActive(true);

        cameraController.target = characterObjectList[characterSelected].transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
