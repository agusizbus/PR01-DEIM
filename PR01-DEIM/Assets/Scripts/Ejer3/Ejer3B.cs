using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3B : MonoBehaviour
{
    [SerializeField] float n1 = 0f;
    [SerializeField] float n2 = 0f;
    [SerializeField] int operacion = 0;
    float resultado = 0;

    // Start is called before the first frame update
    void Start()
    {

        Calcular(n1, n2, operacion);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(resultado);
            
        }
    }

    void Calcular( float num1, float num2, int op)

    {

        float resultado = 0f;
        if (op == 0)
        {
            resultado = num1 + num2;
        }

        else if (op == 1)
        {
            resultado = num1 - num2;
        }

        else if (op == 2)
        {
            resultado = num1 * num2;
        }

        else if (op == 3)
        {
            resultado = num2 / num2;
        }

        print(resultado);
    }
}
