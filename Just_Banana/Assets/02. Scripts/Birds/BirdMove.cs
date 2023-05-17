using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float recov;
    public int bRot = 0;
    int way;
    void Start()
    {
        way = Random.Range(1, 4);
        recov = Random.Range(1.0F, 5.0F);
    }
    void Update()
    {
        recov -= Time.deltaTime;

        if(recov <= 0)
        {
            if(way == 1)
            {
                Vector3 pos = transform.position;
                pos.x += 1;
                bRot = 90;
                transform.position = pos;
            }
            if (way == 2)
            {
                Vector3 pos = transform.position;
                pos.x -= 1;
                bRot = 270;
                transform.position = pos;
            }
            if (way == 3)
            {
                Vector3 pos = transform.position;
                pos.z += 1;
                bRot = 0;
                transform.position = pos;
            }
            if (way == 4)
            {
                Vector3 pos = transform.position;
                pos.z -= 1;
                bRot = 180;
                transform.position = pos;
            }
            transform.rotation = Quaternion.Euler(0, bRot, 0);
            way = Random.Range(1, 4);
            recov = Random.Range(1.0F, 5.0F);
        }
    }
}
