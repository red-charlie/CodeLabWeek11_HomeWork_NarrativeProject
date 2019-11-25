using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class UI_NarrativeText : MonoBehaviour
{

    public Text NarrativeText; //Text that changes with narrative
    public GameObject StartButton; //this button switches scenes 
    public GameObject ConversationObject; 

    public GameObject TitleUI; //This is the title

    public GameObject NextButton; //next button for narrative
 
   



    public string OpeningText ="OpeningText";
    public string SecondaryText = "SecondaryText";
     public string TertiaryText = "TertText";



    // Start is called before the first frame update
    void Start()
    {

        
        StartButton.SetActive(false); 
        TitleUI.SetActive(false); 
        NextButton.SetActive(false); 
        NarrativeText.text = OpeningText;
       

    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    
    public void NextButtonNarrative () 
    { 
        
        if(NarrativeText.text == TertiaryText){ //starts the game menu
            NextButton.SetActive(false);
            StartButton.SetActive(true);
            TitleUI.SetActive(true);
            ConversationObject.SetActive(false);

            
        }
        if(NarrativeText.text== SecondaryText){
            NarrativeText.text = TertiaryText; //replaces with tert text

        }
        else{
            print("Should be moving on to the second text"); //testing if this works
            NarrativeText.text = SecondaryText; //replaces with secondary text
            
        }
    }
}
