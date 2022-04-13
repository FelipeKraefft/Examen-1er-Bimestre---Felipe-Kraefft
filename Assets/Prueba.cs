using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {

    /*
     Un refugio de animales rescatados nos pide que le programemos una calculadora de alimento para saber qué costo tendrán que afrontar para darle de comer a sus animales.
Los datos que tenemos son:
. Los gatos comen 300 g de alimento por día, y su código es G.
. Los perros comen 400 g de alimento por día, y su código es PP.
. Los perros grandes comen 700 g de alimento por día, y su código es PG. 


       Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse. 

El programa debe cumplir los siguientes requerimientos:

Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.

Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que muestre el costo de la cantidad de alimento calculada. 

Debe mostrar mensajes de error (y no realizar el cálculo) si se ingresa un código no válido o si se ingresa una cantidad de días menor a 3.

         */

    public string Codigo;
    public int dias;

    int gato = 300;
    int perro = 400;
    int perroG = 700;

    int precio = 80;
    int totalG;
    int totalP;

	// Use this for initialization
	void Start () {
		if (dias < 3)
        {
            Debug.Log("La cantidad de dias es menor a 3, no se va a realizar el calculo");
        }
        else if (Codigo == "G")
        {
            totalG = gato * dias;
            totalP = totalG * precio / 100;
            Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
            Debug.Log("Esto va a costar $" + totalP);
        }
        else if (Codigo == "PP")
        {
            totalG = perro * dias;
            totalP = totalG * precio / 100;
            Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
            Debug.Log("Esto va a costar $" + totalP);
        }
        else if (Codigo == "PG")
        {
            totalG = perroG * dias;
            totalP = totalG * precio / 100;
            Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
            Debug.Log("Esto va a costar $" + totalP);
        }
        else
        {
            Debug.Log("El codigo ingresado es incorrecto");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
