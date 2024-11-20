using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    
    private void Start()
    {
        // Initialize the text with starting score
        UpdateCoinDisplay();
    }

    private void Update()
    {
        // Update the text every frame to reflect any changes
        UpdateCoinDisplay();
    }

    private void UpdateCoinDisplay()
    {
        if (GameManager.Instance != null)
        {
            coinText.text = $"Coins: {GameManager.Instance.score}";
        }
    }
}
