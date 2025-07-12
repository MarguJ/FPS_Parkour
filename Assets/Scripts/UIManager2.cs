using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager2 : MonoBehaviour
{
    public TextMeshProUGUI txtHealth;

    public void UpdateHealthUI(string daño)
    {
        txtHealth.text = "HP:" + daño;
    }
}