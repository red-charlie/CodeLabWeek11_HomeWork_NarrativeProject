using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UI_GameNarrative : MonoBehaviour
{
    public string PlayerName;//the player's name will be changed on start
    //the text in the order it happens not sure how to do a public array, but this was super easy to manage below
    public string text_1;
    public string text_2;
    public string text_3;
    public string text_4;
    public string text_5;
    public string text_6;
    public string text_7;
    //realizing about 80 percent of the way through this I could've done an array/list with for 
    //20/20 hindsight

    public Text ConversationText;
    public GameObject NextButton;

    public Text gameOverTitle;

    public GameObject ParticleEffect;

    public GameObject Head;
   
    void Start (){
        
        PlayerName = UI_NameScript.PlayerName;
         //Get the player name from other script

         string replaceText = gameOverTitle.text;

         gameOverTitle.text = replaceText.Replace ("<name>", PlayerName);

       
    }
    public void NextButtonPress(){
        print("You have pushed the next button");
        
        if (ConversationText.text == text_1){
            ConversationText.text = text_2;
     
        }
         else if (ConversationText.text == text_2){
            ConversationText.text = text_3;
            ParticleEffect.SetActive(true);
           
        }
         else if (ConversationText.text == text_3){
            ConversationText.text = text_4;
            Head.SetActive(true);
           
        }
        else if (ConversationText.text == text_4){
            ConversationText.text = text_5;
           
        }
         else if (ConversationText.text == text_5){
            ConversationText.text = text_6;
           
        }
         else if (ConversationText.text == text_6){
             
             ConversationText.text = text_7;
         
         }
         else if(ConversationText.text==text_7){
             NextButton.SetActive(false);
             ConversationText.enabled=false;
             this.gameObject.SetActive(false);


         }
        else{
            ConversationText.text = text_1;
       
        }

    }


}
