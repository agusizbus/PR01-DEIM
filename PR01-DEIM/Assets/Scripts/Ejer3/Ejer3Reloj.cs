using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3Reloj : MonoBehaviour
{
    int s = 0;
    int m = 0;
    int h = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");
    }

    IEnumerator Contador()
    {
        for (s = 0; ; s++)
        {
            Reloj();
            yield return new WaitForSeconds(1f);
        }
    }

    void Reloj ()
    {
        if (s > 59)
        {   
            m++;
            s = 0;
        }

        if (m > 59)
        {
            h++;
            m = 0;
        }
        print(h + ":" + m + ":" + s + ":");
    }
}

