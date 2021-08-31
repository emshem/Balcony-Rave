using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public Slider healthBar;
    public static float healthValue;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = healthValue;

        if( healthValue < 0.1f)
        {
            SceneManager.LoadScene("ResultsScene");
        }
    }

    public static void Miss()
    {
        healthValue -= 0.1f;
    }
}
