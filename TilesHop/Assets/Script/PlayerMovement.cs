using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public Transform point1;
    public Transform point2;
    public Transform point3;
    public float[] values;

    public Transform player;

    public float speed = 0.5f;

    float movement;

    // Update is called once per frame
    void Update()
    {
        //speed = (speed + Time.deltaTime) % 1.0f;
        movement += Time.deltaTime * speed;

        if (movement > 1)
            movement = 0;

       /// transform.position = Moveplayernew(point1.position, point2.position, point3.position, movement);

    }

    Vector3 Moveplayernew(Vector3 p1, Vector3 p2, Vector3 p3, float speeds)
    {
        Vector3 target12 = Vector3.Lerp(p1, p2, speeds);
        Vector3 target23 = Vector3.Lerp(p2, p3, speeds);
        Vector3 AB_BC = Vector3.Lerp(target12, target23, speeds);
        return AB_BC;
    }
}


