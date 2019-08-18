using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
