using UnityEngine;
using UnityEngine.UI;

public class getLevel : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        Invoke("ChangeLevelText", 0.01f);
    }

    private void ChangeLevelText()
    {
        GetComponent<Text>().text = "Level " + (gameManager.level - 1).ToString();
    }
}
