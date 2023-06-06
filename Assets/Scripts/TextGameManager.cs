using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI gametitleTextMeshPro, storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string gameTitle, storyText;
    public int hpValue, staminaValue;
    public GameObject Main_Menu, HP_Text, Stamina_Text, Level_1_Choices, Level_1_Story, Exitt;

    // Start is called before the first frame update
    void Start()
    {
        gameTitle = "Dreamlike";
        Main_Menu.SetActive(true);
        Level_1_Choices.SetActive(false);
        HP_Text.SetActive(false);
        Stamina_Text.SetActive(false);
        Exitt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gametitleTextMeshPro.text = gameTitle;
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = hpValue.ToString();
        staminaTextMeshPro.text = staminaValue.ToString();
    }

    public void StartGame()
    {
        gameTitle = " ";
        Main_Menu.SetActive(false);
        storyText = "You wake up in the middle of the night due to a noise you hear from somewhere in the house, Even though you're very tired, you're debating if you should check it out or not.";
        Level_1_Choices.SetActive(true);
        HP_Text.SetActive(true);
        Stamina_Text.SetActive(true);
        Exitt.SetActive(true);
    }

    

    //Level 1 stuff ecksdee
    public void GoDownstairs()
    {
        storyText = "You tried to go downstairs while being drunked from waking up. You then fell down the stairs and died form a concussion.";
        hpValue -= 10;
        staminaValue -= 1;

        Level_1_Choices.SetActive(false);
    }

    public void GoUpstairs()
    {
        storyText = "Upon waking up, you immediately went upstairs onto the attic. You were then jumpscared by an unknown figure you saw, making you trip and fall back down the stairs, dying from a concussion.";
        hpValue -= 10;
        staminaValue -= 1;

        Level_1_Choices.SetActive(false);
    }

    public void SleepAgain()
    {
        storyText = "You went back to sleep as you were too tired to stand up and start the day.";
        staminaValue += 9;

        Level_1_Choices.SetActive(false);
        Level_1_Story.SetActive(true);

    }

    public void NextPart1()
    {
        storyText = "You then wake up and notice that your room suddenly looks more vibrant than before, more colorful and dreamy, like you were in a dream.";
        Level_1_Story.SetActive(false) ;
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}