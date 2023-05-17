using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowMany : MonoBehaviour
{
    public int top = 0;
    public void BanaOnTop()
    {
        top++;
    }
    public void BanaOut()
    {
        top--;
    }
}
