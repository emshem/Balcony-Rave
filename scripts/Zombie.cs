using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private Transform transform;
    public GameObject human;
    public GameObject parent;
    private GameObject newHuman;

    public bool hit;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hit == true)
        {
            hit = false;
            TransformToHuman();
        }
    }

    void TransformToHuman()
    {
        StartCoroutine(TransformToHumanCoroutine());
        Destroy(newHuman,5);
    }

    IEnumerator TransformToHumanCoroutine()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        newHuman = Instantiate(human);
        newHuman.transform.position = transform.position;
        newHuman.transform.SetParent(parent.transform, true);
        yield return null;
    }

    public void enableSprite()
    {
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
