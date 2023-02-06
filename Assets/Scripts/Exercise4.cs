using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int start;
    public int end;

    private void Start()
    {   
        while(start<=end)
        { if (start % 5 == 0)

            { Debug.Log(start); }
            start++;
        }
    }
}
