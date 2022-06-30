using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour
{
    public GameObject[] playerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(int go)
    {
        playerText[go].SetActive(true);
        Time.timeScale = 0;
    }
    public void Retry()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
