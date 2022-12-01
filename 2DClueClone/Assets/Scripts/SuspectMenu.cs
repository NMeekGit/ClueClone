using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SuspectMenu : MonoBehaviour
{
    public static bool isOpen = false;

    public GameObject journalUI, suspectsPage, inspectPage, susManager;

    public Image pfp, item1, item2, item3, item4; //profile pic. The one in the Inspect Page
    //Portait Order: chef, house maid, gardener, pirate, butler, pool boy
    public Sprite[] portaits;
    //Item Order: knife, dirty jacket, cigarette butt, beer bottle, candlle stick, letter opener, watch, rope, garden tool, chemicals
    public Sprite[] items;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)) {
            if(isOpen) {
                CloseJournal();
            } else {
                OpenJournal();
            }
        }
    }

    public void CloseJournal() {
        journalUI.SetActive(false);
        isOpen = false;
    }

    public void OpenJournal() {
        journalUI.SetActive(true);
        suspectsPage.SetActive(true);
        inspectPage.SetActive(false);
        isOpen = true;
    }

    public void Inspect() {
        suspectsPage.SetActive(false);
        inspectPage.SetActive(true);

        string suspect = EventSystem.current.currentSelectedGameObject.name;

        switch(suspect) {
            case "Suspect1":
                //Chef
                Debug.Log("Inspecting: " + suspect);
                pfp.GetComponent<Image>().color = Color.black;
                //pfp.sprite = portraits[0];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("Chef", 0));
                setItems("Chef");
                break;
            case "Suspect2":
                //House Maid
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.blue;
                //pfp.sprite = portraits[1];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("House Maid", 0));
                setItems("House Maid");
                break;
            case "Suspect3":
                //Gardener
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.cyan;
                //pfp.sprite = portraits[2];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("Gardener", 0));
                setItems("Gardener");
                break;
            case "Suspect4":
                //Pirate
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.gray;
                //pfp.sprite = portraits[3];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("Pirate", 0));
                setItems("Pirate");
                break;
            case "Suspect5":
                //Butler
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.magenta;
                //pfp.sprite = portraits[4];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("Butler", 0));
                setItems("Butler");
                break;
            case "Suspect6":
                //Pool Boy
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.red;
                //pfp.sprite = portraits[5];
                Debug.Log(susManager.GetComponent<MurderSelect>().GetCharacterItems("Pool Boy", 0));
                setItems("Pool Boy");
                break;
        }

        //Set UI's sprite to Item's sprite
    }

    public void Back() {
        suspectsPage.SetActive(true);
        inspectPage.SetActive(false);
    }

    public void setItems(string name) {
        Debug.Log("Place holder text: " + name);
        //item1.sprite = items[susManager.GetComponent<MurderSelect>().GetCharacterItems(name, 0)];
        //item2.sprite = items[susManager.GetComponent<MurderSelect>().GetCharacterItems(name, 1)];
        //item3.sprite = items[susManager.GetComponent<MurderSelect>().GetCharacterItems(name, 2)];
        //item4.sprite = items[susManager.GetComponent<MurderSelect>().GetCharacterItems(name, 3)];
    }
}
