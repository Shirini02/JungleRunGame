using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreincrement: MonoBehaviour
{
    public static scoreincrement Instance;

    public Text scoreText, crystalscoretext;
    int highscore =0;

    public void Awake()
    {

        Instance = this;

    }
    // Start is called before the first frame update
    public int coinsscore = 0;
    public int CrystalScore = 0;
    public void IncrementScore()
    {
       
    coinsscore = coinsscore + 10;
        scoreText.text = "CoinsScore:" + coinsscore;
        print("\n");

     



    }
    public void CrustalIncScore()
    {
        CrystalScore = CrystalScore + 50;
        crystalscoretext.text = "Crystals Score:" + CrystalScore;
    }
   

}
