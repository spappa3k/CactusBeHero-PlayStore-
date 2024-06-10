
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public AudioSource GameStart;
    public AudioSource EndGame;
    public AudioSource RedSemaforo;
    public AudioSource GreenSemaforo;
    public AudioSource Limits;
   
    
    public AudioSource Jump1;
    public AudioSource Jump2;
    public AudioSource Jump3;
    public AudioSource Jump4;
    public AudioSource Jump5;

    public AudioSource[] Default;
    public AudioSource[] RedHead;
    public AudioSource[] PinkHead;
    public AudioSource[] BlackHead;
    public AudioSource[] Thief;
    public AudioSource[] Brexit;
    public AudioSource[] Pirate;
    public AudioSource[] Ninja;
    public AudioSource[] Alien;
    public AudioSource[] Pandemic;
    public AudioSource[] Gray;
    public AudioSource[] Dirty;
    public AudioSource[] RedFish;
    public AudioSource[] Homeless;
    public AudioSource[] RoboDog;
    public AudioSource[] Football;
    public AudioSource[] RageRobo;
    public AudioSource[] Rasta;
    public AudioSource[] Positive;
    public AudioSource[] LilTraptus;
    public AudioSource[] Invisible;
    public AudioSource[] AngryMonkey;
    public AudioSource[] Gold;

   
    

    public AudioSource Air;
    public AudioSource Explosion;
    public AudioSource Buttons;
    public AudioSource CollectGreen;
    public AudioSource CollectSilver;
    public AudioSource CollectGold;
    public AudioSource ToxicAlarm;
    public AudioSource EnemyFire;
    public AudioSource MonkeyComing;
    public AudioSource HeroMenuB;
    public AudioSource HeroEquiped;
    public AudioSource ArrowsSelectorR;
    public AudioSource ArrowsSelectorL;
    public AudioSource BackFromHero;
    public AudioSource VCheck;
    

    private bool soundOn=true;

    private int countJumps = 1;
    public int nHero;
    private int i;

    CharacterSelector Selected;
    AudioManager instance;


    void Awake()
    {
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

    public void PlayGame()
    {

        GameStart.Play();

    }

    public void EndG()
    {

        EndGame.Play();

    }

    public void RedLight()
    {

        RedSemaforo.Play();

        
    }

    public void GreenLight()
    {
        Selected = FindObjectOfType<CharacterSelector>();
        GreenSemaforo.Play();

    }

    public void Jump()
    {
        nHero = Selected.PlayerNumber;
        countJumps = Random.Range(1, 6);
        i = countJumps - 1;


        

        if (soundOn == true)
        {
            switch (nHero)
            {
                case 0:
                    Default[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 1:
                    RedHead[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 2:
                    BlackHead[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 3:
                    PinkHead[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 4:
                    Thief[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 5:
                    Brexit[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 6:
                    Pirate[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 7:
                    Ninja[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 8:
                    Alien[i].Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 9:
                    Pandemic[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 10:
                    Gray[i].Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 11:
                    Dirty[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 12:
                    RedFish[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 13:
                    Homeless[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 14:
                    RoboDog[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 15:
                    Football[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 16:
                    RageRobo[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 17:
                    Rasta[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 18:
                    Positive[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 19:
                    LilTraptus[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 20:
                    Invisible[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 21:
                    AngryMonkey[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                case 22:
                    Default[i].Play();
                    Air.Play();
                    StartCoroutine(nomorejumpSound());
                    break;
                



            }


            /*
            if (nHero == 15)
            {
                Football[i].Play();
                Air.Play();
                StartCoroutine(nomorejumpSound());
            }
            else
            {
                Default[i].Play();
                Air.Play();
                StartCoroutine(nomorejumpSound());
            }
            */
        }

















        /* 
         countJumps = Random.Range(1, 6);


         if ((countJumps == 1)&&(soundOn==true))
         {


             Jump1.Play();
             Air.Play();


             StartCoroutine(nomorejumpSound());
         }
         if ((countJumps == 2) && (soundOn == true))
         {

             Jump2.Play();
             Air.Play();


             StartCoroutine(nomorejumpSound());
         }
         if ((countJumps == 3) && (soundOn == true))
         {
             Jump3.Play();
             Air.Play();


             StartCoroutine(nomorejumpSound());
         }
         if ((countJumps == 4) && (soundOn == true))
         {
             Jump4.Play();
             Air.Play();


             StartCoroutine(nomorejumpSound());
         }
         if ((countJumps == 5) && (soundOn == true))
         {
             Jump5.Play();
             Air.Play();


             StartCoroutine(nomorejumpSound());

         }
         */
    }

    public void Boom()
    {
        Explosion.Play();

    }

    public void EndButtons()
    {
        Buttons.Play();

    }

    public void BabyGreen()
    {
        CollectGreen.Play();

    }

    public void BabySilver()
    {
        CollectSilver.Play();

    }

    public void BabyGold()
    {
        CollectGold.Play();

    }

    public void Alarm()
    {
        ToxicAlarm.Play();

    }


    public void EnemyShoot()
    {
        EnemyFire.Play();
    }

    public void EnemyComing()
    {
        MonkeyComing.Play();
    }


    public void NewHeroSelected()
    {
        HeroEquiped.Play();
    }

    public void V()
    {
        VCheck.Play();
    }

    public void HeroMenu()
    {
        HeroMenuB.Play();
    }

    public void ArrowsSelR()
    {
        ArrowsSelectorR.Play();
    }

    public void ArrowsSelL()
    {
        ArrowsSelectorL.Play();
    }

    public void BackFromHeroes()
    {
        BackFromHero.Play();
    }

    public void Limit()
    {
        Limits.Play();
    }

    



    public IEnumerator nomorejumpSound()
    {
        soundOn = false;
        yield return new WaitForSeconds(0.20f);
        soundOn = true;

    }

}
