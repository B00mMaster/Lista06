using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int start;
    public int end;

    private void Start()
    {   
        while(start<=end)//los nums estarán entre start y end al start no poder ser mayor q end
        { if (start % 5 == 0)// si el resto de start/5 es 0, es multiplo de 5

            { Debug.Log(start); }
            start++;
        }
    }
}
