using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject system;
    private void Start()
    {
        system = GameObject.FindWithTag("SYSTEM");
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == ("BULLET"))
        {
            Destroy(coll.gameObject);
            system.GetComponent<BananaCounter>().IfBananaDistroy(1);
            Destroy(this.gameObject);
        }
        if (coll.collider.tag == ("KIWI"))
        {
            system.GetComponent<BananaCounter>().IfBananaEat(1);
            Destroy(this.gameObject);
        }
        if (coll.collider.tag == ("NANA"))
        {
            system.GetComponent<BananaCounter>().NanaBanana(1);
            Destroy(this.gameObject);
        }
    }
}
