using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1 : MonoBehaviour
{
    [SerializeField] string Calculadora = "Marca dividir para sacar la mitad, desmarca para sacar el doble";
    [SerializeField] int numero = 0;
    private float mitad = 0.5f;
    private float doble = 2f;
    public bool dividir = true;


    // Start is called before the first frame update
    void Start()
    {
        //
        if (dividir == true)
        {
            print("La mitad de " + numero + " es " + numero * mitad);
        }
        
        else
        {
            print("El doble de " + numero + " es " + numero * doble);
        }
    }

 
}
