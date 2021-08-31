using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Animator animator;
    private bool isButtonPressed = false;

    public float speed = 800f;
    public Vector2[] target;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        target = new Vector2[] { new Vector2( -2.996519f, -1.07f), new Vector2( -2.996519f, 1.23f ), new Vector2(-2.996519f, 4.24f), new Vector2(-2.996519f, 7.04f) };
        //target = new Vector2[] { new Vector2(-2.996519f, 6.88f), new Vector2(-2.996519f, 4.08f), new Vector2(-2.996519f, 0.82f), new Vector2(-2.996519f,-2.5f) };

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GoToWindow(0);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            GoToWindow(1);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            GoToWindow(2);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            GoToWindow(3);
        }
        else if( AnyKeyUp() )
        {
            rigidBody.gravityScale = 5f;
            isButtonPressed = false;
            animator.SetBool("IsRunning", true);
        }
    }

    bool AnyKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4);
    }

    bool AnyKeyUp()
    {
        return Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4);
    }

    void GoToWindow(int windowNm)
    {
        animator.SetBool("IsRunning", false);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, target[windowNm], step);
        rigidBody.velocity = new Vector2(0f, 0f); // stop currrent motion
        rigidBody.gravityScale = 0f;
        isButtonPressed = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "target" && isButtonPressed)
        {
            ScoreSystem.AddScore();
            if (col.gameObject.GetComponent<Target>() != null)
            {
                col.gameObject.GetComponent<Target>().hit = true;
            }
        }
        if (col.gameObject.name == "character_zombie_fall" && isButtonPressed)
        {
            col.gameObject.GetComponent<Zombie>().hit = true;
        }
    }
    /*----------------------------------- not used
    void SetZeroGravityTimer()
    {
        zeroGravityTimer = 0.3f;
    }

    void UpdateTimer()
    {
        // stay midair for zeroGravityTimer amount of time
        if( zeroGravityTimer > 0f) {
            zeroGravityTimer -= Time.deltaTime;
        }

        // start to drop
        if( zeroGravityTimer <= 0f)
        {
            rigidBody.gravityScale = 5f;
        }
    }
    */
}
