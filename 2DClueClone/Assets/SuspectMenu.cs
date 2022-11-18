using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectMenu : MonoBehaviour
{
    public static bool isOpen = false;

    public GameObject journalUI;
    public GameObject suspectsPage;
    public GameObject inspectPage;

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
        isOpen = true;
    }

    public void Inspect() {
        suspectsPage.SetActive(false);
        inspectPage.SetActive(true);

        //Set UI's sprite to Item's sprite
    }

    public void Back() {
        suspectsPage.SetActive(true);
        inspectPage.SetActive(false);
    }
}
