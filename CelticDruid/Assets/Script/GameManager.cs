using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public GameObject noteHolder;

    public bool endPhase = false;
    public GameObject player;

    public int currentScore;
    public int scoreByNote = 100;
    public int scoreMaxPossible;
    public bool failed  =false;

    public int currentmissedRune;
    public int maxMissedRune;

    public Event box;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentmissedRune > maxMissedRune)
        {
            endPhase = true;
            failed = true;
            noteHolder.SetActive(false);

        }
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
            currentmissedRune = 0;
            maxMissedRune = 0;
            startPlaying = false;
            if (failed)
            {
                player.gameObject.GetComponent<Joueur>().SpiritCalmed--;

            }
            else
            {
                player.gameObject.GetComponent<Joueur>().SpiritCalmed++;

            }
            failed = false;
            endPhase = false;
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200 );


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
