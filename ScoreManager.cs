using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    
    public int ScoreToPrint;
    public Text BestToPrint;
  /*  public GameObject BestScore;*/
    public GameObject BestScorePrinted;
  /*  public GameObject Canvas;
    public GameObject BPlay;
    public GameObject BOptions;
    public GameObject BQuit;
    /*public GameObject Menu;*/
    public int scoreGame;
    private bool ActivePoints=true;
    LevelManager LevelM;
    
    

    private static ScoreManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        LevelM = FindObjectOfType<LevelManager>();

        
        if (instance != null)
        {
            Destroy(gameObject);
           
            
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
 
    

        void Start()
    {
        ScoreToPrint = PlayerPrefs.GetInt("Best", 0);
      
        


    }

    // Update is called once per frame
    void Update()
    {
        /* Debug.Log("best: " + ScoreToPrint);*/

        if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MAIN_MENU")) && (ActivePoints == true))
        {


            BestScorePrinted.gameObject.SetActive(true);

            BestToPrint.text = "" + ScoreToPrint;


        }
        else if((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MAIN_MENU")) && (ActivePoints == false))
        {
            
            BestScorePrinted.gameObject.SetActive(false);
        }


    }

    


    public void checkBestScore (int scoreOfGame)
    {
        scoreGame = scoreOfGame;
        if (scoreGame>ScoreToPrint) 
        {
            ScoreToPrint = scoreGame;
            PlayerPrefs.SetInt("Best", ScoreToPrint);

           
        }
    }

    public void NoPoints()
    {
        
        ActivePoints = false;
        
    }

    public void ShowPoints()
    {
       
        ActivePoints = true;

    }


 
}
