using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2B : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int numerowhile = 0;

        while (numerowhile < 10)
        {

            print("numero vale " + numerowhile + ". Es menor que 10");
            numerowhile++;
        }

       
        int numerofor = 20;
        
        for (int n = 0; n <= numerofor; n++)
        {
            
            print ("numero vale : " + n + " es mayor que 10");

        }
      
    }

}
