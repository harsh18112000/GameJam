using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpwan : MonoBehaviour
{
    public GameObject ringprefab;
    float min_x = -1.6125f;
    float max_x = 1.45f;
    //float min_y = 2.0f;
    //float max_y = 3.1019f;
    float ringTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ringTimer -= Time.deltaTime;
        if(ringTimer <= 0)
        {
            RingSpwaner();
        }
    }
    void RingSpwaner()
    {
        float randomx = Random.Range(min_x, max_x);
        //float randomy = Random.Range(min_y, max_y);
        Instantiate(ringprefab, new Vector3(randomx, 0, 0), Quaternion.identity);
        ringTimer += 5f;
    }
}
