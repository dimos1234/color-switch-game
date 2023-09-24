using UnityEngine;
using UnityEngine.SceneManagement;

public class yes : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        Application.Quit();
        Debug.Log("quit تسه لاه");
    }
}
