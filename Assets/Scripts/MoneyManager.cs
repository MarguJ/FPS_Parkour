using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{   
    public float money;
    public TextMeshProUGUI moneyAmount;
    public void UpdateMoney(float amount)
    {
        money =- amount;
    }
}
