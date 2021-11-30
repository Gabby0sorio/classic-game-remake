using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour

{

    [SerializeField] private GameObject pauseUI;
    [SerializeField] private bool isPaused;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0.0f;
        pauseUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        pauseUI.SetActive(false);
        isPaused = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
