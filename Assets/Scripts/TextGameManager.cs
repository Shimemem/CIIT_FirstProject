using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI gametitleTextMeshPro, storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string gameTitle, storyText;
    public int hpValue, staminaValue;
    public GameObject Main_Menu, HP_Text, Stamina_Text, Level_1_Choices, Level_1_Story, Level_2_Choices, Level_2_Story, Level_3_Choices, Exitt;

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
    public void GoDown()
    {
        storyText = "You went downstairs towards the kitchen, grabbing something to eat and drink, you sit on the kitchen as you eat. After you were done with your snakc, you felt sleeping from being full as you pass out on the dining table.";
        staminaValue += 9;

        Level_1_Choices.SetActive(false);
        Level_1_Story.SetActive(true);
    }

    public void GetOnPC()
    {
        storyText = "You still feel tired but can't go to sleep, so you went to your PC to play games through the night.";
        hpValue -= 10;
        staminaValue -= 1;

        Level_1_Choices.SetActive(false);
    }

    public void AMimir()
    {
        storyText = "You were too lazy to go up and just decided to fall asleep again even while feeling hungry.";
        hpValue -= 5;
        staminaValue += 9;

        Level_1_Choices.SetActive(false);
        Level_1_Story.SetActive(true);

    }

    public void NextPart1()
    {
        storyText = "You wake up to the feeling of really soft feeling under you, squinting your eyes from how bright it became. Upon scratching your eyes and the vision becomes clearer, you notice that what it looks like you're above the clouds.";
        Level_1_Story.SetActive(false);
        Level_2_Choices.SetActive(true);
    }

    public void Panik()
    {
        storyText = "You panic from the utter shock of being what it seems another world. You wake up from the dream";
        Level_2_Choices.SetActive(false);

        hpValue = 0;
        staminaValue = 0;
    }

    public void Amazables()
    {
        storyText = "You look around in awe at what you're seeing, being in a dreamlike setting high above the clouds. You see things you recall and have seen from your past dreams and scenarios you imagined on your slumber";
        Level_2_Choices.SetActive(false);
        Level_2_Story.SetActive(true);
    }

    public void Lv2Kwento()
    {
        storyText = "You then see dark monsters running at you, upon them approaching, a colorful sword appeared and spawned on your hand.";

        Level_2_Story.SetActive(false);
        Level_3_Choices.SetActive(true);
    }

    public void RunTakbo()
    {
        storyText = "You took the safe route and try to run away from them. Moving around as you imagine yourself as an RPG Characted in a game you play. As you were running away from the monsters, you suddenly woke up, looking at the ceiling in your room upon being woken up by your phone's alarm.";

        hpValue = 0;
        staminaValue = 5;

        Level_3_Choices.SetActive(false);
    }

    public void FendOff()
    {
        storyText = "You stood your ground and fought, did your best to fight them off, doing tricks and moves as you imagine yourself from a RPG Game you played. But as time passes fending off all by yourself, you get overwhelemed by the amound of them, awaking from your dream upon being defeated.";

        hpValue = 0;
        staminaValue = 0;

        Level_3_Choices.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}