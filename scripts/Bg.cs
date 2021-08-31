using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour
{
    public int playerLayer = 3;
    public int backgroundLayer = 6;

    // Start is called before the first frame update
    void Start()
    {
        // ignore collisions between player and background
        Physics.IgnoreLayerCollision(playerLayer, backgroundLayer, true);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
