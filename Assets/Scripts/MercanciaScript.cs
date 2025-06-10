using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio = 100;
    public MoneyManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
        }
    }
}