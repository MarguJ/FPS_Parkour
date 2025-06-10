using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float playerMoney;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateMoneyUI(playerMoney.ToString());
    }

    public bool UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpdateMoneyUI(playerMoney.ToString());
            return true;
        }
    }
}