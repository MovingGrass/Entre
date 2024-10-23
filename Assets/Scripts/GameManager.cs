using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    #endregion

    [SerializeField] private GameObject winCanvas;

    public int score;

    public void ReloadStage()
    {
        Time.timeScale = 1;
        var sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void EndStage()
    {
        Time.timeScale = 0;
        winCanvas.SetActive(true);
    }

}
