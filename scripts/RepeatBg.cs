using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private float width;
    private float speed = -10f;
    private RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rt = GetComponent<RectTransform>();
        width =  rt.rect.width;
        rigidBody.velocity = new Vector2(speed, 0);        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width) {
            Reposition();
        }        
    }

    private void Reposition()
    {
        Vector2 vector = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
