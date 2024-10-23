using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinCanvas : MonoBehaviour
{
    public TMP_Text scoreText;

    private void OnEnable()
    {
        scoreText.text = $"Score : {GameManager.Instance.score}";
    }
}
