using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{

    void Start()
    {//m�x de i 100, parar� hasta q i valga 0, restando 2 cada vez
        for (int i = 100; i >= 0; i -= 2)
        {
            Debug.Log(i);


        }

    }
}
