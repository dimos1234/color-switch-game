using UnityEngine;

public class passthroughgreen : MonoBehaviour
{
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player" && gameManager.color == "Green")
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player" && gameManager.color != "Green")
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
