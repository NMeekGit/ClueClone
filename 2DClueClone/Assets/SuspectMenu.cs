using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectMenu : MonoBehaviour
{
    public static bool isOpen = false;
    public GameObject journalUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)) {
            if(isOpen) {
                //Close Menu
                CloseJournal();
            } else {
                //Open Menu
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
}
