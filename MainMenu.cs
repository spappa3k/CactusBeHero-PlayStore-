/*using System;*/
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
/*using System.ComponentModel;*/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    
    private AsyncOperation async;
    private string LevelName="GAME";
    public  GameObject LoadingLogo;
    public  GameObject BackGroundLoading;
   /* public  GameObject BPlay;
    public  GameObject Costumize;
    public  GameObject Settings;
    */
    public  GameObject Suggestion1;
    public  GameObject GameVolume;
    public GameObject UFO;
    public GameObject BestScoreDown;
    
    /*
     public  GameObject BestScore;
     */
    public GameObject menuAll;
    public GameObject Wardrobe;
    public GameObject Credits;

    public Text BestToPrint;
    public  GameObject BestScorePrinted;
    public GameObject Heroes;
    private int HighestScore;
    public ScoreManager ScoreM;
    private int ScoreToPrint;
    private int randomN;
    HeroFromEnd OpenHero;
    private bool ShowHeroAutomatically= false;

 
    void Awake()
    {
        OpenHero = FindObjectOfType<HeroFromEnd>();
        ScoreM = FindObjectOfType<ScoreManager>();
        ShowHeroAutomatically = OpenHero.OpenHeroMenu;
        /* BPlay.gameObject.SetActive(true);
         BestScore.gameObject.SetActive(true);
         */
    }

    void Start()
    {
        if (ShowHeroAutomatically == true)
        {
            menuAll.gameObject.SetActive(true);
            Wardrobe.gameObject.SetActive(false);
            Credits.gameObject.SetActive(false);

        }
        /*
          BPlay.gameObject.SetActive(true);
          Costumize.gameObject.SetActive(true);
          Settings.gameObject.SetActive(true);
          BestScore.gameObject.SetActive(true);
          VFxBox.gameObject.SetActive(true);
          */

        

        if(ShowHeroAutomatically==true)
        {
            menuAll.gameObject.SetActive(false);

            Wardrobe.gameObject.SetActive(true);
            Heroes.gameObject.SetActive(true);
        }
    }



    public void PlayGame()
    {
        ScoreM.NoPoints();


        menuAll.gameObject.SetActive(false);
       
        UFO.gameObject.SetActive(false);
      
       /* LoadingLogo.gameObject.SetActive(true);*/
        Suggestion1.gameObject.SetActive(true);
        BackGroundLoading.gameObject.SetActive(true);
        GameVolume.gameObject.SetActive(false);
       
        
        randomN = Random.Range(6,8);
        StartCoroutine(LoadGame());

        /*
        BPlay.gameObject.SetActive(false);
        Costumize.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        BestScore.gameObject.SetActive(false);
        VFxBox.gameObject.SetActive(false);
        */
    }

    private IEnumerator LoadGame()
    {
        
        async = Application.LoadLevelAsync(LevelName);
        async.allowSceneActivation = false;
        
        yield return new WaitForSeconds(randomN);
        async.allowSceneActivation = true;


    }

    public void SettingsScene()
    {
        menuAll.gameObject.SetActive(false);
     //   UFO.gameObject.SetActive(false);
      //  BestScoreDown.gameObject.SetActive(false);


        Wardrobe.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        /* System.Diagnostics.Process.GetCurrentProcess().Kill();*/

    }


    public void BackToMenu()
    {
        menuAll.gameObject.SetActive(true);
        Wardrobe.gameObject.SetActive(false);

       // UFO.gameObject.SetActive(true);
       // BestScoreDown.gameObject.SetActive(true);

    }


    public void ShowCredits()
    {
        Credits.gameObject.SetActive(true);
    }

    public void HideCredits()
    {
        Credits.gameObject.SetActive(false);
    }

}
