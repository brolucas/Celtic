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
    public int difficulté = 3;
    public int nbrMaxMissedRune;
    public Animator spiritEvent;
  

    private void Start()
    {
        if (spirit.GetComponent<Spirit>().fire)
        {
            if (player.GetComponent<Joueur>().nbrWater > 0)
            {
                difficulté = 2;
            }
            else if (player.GetComponent<Joueur>().nbrWind > 0)
            {
                difficulté = 4;

            }

        }
        else if (spirit.GetComponent<Spirit>().wind)
        {
            if (player.GetComponent<Joueur>().nbrEarth > 0)
            {
                difficulté = 2;

            }
            else if (player.GetComponent<Joueur>().nbrFire > 0)
            {
                difficulté = 4;

            }
        }
        else if (spirit.GetComponent<Spirit>().earth)
        {
            if (player.GetComponent<Joueur>().nbrWater > 0)
            {
                difficulté = 2;

            }
            else if (player.GetComponent<Joueur>().nbrWind > 0)
            {
                difficulté = 4;

            }
        }
        else
        {
            if (player.GetComponent<Joueur>().nbrFire > 0)
            {
                difficulté = 2;

            }
            else if (player.GetComponent<Joueur>().nbrEarth > 0)
            {
                difficulté = 4;

            }
        }
    }
    private void Update()
    {
        nbrMaxMissedRune = nbrRune / difficulté;
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
            GameManager.instance.noteHolder = noteHolder;
            GameManager.instance.theBS = btscr.GetComponent<BeatScroller>();
            GameManager.instance.theBS.hasStarted = true;
            GameManager.instance.box = this;
            spirit.GetComponent<Spirit>().goodSpirit = true;
            GameManager.instance.theEvent = this;
            int i = 1;

            foreach (var item in collision.GetComponent<Vie>().calmedSpirits)
            {
                if (collision.GetComponent<Vie>().instanciedSpirits.Contains(item) == false)
                {
                    Instantiate<GameObject>(item, new Vector3(transform.position.x - collision.GetComponent<Vie>().distance * i, transform.position.y, transform.position.z), Quaternion.identity);
                    item.name = i.ToString();
                    collision.GetComponent<Vie>().instanciedSpirits.Add(item);

                    i++;
                }

            }

        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            spirit.GetComponent<Spirit>().goodSpirit = false;
            collision.GetComponent<Vie>().instanciedSpirits.Clear();
            

        }
    }
}
