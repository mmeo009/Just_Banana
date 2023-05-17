using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class BanaMove : MonoBehaviour
{
    GameObject myNana;
    public float banaY = 0;
    public bool amITop = false;
    public float sSpeed;
    public Rigidbody rb;
    private void Start()
    {
        sSpeed = Random.Range(700.0f, 1000.0f);
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("NANA"))
        {
            {
                myNana = (GameObject)collision.gameObject;
                Vector3 collisionPos = collision.transform.position;
                if (amITop == false)
                {
                    myNana.GetComponent<HowMany>().BanaOnTop();
                    banaY = myNana.GetComponent<HowMany>().top + 0.5f;
                    amITop = true;
                }
            }
        }
        if(collision.collider.tag != ("NANA"))
        {
            if(collision.collider.tag !=("BANA"))
            {
                amITop=false;
            }
        }
    }
    void OnCollisionStay(Collision collision)
        {
        if (amITop == true)
        {
            if (collision.collider.tag == ("NANA") || collision.collider.tag == ("BANA"))
            {
                Vector3 collisionPos = collision.transform.position;
                transform.position = new Vector3(collisionPos.x, banaY, collisionPos.z);
            }
        }
    }
    private void Update()
    {
        if (amITop == true)
        {
            rb.useGravity = false;
            transform.Rotate(Vector3.up * Time.deltaTime * sSpeed);
        }
        else
        {
            if (rb.useGravity == false)
            {
                myNana.GetComponent<HowMany>().BanaOut();
                myNana = null;
            }
            rb.useGravity = true;
        }
    }
}