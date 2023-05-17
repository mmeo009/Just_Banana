using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreater : MonoBehaviour
{
    public GameObject bTile;
    public GameObject nana;
    public GameObject bana;
    public float nanaTimer = 10.0f;
    public int nanaOrBana;

    void Start()
    {
        nanaOrBana = Random.Range(0, 2);

        for (int i = 0; i < 10; i++)
        {
            int bananax = Random.Range(-14, 14);
            int bananaz = Random.Range(-14, 14);

            GameObject temp = (GameObject)Instantiate(bTile);
            temp.transform.position = new Vector3(bananax, 1, bananaz);
        }
    }
    private void Update()
    {
        nanaTimer -= Time.deltaTime;
        if(nanaTimer <= 0)
        {
            if (nanaOrBana == 0)
            {
                GameObject temp = (GameObject)Instantiate(nana);
                temp.transform.position = new Vector3(0, 3, 0);
            }
            else 
            {
                GameObject temp = (GameObject)Instantiate(bana);
                temp.transform.position = new Vector3(0, 3, 0);
            }
            nanaTimer = 15.0f;
            nanaOrBana = Random.Range(0, 2);
        }
    }
}
