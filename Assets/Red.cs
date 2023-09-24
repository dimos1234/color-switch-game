using UnityEngine;

public class Red : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            gameManager.color = "Red";
            gameObject.SetActive(false);
        }
    }
}
