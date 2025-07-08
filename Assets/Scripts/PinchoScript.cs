using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PinchoScript : MonoBehaviour
{
    public HealthManager vidaManager;
    public float daño;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (vidaManager.playerHealth >= daño)
            {
                vidaManager.UpdateHealth(daño);
            }
            else
            {
                SceneManager.LoadScene("FPS Parkour");
            }
        }
    }
}
