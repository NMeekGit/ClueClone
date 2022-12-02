using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour, IInteractable
{
    public string _interactionPrompt;
    public string _itemPopUpPrompt;
    public Sprite _sprite;

    public string InteractionPrompt => _interactionPrompt;
    public string ItemPopUpPrompt => _itemPopUpPrompt;
    public Sprite InteractionSprite => _sprite;

    public bool Interact (Interactor interactor) {
        Debug.Log("Interacting");
        return true;
    }
}
