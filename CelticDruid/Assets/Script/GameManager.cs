using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public bool endPhase = false;
    public GameObject player;

    public int currentScore;
    public int scoreByNote = 100;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (theBS.hasStarted)
            {
                startPlaying = true;
                theMusic.Play();
            }
        }
        if (endPhase)
        {
            theMusic.Stop();
            theBS.hasStarted = false;
            endPhase = false;
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * player.GetComponent<Auto_Run>().speed);

        }

    }
    public void NoteHit()
    {
        Debug.Log("Hit on Time");
        currentScore += scoreByNote;
    }
    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
