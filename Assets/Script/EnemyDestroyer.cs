using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EnemyDestroyer : MonoBehaviour
{
    public GameObject startpanel;
    private Rigidbody2D rb;
    private Transform player;
    public static int scrore = 0;
    public AudioSource myaudio;
    public AudioClip myclip;
    public void Start()

    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        rb = player.GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.transform.position = new Vector3(0, -2.850006f, 0);
            rb.velocity = new Vector2(0f, 0f);
            scrore=scrore+5;
            gameObject.SetActive(false);
            //Destroy(gameObject);
            myaudio.clip = myclip;
            myaudio.Play();
            
        }
        //else if(collision.tag == "TopWall")
        //{
         //   Destroy(gameObject);
           // startpanel.SetActive(true);
        //
       // }

    }





}
