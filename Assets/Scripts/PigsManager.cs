using UnityEngine;

public class PigsManager : MonoBehaviour
{
    GameManager gameManager;
    UIManager uiManager;

    int pigsTotal;
    int pigsDestroyed = 0;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
        uiManager = GetComponent<UIManager>();

        if (uiManager != null)
        {
            uiManager.UpdatePigStats(pigsDestroyed, pigsTotal);
        }
    }

    public void RegisterPigDestroy()
    {
        pigsDestroyed++;

        if (uiManager != null)
        {
            uiManager.UpdatePigStats(pigsDestroyed, pigsTotal);
        }

        if (pigsDestroyed == pigsTotal)
        {
            if (gameManager != null)
            {
                gameManager.SwitchScene();
            }
        }

    }
}
