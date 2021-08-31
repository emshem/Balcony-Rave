using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissDetector : MonoBehaviour
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
        if(col.gameObject.name == "target" && col.gameObject.GetComponent<Target>() != null)
        {
            if( !col.gameObject.GetComponent<Target>().hit)
            {
                HealthSystem.Miss();
            }
        }
    }
}
