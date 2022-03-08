using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsInitializer : MonoBehaviour
{
    public GameObject[] ballPF;
    private GameObject temp;
    PathMovement pathScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallSpawner", 2, 1);
    }

    public void BallSpawner()
    {
        int index = Random.Range(0, ballPF.Length);
       temp= Instantiate(ballPF[index], transform.position, transform.rotation);
        pathScript = temp.GetComponent<PathMovement>();
        pathScript.enabled = true;
    }
}

   
