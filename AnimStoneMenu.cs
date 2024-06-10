using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStoneMenu : MonoBehaviour
{

    public GameObject Anim1;
    public GameObject Anim2;
    public GameObject Anim3;
    public GameObject Anim4;
    public GameObject Anim5;
    public GameObject Anim6;
    private float randomTime;
    private int randomAnim;
    private bool canShoot=false;
    // Start is called before the first frame update
    void Awake()
    {
        
        StartCoroutine(shootStoneFirstTime());
    }

    // Update is called once per frame
    void Update()
    {
        if(canShoot)
        {
            StartCoroutine(shootStone());
        }
    }


    public IEnumerator shootStone()
    {
        canShoot = false;

        randomAnim = Random.Range(1, 7);

        switch(randomAnim)
        {

            case 1:
                Anim1.gameObject.SetActive(true); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 2:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(true); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 3:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(true); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 4:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(true); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 5:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(true); Anim6.gameObject.SetActive(false);
                break;
            case 6:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(true);
                break;


        }


        randomTime = Random.Range(5, 25);
        yield return new WaitForSeconds(randomTime);
        canShoot = true;

    }




    public IEnumerator shootStoneFirstTime()
    {

        canShoot = false;

        

        randomTime = Random.Range(5, 25);

        yield return new WaitForSeconds(randomTime);

        randomAnim = Random.Range(1, 7);

        switch (randomAnim)
        {

            case 1:
                Anim1.gameObject.SetActive(true); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 2:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(true); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 3:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(true); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 4:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(true); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(false);
                break;
            case 5:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(true); Anim6.gameObject.SetActive(false);
                break;
            case 6:
                Anim1.gameObject.SetActive(false); Anim2.gameObject.SetActive(false); Anim3.gameObject.SetActive(false); Anim4.gameObject.SetActive(false); Anim5.gameObject.SetActive(false); Anim6.gameObject.SetActive(true);
                break;


        }



        canShoot = true;


    }
}
