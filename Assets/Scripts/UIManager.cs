using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour

{
    [SerializeField] TMP_Text txtPigsStats;

    public void UpdatePigStats(int pigsDestroyed, int pigsTotal)
    {
        txtPigsStats.text = $"{pigsDestroyed} / {pigsTotal}";
    }
}
