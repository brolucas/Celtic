using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{

    public float distance = 3;
    public Vector3 firstElementposition;
    public Queue<GameObject> calmedSpirits;
    public List<GameObject> instanciedSpirits;
    public Camera theCamera;
    public GameObject baseSpirit;

    public float speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        calmedSpirits = new Queue<GameObject>();
        instanciedSpirits = new List<GameObject>();
        distance = 3;
        firstElementposition = transform.position;
        firstElementposition.x = firstElementposition.x - distance;
        calmedSpirits.Enqueue(baseSpirit);
    }

    // Update is called once per frame
    void Update()
    {
       /* int i = 1;

        foreach (var item in calmedSpirits)
        {
            if (instanciedSpirits.Contains(item) == false)
            {
                Instantiate<GameObject>(item, new Vector3(transform.position.x - distance * i, transform.position.y, transform.position.z),Quaternion.identity);
                item.name = i.ToString();
                item.GetComponent<Rigidbody2D>().gravityScale = 0;
                item.GetComponent<Rigidbody2D>().velocity = Vector2.right * 200 ;
                instanciedSpirits.Add(item);

                i++;
            }
           
        }*/
    }
}
