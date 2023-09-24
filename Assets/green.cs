using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            gameManager.color = "Green";
            gameObject.SetActive(false);
        }
    }
}
