using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    private bool get = false;
    public bool isLastRune = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                GameManager.instance.NoteHit();
                get = true;
                gameObject.SetActive(false);
                    
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (!get)
            {
                GameManager.instance.NoteMissed();
                GameManager.instance.currentmissedRune += 1;

            }
            if (isLastRune)
            {
                GameManager.instance.endPhase = true;
            }
        }
    }
}
