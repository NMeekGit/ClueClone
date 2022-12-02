using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string InteractionPrompt { get; }
    public string ItemPopUpPrompt { get; }
    public Sprite InteractionSprite { get; }
    public bool Interact (Interactor interactor);
}
