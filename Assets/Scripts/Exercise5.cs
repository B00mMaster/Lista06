using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public int[] n;

    

    private void Start()
    {
        for(int x=0; x< n.Length;x++)
        {
          Debug.Log
                
          ($"{n[0]}+{n[1]}+{n[2]}+{n[3]}+{n[4]}" +
           $"= { n[0] + n[1] + n[2] + n[3]+n[4]}");
        }

        
    
    }







}
