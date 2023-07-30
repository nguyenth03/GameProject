using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    void Start()
    {

    }

    void Update()
    {
        if(healingAmount <= 0)
        {
            Application.LoadLevel(Application.loadLevel);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDame(20);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(5);
        }
        
    }

    public void TakeDame(float damege)
    {
        healthAmount -= damege;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount,0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
