using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Equip : MonoBehaviour
{

    CharacterSelector StoreIt;
    public int CharacterSelected;
    private static Equip instance;
    SelectedScript Selected;

    // Start is called before the first frame update
    void Awake()
    {

        Selected = FindObjectOfType<SelectedScript>();



        if (instance != null)
        {
            Destroy(gameObject);


        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }




        StoreIt = FindObjectOfType<CharacterSelector>();

        CharacterSelected = PlayerPrefs.GetInt("HeroNumber", 0);

        Selected.CharacterChosen(CharacterSelected);
    }



  


    public void Hero0()
    {
        CharacterSelected = 0;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero1()
    {
        CharacterSelected = 1;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero2()
    {
        CharacterSelected = 2;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero3()
    {
        CharacterSelected = 3;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero4()
    {
        CharacterSelected = 4;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero5()
    {
        CharacterSelected = 5;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero6()
    {
        CharacterSelected = 6;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero7()
    {
        CharacterSelected = 7;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero8()
    {
        CharacterSelected = 8;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero9()
    {
        CharacterSelected = 9;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero10()
    {
        CharacterSelected = 10;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero11()
    {
        CharacterSelected = 11;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero12()
    {
        CharacterSelected = 12;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero13()
    {
        CharacterSelected = 13;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero14()
    {
        CharacterSelected = 14;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero15()
    {
        CharacterSelected = 15;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero16()
    {
        CharacterSelected = 16;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero17()
    {
        CharacterSelected = 17;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero18()
    {
        CharacterSelected = 18;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero19()
    {
        CharacterSelected = 19;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero20()
    {
        CharacterSelected = 20;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero21()
    {
        CharacterSelected = 21;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void Hero22()
    {
        CharacterSelected = 22;
        PlayerPrefs.SetInt("HeroNumber", CharacterSelected);
        Selected.CharacterChosen(CharacterSelected);
    }

    public void AutoDestroy()
    {
        Destroy(gameObject);
    }



}
