using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public GameObject noteHolder;
    private BeatScroller btscr;
    public AudioSource theMusic;
    public GameObject player;


    private void Update()
    {
        
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
