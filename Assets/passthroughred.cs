using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passthroughred : MonoBehaviour
{
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player" && gameManager.color == "Red")
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player" && gameManager.color != "Red")
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
