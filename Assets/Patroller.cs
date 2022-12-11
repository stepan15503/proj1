using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public float speed;

    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpots;
    
    private int spot;

    // Start is called before the first frame update
    void Start()
    {
        spot = 0;
        transform.Rotate(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[spot].position, speed * UnityEngine.Time.deltaTime);
        if(Vector2.Distance(transform.position, moveSpots[spot].position) < 0.2)
        {
            if (waitTime <= 0)
            {
                if (spot == 1)
                {
                    spot = 0;
                }
                else
                {
                    spot = (spot + 1);
                }
                if (transform.position.x < moveSpots[spot].position.x)
                {
                    transform.Rotate(0, 180, 0);
                }
                else
                {
                    transform.Rotate(0, 180, 0);
                }
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= UnityEngine.Time.deltaTime;
            }
        }
    }
}
