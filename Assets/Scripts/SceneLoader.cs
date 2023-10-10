using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadFirstScene()
    {
        SceneManager.LoadScene("Sele");
    }
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("Juego");
    }
    public void SceneCofing()
    {
        SceneManager.LoadScene("Config");
    }
    public void PreviusScene()
    {
        SceneManager.LoadScene("Menu");
    }
}