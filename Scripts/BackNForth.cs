using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackNForth : MonoBehaviour

{

    // Vector3 pos1;
    //Vector3 pos2;
    //  public float moving;

    // Vector3 tempPos; //Declared position variable
    //  private Vector3 pos1 = new Vector3(x, y, z);
    //   private Vector3 pos2 = new Vector3(x + 10, y + 5, z + -20);
    // public float rightLimit = 2.5f;
    /// public float leftLimit = 1.0f;
    //   public float range;
    //  public float X;
    // private float startTime;
    // public float counter;
    // public float speed;
    //  public Transform targetA;
    // public Transform targetB;

    public Vector3 pointB;
    public float frames;

    IEnumerator Start()
    {
        var pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, frames));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, frames));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }

    //  private int direction = 1;
    void awake()
    {
    //    this.transform.position = 0.5f * (targetA.transform.position + targetB.transform.position);
    }
    public void start()
      {

        //   startTime = Time.time;
        // counter = 0;
        //  pos1 = transform.position;
        // pos2 = transform.position + new Vector3(0, 0, 5);

        //   tempPos = transform.position; // Positon stored in tempPos
        

    }
  /*  void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "targetA")
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetB.position, step);
        }

        if (other.tag == "targetB")
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetA.position, step);
        }
    }
    */
    void Update()
     {
       // this.transform.position = 0.05f * (targetA.transform.position + targetB.transform.position);
        //ransform.position = Vector3.Lerp(transform.position, target, speed);
        //  float step = speed * Time.deltaTime;
        //   transform.position = Vector3.MoveTowards(transform.position, targetA.position, step);

        //  transform.position = new Vector3(Mathf.Lerp(-5, 5, Mathf.PingPong(Time.time, range)), transform.position.y, transform.position.z); // here range is time between movement
        // moving += 0.1f;
        //transform.position = Vector3.Lerp ()
        //   tempPos.z += 1f; // Then we add 5f to x here
        //  transform.position = tempPos;

        //  transform.Translate( 0, 0, speed * Time.deltaTime);

        // if (transform.position.z <= speed + 50)
        // {
        //      transform.Translate(0, 0, -speed * Time.deltaTime);
        //  }



        /*     if (transform.position.z <= 90f)
             {
                 tempPos.z -= 5f;
             }
             if (transform.position.z < -90f)
             {
                 tempPos.z += 5f;
             }
         */

        //    transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));
        //    if (transform.position.x > rightLimit)
        //    {
        //       direction = -1;
        //   }
        //    else if (transform.position.x < leftLimit)
        //   {
        //      direction = 1;
        //   }
        //    movement = Vector3.right * direction * speed * Time.deltaTime;
        //     transform.Translate(movement);
    }

  

}





 // this code works like a swing or a pendelum, but I can only get it working on the X axis
     /*
public enum OccilationFuntion { Sine, Cosine }



public void Start()
{

    //to start at zero
    //    StartCoroutine(Oscillate(OccilationFuntion.Sine, -50f));
    //to start at scalar value
    StartCoroutine(Oscillate(OccilationFuntion.Cosine, -50f));


}


private IEnumerator Oscillate(OccilationFuntion method, float scalar)
{
    while (true)
    {
        if (method == OccilationFuntion.Sine)
        {
            transform.position = new Vector3(Mathf.Sin(Time.time) * scalar, 5, 5);
        }
        else if (method == OccilationFuntion.Cosine)
        {
            transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 5, 5);
        }
        yield return new WaitForEndOfFrame();
    }
}
*/