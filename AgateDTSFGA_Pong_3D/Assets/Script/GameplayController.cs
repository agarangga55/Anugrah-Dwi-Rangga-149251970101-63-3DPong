using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public GameSceneManager manager;
    public BallSpawner spawner;
    public List<PaddleController> playerList;
    public GameObject winCanvas;

    public bool gameIsDone;

    public int playerLose;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameIsDone)
        {
            winCanvas.SetActive(true);
        }
    }

    public void WinCondition()
    {
        if (playerLose >= 3)
        {
            Time.timeScale = 0;
            gameIsDone = true;
            int playerWin;
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].isLost == false)
                {
                    playerWin = playerList[i].playerNumber;
                    manager.GameOver(playerWin);
                }
            }
        }
    }
}
