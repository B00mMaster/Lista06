using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int n =10;
    void Start()
    {
        for (int i = n; n <= 0; i -= n)
        {
            Debug.Log(n);


        }

    }
}