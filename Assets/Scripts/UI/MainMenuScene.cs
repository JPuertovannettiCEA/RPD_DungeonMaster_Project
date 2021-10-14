using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("DungeonMaster");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
