using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public List<Transform> backGround;
    public Transform player;
    public int presentBackground;
    public float offset;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > backGround[presentBackground].transform.position.x + distance)
        {
            int nextpos;
            if (presentBackground != 0)
            {
                nextpos = presentBackground - 1;
            }
            else
            {
                nextpos = backGround.Count - 1;
            }
            Vector3 newpos = backGround[nextpos].transform.position + new Vector3(0f, 0f, -5.08f * Time.deltaTime);
            backGround[presentBackground].transform.position = newpos;
            presentBackground++;
            if (presentBackground == backGround.Count)
            {
                presentBackground = 0;
            }

        }
    }
}
