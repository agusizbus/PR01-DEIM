using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3B : MonoBehaviour
{
    public bool Multiplicar;
    public bool Dividir;
    [SerializeField] int num1 = 0;
    [SerializeField] int num2 = 0;
    float resultado = 0f ;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Calculo()
    {
        if (Multiplicar == true); 
        {

            print (num1 * num2);
        
        }



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
