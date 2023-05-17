using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_1 : MonoBehaviour
{
    public GameObject fB;
    float rain;
    public void Start()
    {
        rain = Random.Range(-21.0f, 21.0f);
    }

    void Update()
    {
        for(int i = 0; i < 10; ++i)
        {
            GameObject temp = (GameObject)Instantiate(fB);
            temp.transform.position = new Vector3(rain, 10, 0);
            rain = Random.Range(-21.0f, 21.0f);
        }
    }
}
