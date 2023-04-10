using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mentor : MonoBehaviour, InteractableInterface
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Mentor ile Konuþuluyor");
        return true;

    }






}