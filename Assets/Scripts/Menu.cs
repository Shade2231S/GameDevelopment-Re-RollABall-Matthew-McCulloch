using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Level2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Qwit()
    {
        Application.Quit();
    }
}
