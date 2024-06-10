using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Attributes : MonoBehaviour
{
    public float rotation_speed;
    private int secondsToWait;
    private bool CanRotate=false;
    private float random_speedup;
    public PlayerController Player;
    private bool RotateFromStart = false;
    private int WhichWayRotate;
    private int randomForRotation;
    private float starting_rotation;
    private float whenAutoDestroy;
    public bool one_direction=false;
    public bool NoObstacle = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            return;
        }
        whenAutoDestroy = 17.3f;

        if (NoObstacle == false)
        {
            randomForRotation = Random.Range(0, 180);
            transform.rotation = Quaternion.Euler(0, 0, randomForRotation);
            randomForRotation = Random.Range(1, 5);
            if (transform.position.x < Player.transform.position.x + 20)
            {
                RotateFromStart = true;
            }
            else
            {
                countdown_rotation();
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NoObstacle == false)
        {

            if ((CanRotate == true) || (RotateFromStart == true))
            {
                rotate();
            }
            if (Player == null)
            {
                return;
            }
            if (Player.transform.position.x > transform.position.x + whenAutoDestroy+5)
            {
                Destroy(gameObject);
            }
        }

        if(NoObstacle == true)
        {
            if (Player == null)
            {
                return;
            }
            if (Player.transform.position.x > transform.position.x + whenAutoDestroy+5)
            {
                Destroy(gameObject);
            }
        }
    }

    public void countdown_rotation()
    {
        StartCoroutine(CountDown());
    }

    public IEnumerator CountDown()
    {
        secondsToWait = Random.Range(0, 2);
        yield return new WaitForSeconds(secondsToWait);
        CanRotate = true;
        
    }
    public void rotate()
    {
        

        if (randomForRotation<3)
        {
            WhichWayRotate = 1;
        }
        if ((randomForRotation >= 3)&&(one_direction==false))
        {
            WhichWayRotate = -1;
        }
        else if ((randomForRotation >= 3)&&(one_direction==true))
        {
            WhichWayRotate = 1;
        }
        transform.Rotate(Vector3.forward * rotation_speed*10*WhichWayRotate* Time.deltaTime);
    }


    private void Awake()
    {
       
        Player = GameObject.FindObjectOfType<PlayerController>();
    }
}
