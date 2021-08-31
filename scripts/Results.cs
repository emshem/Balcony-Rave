using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Results : MonoBehaviour
{
    public TMP_Text finalScore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore.text = "Score: " + ScoreSystem.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
