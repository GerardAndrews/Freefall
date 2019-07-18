using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_wireFrame : MonoBehaviour {

    private Rigidbody rb;
    public GameObject Cube;
    public GameObject Grid;
    public float Distance_;
    private static bool follow;

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        follow = false;

       // Distance_ = Cube.transform.position.y;
        // Distance_ = Grid.transform.position.y;
    }

    void Update()
    {

       Distance_ = Vector3.Distance(Cube.transform.position, Grid.transform.position);

        if (Distance_ > 46.7)
        {
            rb.isKinematic = true;
        }

        if (Distance_ < 46.7)
        {
            rb.isKinematic = false;
        }


        if (startAfterCounter.animEnd == false)
        {
            rb.isKinematic = true;
        }

        if (startAfterCounter.animEnd == true && follow == false)
        {
            rb.isKinematic = false;
            follow = true;
        }

        // gameObject.transform.position.y =   GameObject.FindGameObjectWithTag " ";

        /*        distance = Vector3.Distance(this.transform.position, gameObject.transform.position);

        if (distance > 1)
        {
            distance = 1;
        }

*/

        /*        if (Mover.stopper == true)
                {
                    rb.isKinematic = true;
                }

                if (Mover.stopper == false && startAfterCounter.animEnd == true)
                {
                    rb.isKinematic = false;
                }
        */

        //   if (!startAfterCounter.animEnd == true && false)
        //    {
        //       rb.isKinematic = true;
        //  }
    }
}
