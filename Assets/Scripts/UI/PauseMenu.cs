using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject _resumeButton, _mainMenuButton, _quit, _blurImage, _EventSystem, _healthbar, _chestBar,_endDoor;

    [SerializeField]
    private AudioSource _bgAudio;

    private void Awake()
    {
        _bgAudio.Play(0);
    }

    private void Update()
    {
        if(Globals.KeyCollected)
        {
            _endDoor.gameObject.SetActive(false);
            // Debug.LogError($"DoorOpen");
        }
        if (Time.timeScale == 0)
        {
            _EventSystem.gameObject.SetActive(true);
            _resumeButton.gameObject.SetActive(true);
            _mainMenuButton.gameObject.SetActive(true);
            _quit.gameObject.SetActive(true);
            _blurImage.gameObject.SetActive(true);
            _healthbar.gameObject.SetActive(false);
            _chestBar.gameObject.SetActive(false);

        }
    }
    public void Resume()
    {
        _healthbar.gameObject.SetActive(true);
        _chestBar.gameObject.SetActive(true);
        _EventSystem.gameObject.SetActive(false);
        _resumeButton.gameObject.SetActive(false);
        _mainMenuButton.gameObject.SetActive(false);
        _quit.gameObject.SetActive(false);
        _blurImage.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
