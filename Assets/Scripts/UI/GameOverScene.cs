using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameOverScene : MonoBehaviour
{

    [SerializeField]
    private EventSystem _eventSystem;

    public void MainMenu()
    {
       _eventSystem.enabled = false;
        Invoke("MainMenuLoad", 1f);
    }

    public void RestartMenu()
    {
        _eventSystem.enabled = false;
        Invoke("RestartLoad", 1f);
    }

    public void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartLoad()
    {
        SceneManager.LoadScene("DungeonMaster");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
