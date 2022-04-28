using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{
    public float distanceBetween = 3f;
    public float firstSpiritPosition;
    public GameObject[] lifeCount2;
    public GameObject[] spirits;
    public int life = 1;

    // Start is called before the first frame update
    void Start()
    {
        firstSpiritPosition = transform.position.x - distanceBetween;
        //hpCount.Enqueue(spirit);
        lifeCount2[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
   
        

    }
    
}
