using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
