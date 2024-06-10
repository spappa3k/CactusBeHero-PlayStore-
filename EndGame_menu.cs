using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame_menu : MonoBehaviour
{
    public GameObject UI_End;
    public GameObject UI_End2;
    public ScoreManager ScoreM;
    public GameObject LoadingLogo;
   
    private string LevelName = "GAME";
    private string MenuName = "MAIN_MENU";
    private AsyncOperation async;

    private AudioManager Audio;

    private int counter;
    private int whenToStop;
    public bool MenuHero=false;

    Equip EquipedYes;
    CounterForAd AdvCounter;

    HeroFromEnd HeroEnd;



    void Awake()
    {
        MenuHero = false;
        HeroEnd = FindObjectOfType<HeroFromEnd>();
        ScoreM = FindObjectOfType<ScoreManager>();
        Audio = FindObjectOfType<AudioManager>();
        EquipedYes = FindObjectOfType<Equip>();
        AdvCounter = FindObjectOfType<CounterForAd>();
    }
    
    public void ReplayGame()
    {
        MenuHero = false;
        HeroEnd.GetStatus(MenuHero);
        counter = AdvCounter.howmanyplayed+1;
        whenToStop = AdvCounter.TimesForAdV;
        Debug.Log("Counter= " + counter);

        if (counter < whenToStop)
        {
            StartCoroutine(LoadGame());
            Audio.EndButtons();
        }

    }

    public void Home()
    {
        EquipedYes.AutoDestroy();
        MenuHero = false;

        HeroEnd.GetStatus(MenuHero);

        ScoreM.ShowPoints();
        StartCoroutine(LoadMainMenu());
        Audio.EndButtons();


    }

    public void HeroHome()
    {
        EquipedYes.AutoDestroy();
        MenuHero = true;
        HeroEnd.GetStatus(MenuHero);

        ScoreM.ShowPoints();
        StartCoroutine(LoadMainMenu());
        Audio.EndButtons();


    }







    private IEnumerator LoadGame()
    {

        
        
        UI_End.gameObject.SetActive(false);
        UI_End2.gameObject.SetActive(false);
        LoadingLogo.gameObject.SetActive(true);
        async = Application.LoadLevelAsync(LevelName);
        async.allowSceneActivation = false;

        yield return new WaitForSeconds(1);
        
        async.allowSceneActivation = true;


    }

    private IEnumerator LoadMainMenu()
    {
        UI_End.gameObject.SetActive(false);
        UI_End2.gameObject.SetActive(false);
        LoadingLogo.gameObject.SetActive(true);
        async = Application.LoadLevelAsync(MenuName);
        async.allowSceneActivation = false;

        yield return new WaitForSeconds(2);
        async.allowSceneActivation = true;


    }
}
