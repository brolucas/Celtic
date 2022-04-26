using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public GameObject noteHolder;
    private BeatScroller btscr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right *Vector2.zero);
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            noteHolder.SetActive(true);
            btscr = noteHolder.GetComponent<BeatScroller>();
            btscr.hasStarted = true;
            
        }
    }
}
