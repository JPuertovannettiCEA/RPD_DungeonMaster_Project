using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraScenes : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
