using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    private GameObject door;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        Debug.Log("Keypad Interact called");
        if (door == null)
        {
            Debug.LogError("Door is null in Keypad");
            return;
        }
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}


