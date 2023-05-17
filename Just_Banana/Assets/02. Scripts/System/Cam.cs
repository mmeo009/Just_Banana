using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform targetTr;
    private Transform camTr;
    public float distance = 5.0f;
    public float height = 2.0f;
    public float damping = 1.0f;
    public float targetOffset = 2.0f;
    private Vector3 velocity = Vector3.zero;
    public int camMod = 0;
    void Start()
    {
        camTr = GetComponent<Transform>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (camMod == 2)
            {
                camMod = 0;
            }
            else
            {
                camMod++;
            }
        }
    }
    void LateUpdate()
    {
        if (camMod == 0)
        { 
        Vector3 pos = targetTr.position + (-targetTr.forward * distance) + (Vector3.up * height);
        camTr.position = Vector3.SmoothDamp(camTr.position, pos, ref velocity, damping);
        camTr.LookAt(targetTr.position + (targetTr.up * targetOffset));
        }
        if (camMod == 1) 
        {
            transform.rotation = Quaternion.Euler(90, 0, 0);
            transform.position = new Vector3(targetTr.position.x , 10, targetTr.position.z);

        }
        if(camMod == 2)
        {
            camTr.LookAt(targetTr.position + (targetTr.forward * targetOffset));
            transform.position = targetTr.position;
        }
    }
}
