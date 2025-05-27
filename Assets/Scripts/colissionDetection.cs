using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colissionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
