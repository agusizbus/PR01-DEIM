using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2C : MonoBehaviour
{


	// Start is called before the first frame update
	int randomNumber;
	[SerializeField] int numElegido;

	private void Start()
	{

		while (randomNumber != numElegido)
		{

			randomNumber = Random.Range(0, 10);
			print(randomNumber);
		

		}


	}
}

