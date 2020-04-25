using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    int PlayerContador = 0;
    public int CountPlus(int PlayerContador)
    {
        if (PlayerContador < 4)
        {
            PlayerContador++;
        }

        return (PlayerContador);
    }

    public int CountMinus(int PlayerContador)
    {
        if (PlayerContador > 0)
        {
            PlayerContador--;
        }

        return (PlayerContador);
    }

    public void PlayerCount()
    {

    }

    public void CreacionJugador()
    {

    }
}
