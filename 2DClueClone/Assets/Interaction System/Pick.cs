using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour, IInteractable
{
    public string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact (Interactor interactor) {
        Debug.Log("Interacting");
        return true;
    }
}
