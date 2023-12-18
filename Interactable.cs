using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;
    //message displayed to player when looking at an interactable
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }

    //this function will be called from our player.
    public void BaseInteract()
    {
        if(useEvents) 
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }

    protected virtual void Interact()
    {
        //this is a template function that will be overridden by our classes 
    }
}
