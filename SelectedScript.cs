using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedScript : MonoBehaviour
{

    public GameObject[] HeroeSelected;
    private int i=0;
    private int Size = 22;
    public int numberOfHero=0;
    // Start is called before the first frame update






    public void CharacterChosen(int selected)
    {
        numberOfHero = selected;



        switch (numberOfHero)
        {
            case 0:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[0].gameObject.SetActive(true);
                break;

            case 1:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[1].gameObject.SetActive(true);
                break;

            case 2:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[2].gameObject.SetActive(true);
                break;

            case 3:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[3].gameObject.SetActive(true);
                break;

            case 4:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[4].gameObject.SetActive(true);
                break;

            case 5:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[5].gameObject.SetActive(true);
                break;

            case 6:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[6].gameObject.SetActive(true);
                break;

            case 7:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[7].gameObject.SetActive(true);
                break;

            case 8:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[8].gameObject.SetActive(true);
                break;

            case 9:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[9].gameObject.SetActive(true);
                break;

            case 10:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[10].gameObject.SetActive(true);
                break;

            case 11:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[11].gameObject.SetActive(true);
                break;

            case 12:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[12].gameObject.SetActive(true);
                break;

            case 13:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[13].gameObject.SetActive(true);
                break;

            case 14:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[14].gameObject.SetActive(true);
                break;

            case 15:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[15].gameObject.SetActive(true);
                break;

            case 16:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[16].gameObject.SetActive(true);
                break;

            case 17:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[17].gameObject.SetActive(true);
                break;

            case 18:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[18].gameObject.SetActive(true);
                break;

            case 19:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[19].gameObject.SetActive(true);
                break;

            case 20:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[20].gameObject.SetActive(true);
                break;

            case 21:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[21].gameObject.SetActive(true);
                break;

            case 22:

                for (i = 0; i < Size + 1; i++)
                {
                    HeroeSelected[i].gameObject.SetActive(false);
                }

                HeroeSelected[22].gameObject.SetActive(true);
                break;

            

        }

    }
}
