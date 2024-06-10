using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text startGame;
    private int startgen;
    private int totalpoints;
    public Text Points;
    public Text End_TotalScore;
    public Text ShadowEndTotal;
    private bool scoreOn = false;
    private PlayerController Player;
    private AudioManager Audio;
    private bool game_started = false;
    public Spawn_CrazyEnemy crazyEnemy;
    public int free_enemy = 0;
    private int timesenemyspawns = 1;
    public int pointsToEnemySpawn;
    private bool isLevelEnd = false;
    public float secondsToShowEnd;
    public float Lag_ToShowButtons;
    public GameObject UI_End;
    public GameObject UI_End2;
    public GameObject Speed;
    public GameObject RecordScore;
    public GameObject HeroUnlocked;
    public ScoreManager ScoreM;
    private float PointsOfThisGame;
    private float effectCounting = 0;
    private bool canShowScore = false;
    public int BestScore = 0;
    private bool giveBestScore = false;
    private static LevelManager instance;
    private bool HideTopScore = false;
    private int ScoreToBeat;
    private int PreviousBest;
    public int[] PointsToUnlock;
    public int i;
    private int MinimumPoints;
    public int icounter=-1;
    private bool FirstHeroToUnlock;




    void Awake()
    {
        Player = GameObject.FindObjectOfType<PlayerController>();
        crazyEnemy = FindObjectOfType<Spawn_CrazyEnemy>();
        ScoreM = FindObjectOfType<ScoreManager>();
        Audio = FindObjectOfType<AudioManager>();

        ScoreToBeat = ScoreM.ScoreToPrint;
        PreviousBest = ScoreM.ScoreToPrint;
        GetMinimum();
    }


    // Update is called once per frame
    void Update()
    {


        if (canShowScore == true)

        {
            if (effectCounting <= totalpoints - 2)
            {
                if (totalpoints < 500)
                {
                    effectCounting = effectCounting + 5 * 2;
                }
                if ((totalpoints >= 500) && (totalpoints < 1000))
                {
                    effectCounting = effectCounting + 10 * 2;
                }
                if ((totalpoints >= 1000) && (totalpoints < 1500))
                {
                    effectCounting = effectCounting + 15 * 2;
                }
                if ((totalpoints >= 1500) && (totalpoints < 2000))
                {
                    effectCounting = effectCounting + 20 * 2;
                }
                if ((totalpoints >= 2000) && (totalpoints < 2500))
                {
                    effectCounting = effectCounting + 25 * 2;
                }
                if ((totalpoints >= 2500) && (totalpoints < 3000))
                {
                    effectCounting = effectCounting + 30 * 2;
                }
                if ((totalpoints >= 3000) && (totalpoints < 3500))
                {
                    effectCounting = effectCounting + 35 * 2;
                }
                if ((totalpoints >= 3500) && (totalpoints < 4000))
                {
                    effectCounting = effectCounting + 40 * 2;
                }
                if ((totalpoints >= 4000) && (totalpoints < 4500))
                {
                    effectCounting = effectCounting + 45 * 2;

                }
                if ((totalpoints >= 4500) && (totalpoints < 5000))
                {
                    effectCounting = effectCounting + 50 * 2;

                }
                if ((totalpoints >= 5000) && (totalpoints < 5500))
                {
                    effectCounting = effectCounting + 55 * 2;

                }
                if ((totalpoints >= 5500) && (totalpoints < 6000))
                {
                    effectCounting = effectCounting + 60 * 2;

                }
                if (totalpoints >= 6000)
                {
                    effectCounting = effectCounting + 90 * 2;

                }







                End_TotalScore.text = "Total Score: " + effectCounting;
                ShadowEndTotal.text = "Total Score: " + effectCounting;
            }
            else
            {
                End_TotalScore.text = "Total Score: " + totalpoints;
                ShadowEndTotal.text = "Total Score: " + totalpoints;
            }
        }


        if (game_started == false)
        {

            StartGame();
        }
        else if ((game_started == true) && (isLevelEnd == false))
        {

            if (HideTopScore == false)
            {
                Points.text =""+ totalpoints;
            }
            if (HideTopScore == true)
            {
                Points.text = " ";
            }

        }


        /*if (totalpoints >= pointsToEnemySpawn + timesenemyspawns*1000)*/
        if (totalpoints >= pointsToEnemySpawn * timesenemyspawns)
        {
            free_enemy = 1;
        }

        if (free_enemy == 1)
        {

            crazyEnemy.spawnyesorno(free_enemy);
            timesenemyspawns++;

        }

        free_enemy = 0;



    }

    public void AddPoints(int numberofpoints)
    {
        totalpoints = totalpoints + numberofpoints;


    }
    /*
    public void startmenu()
    {
        startGame.text = "Press S to start";
    }*/

    public void StartGame()
    {
        StartCoroutine(countDownStart());
    }

    public IEnumerator countDownStart()
    {

        yield return new WaitForSecondsRealtime(3.2f);




        HideTopScore = false;
        game_started = true;
        Player.gamehasstarted(game_started);
    }



    public void EndLevel(bool endgame)
    {
        ScoreM.checkBestScore(totalpoints);
        isLevelEnd = endgame;
        StartCoroutine(showEnd());
        StartCoroutine(showEnd2());


    }

    public IEnumerator showEnd()
    {
        yield return new WaitForSeconds(secondsToShowEnd);

        UI_End.gameObject.SetActive(true);
    }
    public IEnumerator showEnd2()
    {
        yield return new WaitForSeconds(secondsToShowEnd + Lag_ToShowButtons);


        HideTopScore = true;
        Speed.gameObject.SetActive(false);
        UI_End2.gameObject.SetActive(true);

        if (FirstHeroToUnlock == true)
        {
            if (totalpoints >= PointsToUnlock[0])
            {
                HeroUnlocked.gameObject.SetActive(true);


            }
        }
        else
        {
            unlockedAnyone();
        }



        if (totalpoints > ScoreToBeat)
        {
            RecordScore.gameObject.SetActive(true);
        }
        else
        {
            RecordScore.gameObject.SetActive(false);
        }



        Audio.EndG();
        canShowScore = true;

    }



    public void GetMinimum()
    {
        if (PreviousBest < PointsToUnlock[0])
        {
            FirstHeroToUnlock = true;
        }


        if (PreviousBest >= PointsToUnlock[0])
        {
            FirstHeroToUnlock = false;
        }

        for (i = 0; i<19; i++)
        {
            icounter++;

            if (PointsToUnlock[i]>= PreviousBest)
            {
                break;
            }

            /*
            if (PreviousBest >= PointsToUnlock[i])
            {
                Debug.Log("i :"+i);
               icounter = i;
                break;

            }*/
        }


    }



    public void unlockedAnyone()
    {


        if (totalpoints >= PointsToUnlock[icounter /*+ 1*/])
        {
            HeroUnlocked.gameObject.SetActive(true);




        }
        else
        {
            HeroUnlocked.gameObject.SetActive(false);



        }

    }

     }













