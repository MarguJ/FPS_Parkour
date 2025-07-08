using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtInfo;

    public void UpdateInfoUI(string amount)
    {
        txtInfo.text = "Dinero: $" + amount + "/n Holaa";
    }
}