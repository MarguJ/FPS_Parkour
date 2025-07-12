using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIManager2 uiManager2;

    void Start()
    {
        uiManager2.UpdateHealthUI(playerHealth.ToString());
    }

    public bool UpdateHealth(float daño)
    {
        if(playerHealth >= daño)
        {
            playerHealth -= daño;
            Debug.Log(playerHealth);
            uiManager2.UpdateHealthUI(playerHealth.ToString());
            return true;
        }
        else
        {
            return false;
        }
    }
}
