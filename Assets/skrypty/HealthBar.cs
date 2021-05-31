using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour

{
    public Slider healthBar;
    public health playerHealth;

    public void healtbarSet()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
    }
    public void MaxValueSet(int hp)
    {
        healthBar.maxValue = hp;

    }
    public void SetHealth(int hp)
   {
        healthBar.value = hp;
    }
}


