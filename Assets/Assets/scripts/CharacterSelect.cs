using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CharacterSelect : MonoBehaviour
{
    public Text TextoContador;
    public void Update()
    {
        if (Input.GetButtonDown("izquierda"))
        {
            CountMinus();
        }

        if (Input.GetButtonDown("derecha"))
        {
            CountPlus();
        }
    }

    public void CountPlus()//se supone que esta funcion suma el numeros de jugadores pero aun no lo hace
    {
        int contador = Int32.Parse(TextoContador.text);
        Debug.Log(contador);
        if (contador < 4)
        {
            contador++;
        }
        TextoContador.text = (contador.ToString());
        
    }

    public void CountMinus()//Se supone que esta en vez de sumar ahora resta xD
    {
        int contador = Int32.Parse(TextoContador.text);
        if (contador > 1)
        {
            contador--;
        }

        TextoContador.text = (contador.ToString());
    }
}
