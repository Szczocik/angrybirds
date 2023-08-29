using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int activeSceneNumber;
    int scenesTotal;
    // Start is called before the first frame update
    void Start()
    {
        activeSceneNumber = SceneManager.GetActiveScene().buildIndex;
        scenesTotal = SceneManager.sceneCountInBuildSettings;
    }

    public void SwitchScene()
    {
        if (activeSceneNumber + 1 < scenesTotal)
        {
            SceneManager.LoadScene(++activeSceneNumber);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
