using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenuScene : MonoBehaviour
{

    [SerializeField]
    private EventSystem _eventSystem;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void Play()
    {
       _eventSystem.enabled = false;
        Invoke("PlayLoad", 1f);
    }

    public void Instructions()
    {
        _eventSystem.enabled = false;
        Invoke("InstructionsLoad", 1f);
    }

    public void Credits()
    {
        _eventSystem.enabled = false;
        Invoke("CreditsLoad", 1f);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void PlayLoad()
    {
        SceneManager.LoadScene("DungeonMaster");        
    }

    private void InstructionsLoad()
    {
        SceneManager.LoadScene("Instructions");    
    }

    private void CreditsLoad()
    {
        SceneManager.LoadScene("Credits");      
    }

}
