using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
   //Esto sirve para el cambio de escenario con el juego.
{
    public void StartGame()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

     }
    public void Exit()
    {
        Application.Quit();
    }

}
