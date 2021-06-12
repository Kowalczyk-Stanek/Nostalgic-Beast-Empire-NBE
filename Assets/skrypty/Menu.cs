using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject OptionsScreen;
    public GameObject MenuScreen;
    public GameObject PauseMenu;
    private bool Muted;

    public GameObject UnmuteButton;
    public GameObject MuteButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Option()
    {
        MenuScreen.SetActive(false);
        OptionsScreen.SetActive(true);
       
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;

    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;

    }
    public void Mute()
    {
        Muted = !Muted;
        AudioListener.pause = Muted;


    }
    public void MuteGame()
    {
        Muted = !Muted;
        AudioListener.pause = Muted;


        if (Muted == false)
        {
            AudioListener.pause = Muted;

        }


    }
    public void Unmute()
    {
        Muted = false;

        AudioListener.pause = Muted;
    }

    public void Back()
    {
        MenuScreen.SetActive(true);
        OptionsScreen.SetActive(false);

    }

}
