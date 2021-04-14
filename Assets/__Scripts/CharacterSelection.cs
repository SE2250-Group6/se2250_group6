using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    
    private int selectedCharacterIndex;

    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();

    [Header("UI References")]
    [SerializeField] private Image characterSplash;

    private void Start()
    {
        UpdateCharacterSelectionUI();


    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
            selectedCharacterIndex = characterList.Count - 1;

        UpdateCharacterSelectionUI();
    }

    public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
            selectedCharacterIndex = 0;

        UpdateCharacterSelectionUI();
    }

    public void Confirm()
    {
        
        PlayerPrefs.SetInt("characterSelected", selectedCharacterIndex);
        PlayerPrefs.Save();
    }

    private void UpdateCharacterSelectionUI()
    {
        //Change Splash
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
    }

    [System.Serializable]   
    public class CharacterSelectObject
    {
        public Sprite splash;
    }
}

