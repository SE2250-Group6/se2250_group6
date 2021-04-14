using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    //used singleton to make accessing the script easier
    public static UIManager singleton;

    [SerializeField]
    TextMeshProUGUI killCounter_TMP;

    [HideInInspector]
    public int killCount; //used to attach the TMP object in the inspector

    void Awake()
    {
        //check if UI hasn't been instanced in new scene
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //turn int killCount variable to string so the new score appears
    public void UpdateKillCounterUI()
    {
        killCounter_TMP.text = killCount.ToString();
    }
}
