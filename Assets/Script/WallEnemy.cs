using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallEnemy : MonoBehaviour
{
    public GameObject startpanel;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TopWall")
        {
            //Destroy(this.gameObject);
            gameObject.SetActive(false);
            Time.timeScale = 0;
            startpanel.SetActive(true);

          
        }else if(collision.tag == "Player")
        {
            //Destroy(gameObject);
            startpanel.SetActive(true);
        }
    }
}
