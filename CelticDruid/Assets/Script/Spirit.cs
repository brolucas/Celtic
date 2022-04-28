using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : MonoBehaviour
{
    public bool fire;
    public bool water;
    public bool earth;
    public bool wind;
    public bool tuto;
    public Sprite phaseContente;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (tuto)
        {
            int elem = Random.Range(1, 4);
            switch (elem)
            {
                case 1:
                    fire = true;
                    break;
                case 2:
                    water = true;
                    break;
                case 3:
                    earth = true;
                    break;
                case 4:
                    wind = true;
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.currentScore > GameManager.instance.scoreMaxPossible/2)
        {
            Debug.Log(GameManager.instance.currentScore);
            Debug.Log(GameManager.instance.scoreMaxPossible / 2);
            //GetComponent<SpriteRenderer>().sprite = phaseContente;
            animator.SetInteger("Current score", 1);
        }
    }
}
