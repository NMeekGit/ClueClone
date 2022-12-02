using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public Transform _interactionPoint;
    public float _interactionPointRadius;
    public LayerMask _interactableMask;
    public InteractionPromptUI _interactionPromptUI;
    public ItemPopUpUI _itemPopUpUI;

    private readonly Collider2D[] _colliders = new Collider2D[3];
    public int _numFound;

    private IInteractable _interactable;

    void Update() {
        _numFound = Physics2D.OverlapCircleNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, _interactableMask);

        if (_numFound> 0) {
            _interactable = _colliders[0].GetComponent<IInteractable>();

            if (_interactable != null) {
                if (!_interactionPromptUI.IsDisplayed) {
                    _interactionPromptUI.SetUp(_interactable.InteractionPrompt);
                }
                if (Input.GetKeyDown("e")) {
                    _interactable.Interact(this);

                    if(!_itemPopUpUI.IsDisplayed) {
                        _itemPopUpUI.SetUp(_interactable.ItemPopUpPrompt, _interactable.InteractionSprite);
                    }
                }
                if (_itemPopUpUI.IsDisplayed && Input.GetKeyDown("q")) {
                    _itemPopUpUI.Close();
                }
            }
        } else {
            
            if (_interactable != null) {
                _interactable = null;
            }

            if (_interactionPromptUI.IsDisplayed) {
                _interactionPromptUI.Close();
            }
        }
    }
}
