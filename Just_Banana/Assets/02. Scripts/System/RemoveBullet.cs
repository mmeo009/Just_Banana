using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public AudioClip nanaDie;
    private new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == ("BULLET"))
        {
            Destroy(coll.gameObject);
        }
        if (coll.collider.tag == ("NANA"))
        {
            Destroy(coll.gameObject);
            audio.PlayOneShot(nanaDie, 1.0f);
        }
        if (coll.collider.tag == ("BANA"))
        {
            Destroy(coll.gameObject);
            audio.PlayOneShot(nanaDie, 1.0f);
        }
        if (coll.collider.tag == ("KIWI"))
        {
            Application.Quit();
        }
    }
}
