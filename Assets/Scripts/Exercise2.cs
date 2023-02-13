using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private int i = 1;

    private void Start()
    {
        while (i <=20)
        {   //Mientras i no valga 20, la frase se repetirá
            Debug.Log($"Hola, holita, vecinito");
            i++;
        }
    }
}
