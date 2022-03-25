using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nexPos;

    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform childTransform;
   [SerializeField]
    private Transform transformB;
   // private Transform positionB;
    // Start is called before the first frame update
    void Start()
    {
        posA = childTransform.localPosition;
        posB = new Vector3(1.62f, 2.95f,0);
        Debug.Log(posB);
        nexPos = posB;
        //positionB = GameObject.Find("positionB").GetComponent<Transform>();
        //transformB = positionB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);
        if(Vector3.Distance(childTransform.localPosition,nexPos) <= 0.1)
        {
            changeDestination();
        }
    }
    private void changeDestination()
    {
        nexPos = nexPos != posA ? posA : posB;
    }
}
