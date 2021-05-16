using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public Button instrumentButton;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()


    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(1);
        }

        //timer
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                if (curHealth <= 0)
                {

                    Debug.Log("Zabiłeś potwora na czas, gratulacje");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

                }
                else
                {


                    Debug.Log("Czas się skończył");
                    DisableButton();
                    timeRemaining = 0;
                    timerIsRunning = false;

                }

            }
        }
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    public void Hit2()
    {
        DamagePlayer(1);
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DisableButton()
    {
        instrumentButton.interactable = false;
    }

}
