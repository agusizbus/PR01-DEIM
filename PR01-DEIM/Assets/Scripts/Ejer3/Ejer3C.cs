using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3C : MonoBehaviour
{
    float n = 0f;
    bool encendido = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");


    }

    // Update is called once per frame
    void Update()
    {

        if (n >= 5 )
        {

            StopCoroutine("Contador");

        }

    }

    IEnumerator Contador()
    {
        for (n = 0; ;n++)
        {
            print(n);
            yield return new WaitForSeconds(1f);

        }
    }

}
