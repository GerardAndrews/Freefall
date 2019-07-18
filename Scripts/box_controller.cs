using System.Collections;
using UnityEngine;

public class box_controller : MonoBehaviour {

    public float speed;

    //Boost Variables
    public float time;
    public float boostTime = 1.0f;
    public float currentBoostTime;
    public float boostDelayTime = 5.0f;
    public float currentBoostDelayTime;
    public bool boosting = false;

    //Break variables
    public float breakTime = 2.0f;
    public float currentBreakTime;
    public float breakDelayTime = 5.0f;
    public float currentBreakDelayTime;
    public bool breaking = false;

    private Rigidbody rb;

    void Start () {
        currentBoostTime = 0f;
        currentBoostDelayTime = 0f;
        currentBreakTime = 0f;
        currentBreakDelayTime = 0f;
        rb = GetComponent<Rigidbody>();
    }

    void boost()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !boosting && Time.time > currentBoostDelayTime)
        {
            currentBoostTime = Time.time + boostTime; //Start the timer for boost
            boosting = true; //You are now boost
        }
        if ((Time.time > currentBoostTime) && boosting)
        {
            boosting = false;
            currentBoostDelayTime = Time.time + boostDelayTime;
            //Am I boost, has the timer expired?
        }
        if (boosting)
        {
            rb.drag = 0;
        }
        if (!boosting)
        {
            rb.drag = 5;
        }
    }
	
    void breaker()
    {
        if (Input.GetKeyDown(KeyCode.E) && !breaking && Time.time > currentBreakDelayTime)
        {
            currentBreakTime = Time.time + breakTime; //Start the timer for brakes
            breaking = true; //You are now breaking
        }
        if ((Time.time > currentBreakTime) && breaking)
        {
            breaking = false;
            currentBreakDelayTime = Time.time + breakDelayTime;
            //Am I breaking, has the timer expired?
        }
        if (breaking)
        {
            rb.useGravity = false;
        }
        if (!breaking)
        {
            rb.useGravity = true;
        }
    }
    void Update()
    {
        time = Time.time; //debug
        breaker();
        boost();
    }
	// Update is called once per frame
	void fixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal"); //move left and right
        float moveVertical = Input.GetAxis("Vertical"); //move up and down

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
    }
}
