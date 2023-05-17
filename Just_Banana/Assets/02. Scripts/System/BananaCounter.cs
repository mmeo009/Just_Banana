using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BananaCounter : MonoBehaviour
{
    public int eB = 0;
    public int dB = 0;
    public int nB = 0;
    public void IfBananaEat(int eBanana)
    {
        if (eB < 10) 
        {
            eB += eBanana;
            Debug.Log(eB);
        }
        if(eB == 10) 
        {
            SceneManager.LoadScene("End_1");
        }
    }
    public void IfBananaDistroy(int dBanana) 
    {
        if (dB < 10)
        {
            dB += dBanana;
            Debug.Log(dB);
        }
        if (dB == 10)
        {
            SceneManager.LoadScene("End_2");
        }
    }
    public void NanaBanana(int nBanana) 
    { 
            nB += nBanana;
    }
    private void Update()
    {
        if(eB != 10)
            if (dB != 10)
                if (dB + eB + nB >= 10)
                {
                    SceneManager.LoadScene("Game");
                }
    }
}
