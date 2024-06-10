using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

/*using System.Runtime.Hosting;*/
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update


    /*public Animator anim;*/
    private new Rigidbody2D rigidbody;
    public float speedJump = 0f;
    private float movement = 1f;
    public float flyspeed = 0f;
    public GameObject Boom;
    public GameObject Pfff;
    private float startingpositionx;
    private float startingpositiony;
    private float startingpositionz;
    public RaceLights TrafficLights;
    public LevelManager gameManager;
    public Light_Character C_Light;
    public CollectPower power;
    public RockMovement rock;
    public SpawnerPrefab spawn;
    public Danger_area DangerA;
    private AudioManager Audio;
    public Anim anim;
    public new CameraP camera;
    public float speedTouchLimit;
    public bool Immortal = false;
    private float howLongPower;
    private float totalSpeed;
    private float add_speed=0.0f;
    private bool canincreasespeed=false;
    public float startingJump;
    private bool hole_taken=false;
    private Vector3 temp;
    private bool isDead=false;
    public bool isJumping = false;
    private new Vector3 ActualPosition;
    private new Vector3 newVelocity;
    public bool C_AboveForLightOn=false;
    public float YToActivateTorch;
    SpeedCounter SpeedCount;
    JumpBehind JumpB;
   
    
  /*  public GameObject JumpB;*/
    public ParticleSystem Smoke;
    public float actualPosition;

    public Text Speed;
    private float speedF;
    public float Character_Speed;
    public float Kmh_Character_Speed;
    private bool Launched = false;
















    void Start()
    {
        Application.targetFrameRate = 60;
       /* QualitySettings.vSyncCount = 0;*/

        if (gameObject == null)
        {
            return;
        }

        rigidbody = GetComponent<Rigidbody2D>();
        startingpositionx = transform.position.x;
        startingpositiony = transform.position.y;
        startingpositionz = transform.position.z;
        gameManager = FindObjectOfType<LevelManager>();
        camera = FindObjectOfType<CameraP>();
        rock = FindObjectOfType<RockMovement>();
        C_Light = FindObjectOfType<Light_Character>();
        spawn = FindObjectOfType<SpawnerPrefab>();
        anim = FindObjectOfType<Anim>();
        DangerA = FindObjectOfType<Danger_area>();
        Audio = FindObjectOfType<AudioManager>();
        SpeedCount = FindObjectOfType<SpeedCounter>();
        JumpB = FindObjectOfType<JumpBehind>();
       
        GetRealSpeed();
        

    }

    // Update is called once per frame
    void Update()
    {
       

        speedF = rigidbody.velocity.x*8;

        SpeedCount.GetSpeed(speedF);

       /* Speed.text = speedF + " Km/h";*/


        GiveX();
        


        if (isDead == true)
            {
                Character_Dies();
            }

            if (gameObject == null)
            {
                return;
            }
          
            


            if (canincreasespeed == false)
            {
            transform.position = new Vector3(startingpositionx, startingpositiony-0.480f, startingpositionz);
            rigidbody.velocity = new Vector2(0, 0);
            }

        if (canincreasespeed == true)
        {

            if ((rigidbody.velocity.x <= 3f)&&(Launched == false))
            {

          
                add_speed = (add_speed + 7f);
                totalSpeed = add_speed + movement * flyspeed;
                rigidbody.velocity = new Vector2((totalSpeed) * Time.deltaTime, rigidbody.velocity.y);
                
            }
            else if((rigidbody.velocity.x > 3f))
            {
                Launched = true;
                rigidbody.velocity = new Vector2(Character_Speed/* * Time.deltaTime*5*/, rigidbody.velocity.y);
            }
            
           
        }
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if((other.tag=="obstacle")&&(Immortal==false))
        {
           
            rigidbody.velocity = new Vector2(0, 0);
            Character_Dies();


        }
        if ((other.tag == "Start") && (Immortal == false))
        {
            
            rigidbody.velocity = new Vector2(6, startingJump);
        }
        if ((other.tag == "Hole") && (Immortal == false))
        {

            hole_taken = true;
           
            
            Character_Dies();
            gameManager.EndLevel(isDead);
            
        }
        if (other.tag == "SpawnNewClouds")
        {

            spawn.spawnclouds();

        }

        if (other.tag == "IncreaseSpeed")
        {

            Kmh_Character_Speed= Kmh_Character_Speed +1;
           GetRealSpeed();
        }





    }





    public void takehowLongPower(float howLPower)
    {
        howLongPower = howLPower;
    }


   public void gamehasstarted(bool gamestarted)
    {
        
        canincreasespeed = gamestarted;
       
    }

    
    public void stopjump()
    {
        StartCoroutine(nomorejump());
    }

    public IEnumerator nomorejump()
    {
        
        yield return new WaitForSeconds(0.15f);
        isJumping = false;
        anim.Jump(isJumping);
    }

    public void check_Danger(bool Dies)
    {
        isDead = Dies;
    }

    public void Character_Dies()
    {
        JumpB.DestroyAll();
        ActualPosition = new Vector3(transform.position.x-1,transform.position.y-3.5f,transform.position.z);
        
        if (hole_taken == true)
        {
            ActualPosition = new Vector3(transform.position.x+1, transform.position.y - 3.5f, transform.position.z);
            Instantiate(Pfff, ActualPosition, Quaternion.identity);
        }
        else
        {
            ActualPosition = new Vector3(transform.position.x - 1, transform.position.y - 3.5f, transform.position.z);
            Instantiate(Boom, ActualPosition, Quaternion.identity);
            Audio.Boom();
        }

        Destroy(gameObject);
        
        gameManager.EndLevel(isDead);
    }

   

    public void Jump()
    {

       
        if (canincreasespeed == true)/*&&(isJumping==false)) */{ 
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, movement * speedJump);
            Audio.Jump();
            isJumping = true;
            CreateSmoke();
            anim.Jump(isJumping);

            /// stopjump();
        }
    
         
        else
          {
           
           
           isJumping = false;
           /*anim.Jump(isJumping);*/
                        }

    }


    void CreateSmoke()
    {
        Smoke.Play();
    }

 
    public void GiveX()
    {
        actualPosition = transform.position.x;
        DangerA.take_x_Player(actualPosition);

    }

    
    public void GetRealSpeed()
    {
        Character_Speed = Kmh_Character_Speed / 8;
    }


}
