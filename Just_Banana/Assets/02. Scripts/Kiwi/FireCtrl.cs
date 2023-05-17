using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public AudioClip fire_1;
    public AudioClip fire_2;
    private new AudioSource audio;
    int ammo = 10;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ammo > 0)
            {
                Fire();
                ammo--;
                Debug.Log(ammo);
            }
            else
            {
                audio.PlayOneShot(fire_2, 1.0f);
            }
        }
    }
    void Fire()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
        audio.PlayOneShot(fire_1, 1.0f);
    }
}
