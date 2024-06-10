using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Crazyenemy : MonoBehaviour
{
    public Animator Anim;
    public CameraP camera_follow;
    private Vector3 enemyposition;
    private Rigidbody2D rigidbodyC;
    public PlayerController Player;
    private int random_number;
    private bool awake = false;
    public bool returnToPosition = false;
    private float startingx;
    public int canshoot = 1;
    public GameObject Bullet;
    public Transform FirePoint;
    public float speedUpAndDown;
    public int howLongEnemyStays;
    private int random_number2;
    private bool readyToShoot=false;
    public float whereenemystops;
    private int bulletsShot=0;
    private float increase = 0.1f;
    private int randomShoots;

    PrintMonkeyShoots PrintShoots;

    private AudioManager Audio;



    private void Awake()
    {
        PrintShoots = FindObjectOfType<PrintMonkeyShoots>();
        camera_follow = GameObject.FindObjectOfType<CameraP>();
        Player = GameObject.FindObjectOfType<PlayerController>();
        
        counting();
    }


    void Start()
    {
        rigidbodyC = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        startingx = transform.position.x;
        Audio = FindObjectOfType<AudioManager>();

        randomShoots = Random.Range(2, 5);
        Debug.Log("Shoots :" + randomShoots);
        PrintShoots.printShoots(randomShoots);
        Audio.EnemyComing();
    }


    // Update is called once per frame
    void Update()
    {
       

      


        if (Player == null)
        {
            return;
        }









        if (returnToPosition == true)
        {
            increase = increase + 0.1f;
            rigidbodyC.velocity = new Vector2(0, 0);
            enemyposition = new Vector3(Player.transform.position.x + whereenemystops+increase, transform.position.y, -5f);
            transform.position = enemyposition;

            /*rigidbodyC.velocity = new Vector2(+10.5f * Time.deltaTime * 40, 0);*/
            canshoot = 0;
            readyToShoot = false;
        }




        if ((transform.position.x > Player.transform.position.x + 1)&&(transform.position.x < Player.transform.position.x + whereenemystops)&& (returnToPosition == false))
           {



                readyToShoot = true;

                enemyposition = new Vector3(Player.transform.position.x + whereenemystops, transform.position.y, -5f);
                transform.position = enemyposition;
                random_number = Random.Range(0, 40);

                if (random_number == 1)
                {
                    rigidbodyC.velocity = new Vector2(0, -speedUpAndDown * Time.deltaTime * 40);
                }

                if (random_number == 2)
                {
                    rigidbodyC.velocity = new Vector2(0, +speedUpAndDown * Time.deltaTime * 40);
                }

                if (transform.position.y >= 3.50)
                {
                    rigidbodyC.velocity = new Vector2(0, -speedUpAndDown * Time.deltaTime * 40);
                }

                if (transform.position.y <= -3.50)
                {
                    rigidbodyC.velocity = new Vector2(0, +speedUpAndDown * Time.deltaTime * 40);

                }

            }
       
        if (readyToShoot == true)
        {
            if (Player == null)
            {
                return;
            }
            shoot();
        }
    }




    public void counting()
    {
        StartCoroutine(countDown_enemy());
    }

   

  
       

   

    public IEnumerator countDown_enemy()
    {
        
        returnToPosition = false;
   
        yield return new WaitForSeconds(howLongEnemyStays);
        returnToPosition = true;
        StartCoroutine(DestroyEnemy());

    }

    public void shoot()
    {
        if ((canshoot == 1)&&(bulletsShot<randomShoots))
        {
            
            StartCoroutine(countdown_shooting());
        }
       /* if (canShoot == 1)
        {

            canShoot = 0;
        }*/

    }

    public IEnumerator countdown_shooting()
    {


        
        Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        Audio.EnemyShoot();
        bulletsShot = bulletsShot + 1;
        canshoot = 0;


        if (randomShoots == 2)
        {
            yield return new WaitForSeconds(1.8f);
        }

        if (randomShoots == 3)
        {
            yield return new WaitForSeconds(1.3f);
        }

        if (randomShoots == 4)
        {
            yield return new WaitForSeconds(1f);
        }

        canshoot = 1;
        


    }


    public IEnumerator DestroyEnemy()
    {

      /*  PrintShoots.Ends();*/
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
