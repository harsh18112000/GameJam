using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerObejct : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        rb.velocity = new Vector2(0f, 5f);
    }

    
}