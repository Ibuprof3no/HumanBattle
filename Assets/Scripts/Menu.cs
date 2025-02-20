using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject MenuPanel; // Referencia al panel del men� de pausa


    public bool isPaused = false; // Bandera para saber si el juego est� en pausa

    public Slider volumeSlider;  // Referencia al Slider
    public AudioListener audioListener; // Referencia al AudioListener, para controlar el volumen global

    void Start()
    {
        volumeSlider.value = 100;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }
    void Update()
    {
        // Verificar si se presiona la tecla Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
            if (isPaused)
            {
                ResumeGame();  // Si est� pausado, reanudar el juego
            }
            else
            {
                PauseGame();  // Si no est� pausado, pausar el juego
            }
        }
    }

    // Funci�n para pausar el juego
    void PauseGame()
    {
        MenuPanel.SetActive(true); // Activar el men� de pausa
        Time.timeScale = 0f; // Detener el tiempo en el juego (pausar el juego)
        isPaused = true;
    }
    void OnVolumeChanged(float value)
    {
        // Cambiar el volumen global de AudioListener (de 0 a 1)
        AudioListener.volume = value;
    }
    // Funci�n para reanudar el juego
    public void ResumeGame()
    {
        MenuPanel.SetActive(false); // Desactivar el men� de pausa
        Time.timeScale = 1f; // Reanudar el tiempo en el juego
        isPaused = false;
    }

    // Funci�n para salir del juego
    public void ExitGame()
    {
        Debug.Log("Salir del juego"); // Esto solo ser� un mensaje en la consola
        // Aqu� podr�as agregar c�digo para cerrar la aplicaci�n o cargar una escena de men� principal
        Application.Quit(); // Cerrar el juego cuando se haga click en "Salir"
    }
}
