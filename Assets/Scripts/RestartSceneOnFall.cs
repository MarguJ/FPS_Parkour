using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnFall : MonoBehaviour
{
    public float deathFallHeight = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Respawned");
        if (transform.position.y < deathFallHeight)
        {
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
