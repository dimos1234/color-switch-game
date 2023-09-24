using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public GameManager gameManager;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        GetComponent<Rigidbody>().MovePosition(new Vector3(GetComponent<Transform>().position.x - verticalMovement, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z + horizontalMovement));
    }

    void Update()
    {
        if (gameManager.color == "Red")
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            Debug.Log("Red");
        }

        if (gameManager.color == "Green")
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
        }
    }
}
