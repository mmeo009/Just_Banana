using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRain : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -8)
        {
            Destroy(this.gameObject);
        }
    }
}
