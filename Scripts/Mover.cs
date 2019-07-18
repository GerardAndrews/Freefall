using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    public static bool stopper;
    private bool isPaused = false;
    private bool animOn = startAfterCounter.animEnd;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Pause()
    {
        if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }



    void Update() { 
            if (Input.GetKeyDown(KeyCode.P))
            {
                Pause();
            }
            if (Time.timeScale == 1 && animOn == false) {
                    // Regular movement
                    if (Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(1.0f, 0.0f, 0.0f);
                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(-1.0f, 0.0f, 0.0f);
                    }

                    if (Input.GetKeyDown(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(0.0f, 0.0f, 1.0f);
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(0.0f, 0.0f, -1.0f);
                    }
                    // Minor movemnet
                    if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(0.4f, 0.0f, 0.0f);
                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(-0.4f, 0.0f, 0.0f);
                    }

                    if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(0.0f, 0.0f, 0.4f);
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.Translate(0.0f, 0.0f, -0.4f);
                    }
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        rb = GetComponent<Rigidbody>();
                        rb.velocity = transform.forward * speed; //affects speed
                    }
                    if (Input.GetKeyDown(KeyCode.Y))
                    {
                        rb = GetComponent<Rigidbody>();
                        rb.velocity = -(transform.forward) * speed; //affects speed
                    }

                    if (startAfterCounter.animEnd == false)
                    {
                        rb.isKinematic = true;
                    }

                    if (startAfterCounter.animEnd == true)
                    {
                        rb.isKinematic = false;
                    }
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        transform.Rotate(0.0f, 10.0f, 0.0f);
                    }
                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        transform.Rotate(0.0f, -10.0f, 0.0f);
                    }
                }
        }



        //   if (!startAfterCounter.animEnd == true && false)
        //    {
        //       rb.isKinematic = true;
        //  }
    }

  /*  void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "stop")
        {
            rb.isKinematic = true;
            stopper = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "stop")
        {
            stopper = false;
        }
    } */

//}