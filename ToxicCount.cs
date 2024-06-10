using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ToxicCount : MonoBehaviour
{

    public int ActualNumber;
    public GameObject White;
    public GameObject Yellow;
    public GameObject Green;
    public GameObject Purple;

    private AudioManager Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GameObject.FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("Conto Alert: " + ActualNumber);*/
    }


    public void First(int Firstnum)
    {
        ActualNumber = ActualNumber + Firstnum;
        TimeToSpawn();
    }


    
    public void KeepCountAlert(int num)
    {
        ActualNumber = ActualNumber + num;

        TimeToSpawn();

        

       
    }

    public void TimeToSpawn()
    {
        if (ActualNumber == 1)

        {
            Instantiate(White, transform.position, Quaternion.identity);
            Audio.Alarm();
        }

        if (ActualNumber == 2)

        {
            Instantiate(Yellow, transform.position, Quaternion.identity);
            Audio.Alarm();
        }

        if (ActualNumber == 3)

        {
            Instantiate(Green, transform.position, Quaternion.identity);
            Audio.Alarm();
        }

        if (ActualNumber == 4)

        {
            Instantiate(Purple, transform.position, Quaternion.identity);
            Audio.Alarm();
        }
    }

    
}
