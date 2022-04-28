using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public int SpiritCalmed = 1;

    public int nbrFire = 0;
    public int nbrWater = 0;
    public int nbrWind = 0;
    public int nbrEarth = 0;


    public bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        int elem = Random.Range(1,4);
        switch (elem)
        {
            case 1:
                nbrFire++;
                break;
            case 2: 
                nbrWater++;
                break;
            case 3:
                nbrWind++;
                break;
            case 4:
                nbrEarth++;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.SpiritCalmed == 0)
        {
            end = true;
        }

        if (end == true)
        {
            Debug.Log("Fin de partie ");
        }
    }
}
