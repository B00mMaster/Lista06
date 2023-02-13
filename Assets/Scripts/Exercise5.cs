using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public int[] n;

    int num;

    private void Start()
    {
        foreach(int Sum in n)
        {
            num += Sum;
            //num es igual a la suma de los 5 n
        }
        Debug.Log($"{n[0]}+{n[1]}+{n[2]}+{n[3]}+{n[4]}={num}");
        
    
    }







}
