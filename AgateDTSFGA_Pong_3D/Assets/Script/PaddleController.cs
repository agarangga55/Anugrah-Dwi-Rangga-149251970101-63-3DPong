using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PaddleController : MonoBehaviour
{
    public GoalController goal;
    public GameplayController gameplay;

    public int speed;
    public int score;
    public int loseScore;
    public int playerNumber;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode fwdKey;
    public KeyCode bckKey;

    public Rigidbody rig;

    public TextMeshProUGUI scoreText;

    public bool isLost;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        MovePaddle(GetInput());
        if (score == loseScore)
        {
            isLost = true;
            goal.GetComponent<CapsuleCollider>().isTrigger = false;
            this.gameObject.SetActive(false);

            gameplay.playerLose += 1;
            gameplay.WinCondition();
        }
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        if (Input.GetKey(fwdKey))
        {
            return Vector3.forward * speed;
        }
        if (Input.GetKey(bckKey))
        {
            return Vector3.back * speed;
        }
        return Vector3.zero;
    }
    
    private void MovePaddle(Vector3 movement)
    {
        rig.velocity = movement;
    }

    public void AddScore()
    {
        score += 1;
    }
}
