using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI highscoretext;
    

    int score = 0;
    int highscore = 0;
    

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        ScoreText.text = score.ToString() + " POINTS";

        highscoretext.text = "HIGHSCORE: " + highscore.ToString();

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoints()
    {
        score += 10;
        ScoreText.text = score.ToString() + " POINTS";
        if(score > highscore)
            PlayerPrefs.SetInt("highscore", score);


    }
}
