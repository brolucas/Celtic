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

    public Event theEvent;

    public bool endPhase = false;
    public GameObject player;

    public int currentScore;
    public int scoreByNote = 100;
    public int scoreMaxPossible;
    public bool failed  =false;

    public int currentmissedRune;
    public int maxMissedRune;

    public Event box;

    public GameObject eau;
    public GameObject feu;
    public GameObject terre;
    public GameObject vent;


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
            noteHolder.SetActive(false); 
            if (failed)
            {
                player.gameObject.GetComponent<Joueur>().SpiritCalmed--;
                player.GetComponent<Vie>().calmedSpirits.Dequeue();

            }
            else
            {
                GameObject temp;
                player.gameObject.GetComponent<Joueur>().SpiritCalmed++;
                if (theEvent.spirit.tag == "Eau")
                {
                    temp = eau;
                }
                else if(theEvent.spirit.tag == "Feu")
                {
                    temp = feu;
                }
                else if(theEvent.spirit.tag == "Terre")
                {
                    temp = terre;
                }
                else
                {
                    temp = vent;
                }
                player.GetComponent<Vie>().calmedSpirits.Enqueue(temp);



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
