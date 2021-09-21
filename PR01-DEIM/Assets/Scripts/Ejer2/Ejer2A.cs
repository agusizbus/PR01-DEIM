using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2A : MonoBehaviour
{
    int contador = 1;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        
        if (contador <= 100)
        {

            print(contador);

        }
    }
}
