using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode fwdKey;
    public KeyCode bckKey;

    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(GetInput());
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
        Debug.Log("test" + movement);
        rig.velocity = movement;
    }
}
