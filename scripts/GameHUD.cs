using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameHUD : MonoBehaviour
{
    public TMP_Text inGameScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inGameScore.text = ScoreSystem.score.ToString();
    }
}
