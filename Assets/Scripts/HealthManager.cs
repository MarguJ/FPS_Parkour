using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIManager uiManager;
    void Start()
    {
        uiManager.UpdateInfoUI(playerHealth.ToString());
    }

    public bool UpdateHealth(float daño)
    {
        if(playerHealth <= daño)
        {
            playerHealth -= daño;
            uiManager.UpdateInfoUI(playerHealth.ToString());
            return true;
        }
        else
        {
            return false;
        }
    }
}
