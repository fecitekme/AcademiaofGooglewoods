using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pazarci : MonoBehaviour, InteractableInterface
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Pazarcý ile Konuþuluyor");
        return true;

    }






}