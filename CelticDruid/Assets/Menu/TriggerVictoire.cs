using UnityEngine;
using UnityEngine.UI;

public class TriggerVictoire : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject _VICTORY;
    private bool isInRange;

    void Update()
    {
        if(isInRange)
        {
            _VICTORY.SetActive(true);
            Paused();

        }
    }
    
    void Paused()
    {
        Time.timeScale = 0;
        gameIsPaused = true;
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = true;
            
        }
    }
}