using System;
using System.Collections;
using System.Collections.Generic;

using System.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Danger_area : MonoBehaviour
{
    public PlayerController Player;
    public bool PlayerDies=false;
    public float alphaLevel;
    public float speed_DangerS1;
    public float speed_DangerS2;
    public float speed_DangerS3;
    public float speed_DangerS4;
    public float limit_Danger;
    public AlphaClouds Clouds;
    public GameObject CloudsGO;
    private bool Immortal= true;
    public float startingDelay;
    public int stage;
    private float x_Player=0;
    public int actualS=-1;
    private float P_Alert;
    public int AlertNumber;
    
    // Start is called before the first frame update

    private void Awake()
    {
        Player = FindObjectOfType<PlayerController>();
        Clouds = CloudsGO.GetComponent<AlphaClouds>();
      

    }
    void Start()
    {
        
        stage = 0;
        timeforclouds();
    }

    // Update is called once per frame
    void Update()
    {
        checkStage();

        

        if(actualS== stage-1)
        {
            actualS++;
            Clouds.takeStage(actualS);
        }    


        
        Player.check_Danger(PlayerDies);
        


        if (alphaLevel>=limit_Danger/100)
        {
            PlayerDies = true;
        }


        
    }

   public void OnTriggerStay2D(Collider2D other)
    {
        

        if ((other.tag == "Player") && (Immortal == false) && (stage == 0))
        {

            alphaLevel = 0;
            Clouds.takeAlpha(alphaLevel);
            ;


        }

        if ((other.tag == "Player") && (Immortal == false)&&(stage==1))
        {
            
            alphaLevel = alphaLevel + ((speed_DangerS1/50)*Time.deltaTime);
            Clouds.takeAlpha(alphaLevel);
            

        }
        if ((other.tag == "Player") && (Immortal == false) && (stage == 2))
        {

            alphaLevel = alphaLevel + ((speed_DangerS2 / 50) * Time.deltaTime);
            Clouds.takeAlpha(alphaLevel);
           

        }
        if ((other.tag == "Player") && (Immortal == false) && (stage == 3))
        {

            alphaLevel = alphaLevel + ((speed_DangerS3 / 50) * Time.deltaTime);
            Clouds.takeAlpha(alphaLevel);
           

        }

        if ((other.tag == "Player") && (Immortal == false) && (stage == 4))
        {

            alphaLevel = alphaLevel + ((speed_DangerS4 / 50) * Time.deltaTime);
            Clouds.takeAlpha(alphaLevel);


        }



    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            alphaLevel = 0;
            Clouds.takeAlpha(alphaLevel);
            
        } 
    }


    public void timeforclouds()
    {
        StartCoroutine(whestartclouds());
    }

    public IEnumerator whestartclouds()
    {
        Immortal = true;
        yield return new WaitForSeconds(startingDelay);
        Immortal = false;
    }


    public void take_x_Player(float xFromplayer)
    {
        x_Player = xFromplayer;
    }


    public void PosAlert(float P_alert)
    {
        P_Alert = P_alert;
        AlertNumber++;
    }

  


    public void checkStage()
    {
        if (x_Player < 50)
        {
            stage = 0;

        }
        else if ((x_Player >= 50) && (x_Player < 100))
        {
            stage = 1;
        }

        else if((x_Player> P_Alert + 21f)&& (AlertNumber == 1))
        {
            stage = 2;
        }
        else if ((x_Player > P_Alert + 21f) && (AlertNumber == 2))
        {
            stage = 3;
        }
        else if ((x_Player > P_Alert + 21f) && (AlertNumber >= 3))
        {
            stage = 4;
        }




        /*
       
        else if ((x_Player >= 100) && (x_Player < 200))
        {
            stage = 2;
        }
        else if ((x_Player >= 200) && (x_Player < 300))
        {
            stage = 3;
        }*/
    }



        
    
}





