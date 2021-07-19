using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    int highscore = 0;
    public Text HighscoreText,CrystalHighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       int coinhighscore = scoreincrement.Instance.coinsscore;
        int crystalhighscore = scoreincrement.Instance.CrystalScore;
        if (coinhighscore>highscore)
        {
           

                HighscoreText.text = "CoinsScore:" + coinhighscore;
            CrystalHighScoreText.text = "CrystalScore:" + crystalhighscore;

                
            
        }
        if(crystalhighscore>highscore)
        {
            HighscoreText.text = "CoinsScore:" + coinhighscore;
            CrystalHighScoreText.text = "CrystalScore:" + crystalhighscore;
        }
       
       
    }
}
