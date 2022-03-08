using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnner : MonoBehaviour
{

   public GameObject[] ballPF;
    private GameObject temp;
    MoveForward moveScript;
    BallsCollision collisionscript;

    // Start is called before the first frame update
    void Start()
    {
       // temp = Instantiate(ballPF[0], transform.position, transform.rotation);
       // (It was to know which color ball will be next)
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, ballPF.Length);
            temp = Instantiate(ballPF[index], transform.position, transform.rotation);
            moveScript = temp.GetComponent<MoveForward>();
            moveScript.enabled = true;
            collisionscript = temp.GetComponent<BallsCollision>();
            collisionscript.enabled = true;
        }
  /*      if (Input.GetKeyDown(KeyCode.Space))
        {
            moveScript = temp.GetComponent<MoveForward>();
            moveScript.enabled = true;

        }*/


    }
}
