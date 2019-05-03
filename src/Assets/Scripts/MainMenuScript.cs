using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public AudioMixer mixer;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
