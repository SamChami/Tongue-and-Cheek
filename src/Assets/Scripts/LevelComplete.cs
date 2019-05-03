using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void loadNextLevel()
    {
        Debug.Log("NICE");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
