using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        var score= PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();

        var highscore = PlayerPrefs.GetInt("hightScore");
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("hightScore", highscore);
        }
        highScoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
