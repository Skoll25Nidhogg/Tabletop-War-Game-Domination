using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);///cambia la escena desde el menu del juego a el mapa(necesito que se pase a el menu de seleccion de jugadores)
    }

    public void QuitGame()
    {
        Application.Quit();///cierra el juego
    }
}
