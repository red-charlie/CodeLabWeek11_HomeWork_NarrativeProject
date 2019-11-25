using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;



public class UI_NameScript : MonoBehaviour
{
     public Text Input; //input field for name

     public GameObject InputButton; //input button goes to next screen.
     public Text NarrativeText; //Text that changes with narrative
     public static string PlayerName = "PlayerName";
     public string ReplaceWName;
     public GameObject ConversationText;
     public GameObject NextButton;
     public GameObject InputObject;

     public void InputButtonPressed (){
        string replaceText = NarrativeText.text;

        PlayerName = Input.text; //Get the player name

        print ("The name of the player is " + Input.text); //testing if the name thing works
        
        NarrativeText.text = replaceText.Replace(ReplaceWName, PlayerName); //replace 
        
        NextButton.SetActive(true);
        ConversationText.SetActive(true);
        InputButton.SetActive(false);
        InputObject.SetActive(false);
        
        }
}
