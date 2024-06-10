using System;
using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{

    
    public GameObject[] Heroes;

    Equip EquipedYes;
    public int PlayerNumber;
   


    void Awake()
    {

        

        
        EquipedYes = FindObjectOfType<Equip>();
        PlayerNumber = EquipedYes.CharacterSelected;



        switch (PlayerNumber)
        {
            case 0:
                Instantiate(Heroes[0], transform.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(Heroes[1], transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(Heroes[2], transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(Heroes[3], transform.position, Quaternion.identity);
                break;
            case 4:
                Instantiate(Heroes[4], transform.position, Quaternion.identity);
                break;
            case 5:
                Instantiate(Heroes[5], transform.position, Quaternion.identity);
                break;
            case 6:
                Instantiate(Heroes[6], transform.position, Quaternion.identity);
                break;
            case 7:
                Instantiate(Heroes[7], transform.position, Quaternion.identity);
                break;
            case 8:
                Instantiate(Heroes[8], transform.position, Quaternion.identity);
                break;
            case 9:
                Instantiate(Heroes[9], transform.position, Quaternion.identity);
                break;
            case 10:
                Instantiate(Heroes[10], transform.position, Quaternion.identity);
                break;
            case 11:
                Instantiate(Heroes[11], transform.position, Quaternion.identity);
                break;
            case 12:
                Instantiate(Heroes[12], transform.position, Quaternion.identity);
                break;
            case 13:
                Instantiate(Heroes[13], transform.position, Quaternion.identity);
                break;
            case 14:
                Instantiate(Heroes[14], transform.position, Quaternion.identity);
                break;
            case 15:
                Instantiate(Heroes[15], transform.position, Quaternion.identity);
                break;
            case 16:
                Instantiate(Heroes[16], transform.position, Quaternion.identity);
                break;
            case 17:
                Instantiate(Heroes[17], transform.position, Quaternion.identity);
                break;
            case 18:
                Instantiate(Heroes[18], transform.position, Quaternion.identity);
                break;
            case 19:
                Instantiate(Heroes[19], transform.position, Quaternion.identity);
                break;
            case 20:
                Instantiate(Heroes[20], transform.position, Quaternion.identity);
                break;
            case 21:
                Instantiate(Heroes[21], transform.position, Quaternion.identity);
                break;
            case 22:
                Instantiate(Heroes[22], transform.position, Quaternion.identity);
                break;
        }
       

    }


   




  

}
