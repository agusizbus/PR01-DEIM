using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3A : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string Nombre;

    void Start()
    {
        Saludar();
    }
    void Saludar()
    {

        print("Hola " + Nombre);


    }
    void Update()
    {
        
    }

}
    