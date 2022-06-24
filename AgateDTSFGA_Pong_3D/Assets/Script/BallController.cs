using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rig;
    public BallSpawner spawnerManager;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        spawnerManager = FindObjectOfType<BallSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallLaunch(int indexPosition)
    {
        //float randomZ = Random.Range(0.5)
        switch (indexPosition)
        {
            case 0:
                rig.velocity = new Vector3(1, 0, 1);
                break;
            case 1:
                rig.velocity = new Vector3(-1, 0, 1);
                break;
            case 2:
                rig.velocity = new Vector3(-1, 0, -1);
                break;
            case 3:
                rig.velocity = new Vector3(1, 0, -1);
                break;
        }
    }
}
