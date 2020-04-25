using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    int PlayerContador = 0;
    public int CountPlus(int PlayerContador)//se supone que esta funcion suma el numeros de jugadores pero aun no lo hace
    {
        if (PlayerContador < 4)
        {
            PlayerContador++;
        }

        return (PlayerContador);
    }

    public int CountMinus(int PlayerContador)//Se supone que esta en vez de sumar ahora resta xD
    {
        if (PlayerContador > 0)
        {
            PlayerContador--;
        }

        return (PlayerContador);
    }
}
