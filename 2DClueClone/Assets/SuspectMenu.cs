using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SuspectMenu : MonoBehaviour
{
    public static bool isOpen = false;

    public GameObject journalUI;
    public GameObject suspectsPage;
    public GameObject inspectPage;

    public Sprite[] portaits;
    public Image pfp; //profile pic. The one in the Inspect Page

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
                Debug.Log("Inspecting: " + suspect);
                pfp.GetComponent<Image>().color = Color.black;
                break;
            case "Suspect2":
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.blue;
                break;
            case "Suspect3":
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.cyan;
                break;
            case "Suspect4":
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.gray;
                break;
            case "Suspect5":
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.magenta;
                break;
            case "Suspect6":
                Debug.Log("Inspecting " + suspect);
                pfp.GetComponent<Image>().color = Color.red;
                break;
        }

        //Set UI's sprite to Item's sprite
    }

    public void Back() {
        suspectsPage.SetActive(true);
        inspectPage.SetActive(false);
    }
}
