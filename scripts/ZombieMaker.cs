using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        print("hit zombiemaker");
        print(col.gameObject.name);
        if (col.gameObject.name == "character_zombie_fall")
        {
            print("enabling");
            col.gameObject.GetComponent<Zombie>().enableSprite();
        }
    }
}
