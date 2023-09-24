using UnityEngine;
public class endgame : MonoBehaviour
{
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            gameManager.WinLevel();
        }
    }
}
