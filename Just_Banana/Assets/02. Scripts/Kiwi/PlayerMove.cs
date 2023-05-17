using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public GameObject PlayerPivot;
    float rot = 0;
    public AudioClip walk_1;
    private new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Vector3 pos = transform.position;
            pos.z += 1;
            rot = 0;
            transform.position = pos;
            audio.PlayOneShot(walk_1, 1.0f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Vector3 pos = transform.position;
            pos.z -= 1;
            rot = 180;
            transform.position = pos;
            audio.PlayOneShot(walk_1, 1.0f);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x -= 1;
            rot = 270;
            transform.position = pos;
            audio.PlayOneShot(walk_1, 1.0f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x += 1;
            rot = 90;
            transform.position = pos;
            audio.PlayOneShot(walk_1, 1.0f);
        }
        transform.rotation = Quaternion.Euler(0, rot, 0);
        //키위새 회전
    }
}