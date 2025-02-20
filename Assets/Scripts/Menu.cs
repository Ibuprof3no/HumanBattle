using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject MenuPanel; // Referencia al panel del menú de pausa


    public bool isPaused = false; // Bandera para saber si el juego está en pausa

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
                ResumeGame();  // Si está pausado, reanudar el juego
            }
            else
            {
                PauseGame();  // Si no está pausado, pausar el juego
            }
        }
    }

    // Función para pausar el juego
    void PauseGame()
    {
        MenuPanel.SetActive(true); // Activar el menú de pausa
        Time.timeScale = 0f; // Detener el tiempo en el juego (pausar el juego)
        isPaused = true;
    }
    void OnVolumeChanged(float value)
    {
        // Cambiar el volumen global de AudioListener (de 0 a 1)
        AudioListener.volume = value;
    }
    // Función para reanudar el juego
    public void ResumeGame()
    {
        MenuPanel.SetActive(false); // Desactivar el menú de pausa
        Time.timeScale = 1f; // Reanudar el tiempo en el juego
        isPaused = false;
    }

    // Función para salir del juego
    public void ExitGame()
    {
        Debug.Log("Salir del juego"); // Esto solo será un mensaje en la consola
        // Aquí podrías agregar código para cerrar la aplicación o cargar una escena de menú principal
        Application.Quit(); // Cerrar el juego cuando se haga click en "Salir"
    }
}
