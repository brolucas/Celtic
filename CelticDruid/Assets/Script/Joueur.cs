using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public int SpiritCalmed = 1;
    public int Difficuly = 3;
    public bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.SpiritCalmed == 0)
        {
            end = true;
        }

        if (end == false)
        {
            Debug.Log("Fin de partie ");
        }
    }
}
