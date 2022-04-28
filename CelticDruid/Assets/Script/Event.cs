using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public GameObject noteHolder;
    private BeatScroller btscr;
    public AudioSource theMusic;
    public GameObject player;
    public GameObject spirit;
    public int nbrRune;
    public int difficult� = 3;
    public int nbrMaxMissedRune;
    public Animator spiritEvent;
  

    private void Start()
    {
        if (spirit.GetComponent<Spirit>().fire)
        {
            if (player.GetComponent<Joueur>().nbrWater > 0)
            {
                difficult� = 2;
            }
            else if (player.GetComponent<Joueur>().nbrWind > 0)
            {
                difficult� = 4;

            }

        }
        else if (spirit.GetComponent<Spirit>().wind)
        {
            if (player.GetComponent<Joueur>().nbrEarth > 0)
            {
                difficult� = 2;

            }
            else if (player.GetComponent<Joueur>().nbrFire > 0)
            {
                difficult� = 4;

            }
        }
        else if (spirit.GetComponent<Spirit>().earth)
        {
            if (player.GetComponent<Joueur>().nbrWater > 0)
            {
                difficult� = 2;

            }
            else if (player.GetComponent<Joueur>().nbrWind > 0)
            {
                difficult� = 4;

            }
        }
        else
        {
            if (player.GetComponent<Joueur>().nbrFire > 0)
            {
                difficult� = 2;

            }
            else if (player.GetComponent<Joueur>().nbrEarth > 0)
            {
                difficult� = 4;

            }
        }
    }
    private void Update()
    {
        nbrMaxMissedRune = nbrRune / difficult�;
        GameManager.instance.maxMissedRune = nbrMaxMissedRune;
        GameManager.instance.scoreMaxPossible = nbrRune * GameManager.instance.scoreByNote;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GameManager.instance.theMusic = this.theMusic;
            noteHolder.SetActive(true);
            btscr = noteHolder.GetComponent<BeatScroller>();
            btscr.hasStarted = true;
            
        }
    }
}
