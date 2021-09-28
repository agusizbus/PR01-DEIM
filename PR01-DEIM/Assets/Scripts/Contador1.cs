using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador1 : MonoBehaviour   
{
    bool encendido = false;
    int n = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          

            if (encendido == false)
            {
                StartCoroutine("Contador");
                encendido = true;
            }

            else 
            {
                encendido = false;
            }
        }

        if ( encendido == false) 
        {
            StopCoroutine("Contador");
        }


    }
    IEnumerator Contador()
    {
        for (int n = 0; ; n++)
        {
            print(n);
            yield return new WaitForSeconds(1f);
        }
    }


}   
