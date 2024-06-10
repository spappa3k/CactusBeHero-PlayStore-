using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsHeroSugg : MonoBehaviour
{

    public GameObject Cloud0;
    public GameObject Cloud1;
    public GameObject Cloud2;
    public GameObject Cloud3;
    public GameObject Cloud4;
    private int scoreNow;
    private int whichCloud = 0;
    ScoreManager Score;





    void Awake()
    {
        Score = FindObjectOfType<ScoreManager>();
        scoreNow = Score.ScoreToPrint;


        if(scoreNow<1000)
        {
            whichCloud = 0;
        }

        if ((scoreNow >= 1000)&&(scoreNow<2000))
        {
            whichCloud = 1;
        }

        if ((scoreNow >= 2000) && (scoreNow < 3000))
        {
            whichCloud = 2;
        }

        if ((scoreNow >= 3000) && (scoreNow < 5000))
        {
            whichCloud = 3;
        }

        if (scoreNow >= 6000)
        {
            whichCloud = 4;
        }



        switch (whichCloud)
        {
            case 0:
                Cloud0.gameObject.SetActive(true);
                Cloud1.gameObject.SetActive(false);
                Cloud2.gameObject.SetActive(false);
                Cloud3.gameObject.SetActive(false);
                Cloud4.gameObject.SetActive(false);
                
                break;

            case 1:
                Cloud0.gameObject.SetActive(false);
                Cloud1.gameObject.SetActive(true);
                Cloud2.gameObject.SetActive(false);
                Cloud3.gameObject.SetActive(false);
                Cloud4.gameObject.SetActive(false);

                break;

            case 2:
                Cloud0.gameObject.SetActive(false);
                Cloud1.gameObject.SetActive(false);
                Cloud2.gameObject.SetActive(true);
                Cloud3.gameObject.SetActive(false);
                Cloud4.gameObject.SetActive(false);

                break;

            case 3:
                Cloud0.gameObject.SetActive(false);
                Cloud1.gameObject.SetActive(false);
                Cloud2.gameObject.SetActive(false);
                Cloud3.gameObject.SetActive(true);
                Cloud4.gameObject.SetActive(false);

                break;

            case 4:
                Cloud0.gameObject.SetActive(false);
                Cloud1.gameObject.SetActive(false);
                Cloud2.gameObject.SetActive(false);
                Cloud3.gameObject.SetActive(false);
                Cloud4.gameObject.SetActive(true);

                break;


        }
    }



}
