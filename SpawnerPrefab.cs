using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.Security.Cryptography;
using UnityEngine;

public class SpawnerPrefab : MonoBehaviour
{
    public GameObject Sofa;
    public GameObject Fire_ext;
    public GameObject Trash;
    public GameObject Toilet;
    public GameObject Candels;
    public GameObject Chest;
    public GameObject WashingMachine;
    public GameObject Dishwasher;
    public GameObject Table;
    public GameObject Hole;
    public GameObject Armadio;
    public GameObject Umbrella;
    public GameObject Scopa;
    public GameObject Helmet;
    public GameObject Tv;
    public GameObject Ladder;
    public GameObject Barile;
    public GameObject No_Cactus;
    public GameObject Ascia;
    public GameObject Tennis;
    public GameObject Hammer;
    public GameObject Cono;
    public GameObject Wine;
    public GameObject Stone;
    public GameObject Sword;
    public GameObject CarDoor;
    public GameObject Dumbbell;
    public GameObject Vase;
    public GameObject Collect;
    public GameObject Moving;
    public GameObject superPower1;
    public GameObject MovingFast;

    public GameObject IncreaseSpeed;
    public GameObject RepeatingClouds;
    public GameObject Lv2RepeatingClouds;
    public GameObject Lv3RepeatingClouds;
    public GameObject Lv4RepeatingClouds;
    public GameObject PointAdder;
    public GameObject ToxicFirstCount;
    public Camera cameraa;

    private Vector3 spawnpoint;
    private Vector3 Speedspawnpoint;
    private Vector3 spawnpointPower;
    private Vector3 spawnpointCollect;
    private Vector3 cameraposition;
    private Vector3 whereToSpawnClouds;
    private Vector3 spawnFirstClouds;
    public int Howmanyspawn;
    private int i = 0;
    private int counter_i;
    public float slowSpawn;
    public int frequencyCollect;
    private float YRandomPosition;
    public float distanceCollect_Obstacle;
    private int counterup;
    private int counterdown;
    private int counter_movingobstacle;
    public int howManyForMovingObstacle;
    public float amplitude;
    private int random_numbers;
    public float distance_superPower;
    private int counter_power = 0;
    public int allowSpawnPowerEvery;
    public int frequencyPowerSpawn;
    private int random_obstacle;
    private int random_prefab;
    public PlayerController Player;
    public float HowFarStartToSpawn;
    private int LevelClouds=1;
    private int counterForSpeed=0;
    private float x_SpeedUP;
    public int SpeedIncreaseEvery = 0;
    private Vector3 ToxicFirst;

    private int GENERAL_counter=0;






    void Start()
    {
        spawnFirstClouds = new Vector3(122f, -0.5f, 0f);
        Instantiate(RepeatingClouds, spawnFirstClouds, Quaternion.identity);

        Player = GameObject.FindObjectOfType<PlayerController>();
        Moving.GetComponent<Rigidbody2D>();
        spawnpoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        counterup = 0;
        counterdown = 0;


        ToxicFirst = new Vector3(45f, -9.5f, 0f);
        Instantiate(ToxicFirstCount, ToxicFirst, Quaternion.identity);
        




    }

    // Update is called once per frame
    void Update()
    {


        if (Player == null)
        {
            return;
        }

        if ((i < Howmanyspawn) && (spawnpoint.x < Player.transform.position.x + HowFarStartToSpawn))
        {
            i = i + 1;
            spawnSystem();
        }



        /* 
         Moving.velocity = new Vector3(0, -0.3f, 0);
        */
    }

    public void spawnSystem()
    {
        YRandomPosition = Random.Range(-4f, 4f);





        if (counter_movingobstacle == howManyForMovingObstacle)
        {
            random_obstacle = Random.Range(0, 5);

            if (random_obstacle == 1)
            {

                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, amplitude, -2);
                Instantiate(MovingFast, spawnpoint, Quaternion.identity);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);
            }
            else
            {

                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, amplitude, -2);
                Instantiate(Moving, spawnpoint, Quaternion.identity);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);


            }
            counter_movingobstacle = 0;
            counter_power = counter_power + 1;
        }

        if (YRandomPosition >= 0)
        {
            if (counterup < 2)
            {
                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, transform.position.y + YRandomPosition, -2);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);
                random_prefab = Random.Range(0, 31);
                switch (random_prefab)
                {
                    case 0:
                        Instantiate(Vase, spawnpoint, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Dumbbell, spawnpoint, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(CarDoor, spawnpoint, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Sword, spawnpoint, Quaternion.identity);
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Instantiate(Stone, spawnpoint, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(Wine, spawnpoint, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(Cono, spawnpoint, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(Hammer, spawnpoint, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(Tennis, spawnpoint, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(Ascia, spawnpoint, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(No_Cactus, spawnpoint, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(Barile, spawnpoint, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(Ladder, spawnpoint, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(Tv, spawnpoint, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(Helmet, spawnpoint, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(Scopa, spawnpoint, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(Umbrella, spawnpoint, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(Armadio, spawnpoint, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(Hole, spawnpoint, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(Table, spawnpoint, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(Dishwasher, spawnpoint, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(WashingMachine, spawnpoint, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(Chest, spawnpoint, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(Candels, spawnpoint, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(Toilet, spawnpoint, Quaternion.identity);
                        break;
                    case 28:
                        Instantiate(Trash, spawnpoint, Quaternion.identity);
                        break;
                    case 29:
                        Instantiate(Fire_ext, spawnpoint, Quaternion.identity);
                        break;
                    case 30:
                        Instantiate(Sofa, spawnpoint, Quaternion.identity);
                        break;
                }



                counterup = counterup + 1;
                counter_movingobstacle += 1;
                counter_power = counter_power + 1;
                counterForSpeed = counterForSpeed + 1;
                GENERAL_counter++;
            }
            else
            {
                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, transform.position.y - YRandomPosition, -2);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);
                random_prefab = Random.Range(0, 31);

                switch (random_prefab)
                {
                    case 0:
                        Instantiate(Vase, spawnpoint, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Dumbbell, spawnpoint, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(CarDoor, spawnpoint, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Sword, spawnpoint, Quaternion.identity);
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Instantiate(Stone, spawnpoint, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(Wine, spawnpoint, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(Cono, spawnpoint, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(Hammer, spawnpoint, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(Tennis, spawnpoint, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(Ascia, spawnpoint, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(No_Cactus, spawnpoint, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(Barile, spawnpoint, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(Ladder, spawnpoint, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(Tv, spawnpoint, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(Helmet, spawnpoint, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(Scopa, spawnpoint, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(Umbrella, spawnpoint, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(Armadio, spawnpoint, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(Hole, spawnpoint, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(Table, spawnpoint, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(Dishwasher, spawnpoint, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(WashingMachine, spawnpoint, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(Chest, spawnpoint, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(Candels, spawnpoint, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(Toilet, spawnpoint, Quaternion.identity);
                        break;
                    case 28:
                        Instantiate(Trash, spawnpoint, Quaternion.identity);
                        break;
                    case 29:
                        Instantiate(Fire_ext, spawnpoint, Quaternion.identity);
                        break;
                    case 30:
                        Instantiate(Sofa, spawnpoint, Quaternion.identity);
                        break;
                }


                counterup = 0;
                counter_movingobstacle += 1;
                counter_power = counter_power + 1;
                counterForSpeed = counterForSpeed + 1;
                GENERAL_counter++;
            }
        }
        if (YRandomPosition < 0)
        {
            if (counterdown < 2)
            {
                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, transform.position.y + YRandomPosition, -2);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);
                random_prefab = Random.Range(0, 31);
                switch (random_prefab)
                {
                    case 0:
                        Instantiate(Vase, spawnpoint, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Dumbbell, spawnpoint, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(CarDoor, spawnpoint, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Sword, spawnpoint, Quaternion.identity);
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Instantiate(Stone, spawnpoint, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(Wine, spawnpoint, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(Cono, spawnpoint, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(Hammer, spawnpoint, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(Tennis, spawnpoint, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(Ascia, spawnpoint, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(No_Cactus, spawnpoint, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(Barile, spawnpoint, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(Ladder, spawnpoint, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(Tv, spawnpoint, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(Helmet, spawnpoint, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(Scopa, spawnpoint, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(Umbrella, spawnpoint, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(Armadio, spawnpoint, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(Hole, spawnpoint, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(Table, spawnpoint, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(Dishwasher, spawnpoint, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(WashingMachine, spawnpoint, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(Chest, spawnpoint, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(Candels, spawnpoint, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(Toilet, spawnpoint, Quaternion.identity);
                        break;
                    case 28:
                        Instantiate(Trash, spawnpoint, Quaternion.identity);
                        break;
                    case 29:
                        Instantiate(Fire_ext, spawnpoint, Quaternion.identity);
                        break;
                    case 30:
                        Instantiate(Sofa, spawnpoint, Quaternion.identity);
                        break;
                }



                counterdown = counterdown + 1;
                counter_movingobstacle += 1;
                counter_power = counter_power + 1;
                counterForSpeed = counterForSpeed + 1;
                GENERAL_counter++;
            }
            else
            {
                spawnpoint = new Vector3(spawnpoint.x + slowSpawn, transform.position.y - YRandomPosition, -2);
                Instantiate(PointAdder, spawnpoint, Quaternion.identity);
                random_prefab = Random.Range(0, 31);

                switch (random_prefab)
                {
                    case 0:
                        Instantiate(Vase, spawnpoint, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Dumbbell, spawnpoint, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(CarDoor, spawnpoint, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Sword, spawnpoint, Quaternion.identity);
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        Instantiate(Stone, spawnpoint, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(Wine, spawnpoint, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(Cono, spawnpoint, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(Hammer, spawnpoint, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(Tennis, spawnpoint, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(Ascia, spawnpoint, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(No_Cactus, spawnpoint, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(Barile, spawnpoint, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(Ladder, spawnpoint, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(Tv, spawnpoint, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(Helmet, spawnpoint, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(Scopa, spawnpoint, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(Umbrella, spawnpoint, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(Armadio, spawnpoint, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(Hole, spawnpoint, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(Table, spawnpoint, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(Dishwasher, spawnpoint, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(WashingMachine, spawnpoint, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(Chest, spawnpoint, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(Candels, spawnpoint, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(Toilet, spawnpoint, Quaternion.identity);
                        break;
                    case 28:
                        Instantiate(Trash, spawnpoint, Quaternion.identity);
                        break;
                    case 29:
                        Instantiate(Fire_ext, spawnpoint, Quaternion.identity);
                        break;
                    case 30:
                        Instantiate(Sofa, spawnpoint, Quaternion.identity);
                        break;
                }


                counterdown = 0;
                counter_movingobstacle += 1;
                counter_power = counter_power + 1;
                counterForSpeed = counterForSpeed + 1;
                GENERAL_counter++;
            }





        }

        random_numbers = Random.Range(1, 12 - frequencyPowerSpawn);

        if ((random_prefab == 2) || (random_prefab == 15) || (random_prefab == 20) || (random_prefab == 22) || (random_prefab == 30))
        {
            if ((random_numbers == 1) && ((spawnpoint.y > 0.8f) && (spawnpoint.y < 1.2f)) && (counter_power >= allowSpawnPowerEvery))
            {
                spawnpointPower = new Vector3(spawnpoint.x, spawnpoint.y + distance_superPower + 1, spawnpoint.z);
                Instantiate(superPower1, spawnpointPower, Quaternion.identity);
                counter_power = 0;
            }

        }
        else
        {
            if ((random_numbers == 1) && ((spawnpoint.y > 1.5f) && (spawnpoint.y < 1.9f)) && (counter_power >= allowSpawnPowerEvery))
            {
                spawnpointPower = new Vector3(spawnpoint.x, spawnpoint.y + distance_superPower, spawnpoint.z);
                Instantiate(superPower1, spawnpointPower, Quaternion.identity);
                counter_power = 0;

            }
        }

        random_numbers = Random.Range(1, 12 - frequencyPowerSpawn);

        if ((random_prefab == 2) || (random_prefab == 15) || (random_prefab == 20) || (random_prefab == 22) || (random_prefab == 30))
        {
            if ((random_numbers == 1) && ((spawnpoint.y < -1f) && (spawnpoint.y > -1.8f)) && (counter_power >= allowSpawnPowerEvery))
            {
                spawnpointPower = new Vector3(spawnpoint.x, spawnpoint.y - distance_superPower - 1, spawnpoint.z);
                Instantiate(superPower1, spawnpointPower, Quaternion.identity);
                counter_power = 0;
            }

        }
        else
        {
            if ((random_numbers == 1) && ((spawnpoint.y < -1.80f) && (spawnpoint.y > -2.2f)) && (counter_power >= allowSpawnPowerEvery))
            {
                spawnpointPower = new Vector3(spawnpoint.x, spawnpoint.y - distance_superPower, spawnpoint.z);
                Instantiate(superPower1, spawnpointPower, Quaternion.identity);
                counter_power = 0;
            }


            counter_i = (Random.Range(1, 11 - frequencyCollect));
            if (counter_i == 1)
            {
                if (spawnpoint.y < 0f)
                {
                    spawnpointCollect = new Vector3(spawnpoint.x, spawnpoint.y + distanceCollect_Obstacle, transform.position.z - 2);
                    Instantiate(Collect, spawnpointCollect, Quaternion.identity);
                }
                if (spawnpoint.y > 0f)
                {
                    spawnpointCollect = new Vector3(spawnpoint.x, spawnpoint.y - distanceCollect_Obstacle, transform.position.z - 2);
                    Instantiate(Collect, spawnpointCollect, Quaternion.identity);
                }
            }


        }



        Speed();
       
            /*   if(counterForSpeed == SpeedIncreaseEvery)
               {
                   x_SpeedUP = spawnpoint.x+4;
                   Speedspawnpoint = new Vector3(x_SpeedUP, 0f,0f);
                   Instantiate(IncreaseSpeed, Speedspawnpoint, Quaternion.identity);
                   counterForSpeed = 0;
               }
               */

        }
        public void spawnclouds()
        {
            LevelClouds++;
            whereToSpawnClouds = new Vector3(Player.transform.position.x + 193, -0.5f, Player.transform.position.z);

        if (LevelClouds == 1)
        {
            Instantiate(RepeatingClouds, whereToSpawnClouds, Quaternion.identity);
        }
        if (LevelClouds == 2)
        {
            Instantiate(Lv2RepeatingClouds, whereToSpawnClouds, Quaternion.identity);
        }
        if (LevelClouds == 3)
        {
            Instantiate(Lv3RepeatingClouds, whereToSpawnClouds, Quaternion.identity);
        }
        if (LevelClouds >= 4)
        {
            Instantiate(Lv4RepeatingClouds, whereToSpawnClouds, Quaternion.identity);
        }
    }



    public void Speed()
    {
        if (GENERAL_counter == 3)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 6)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 11)
        {
            SpeedUpProcess();
        }
        
        if (GENERAL_counter == 17)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 25)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 34)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 44)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 55)
        {
            SpeedUpProcess();
        }


        if (GENERAL_counter == 66)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 78)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 90)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 105)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 120)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 135)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 152)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 167)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 185)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 203)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 222)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 242)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 263)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 284)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 309)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 335)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 360)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 385)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 420)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 457)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 485)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 525)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 570)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 620)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 675)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 740)
        {
            SpeedUpProcess();
        }

        if (GENERAL_counter == 800)
        {
            SpeedUpProcess();
        }
    }

    public void SpeedUpProcess()
    {
        x_SpeedUP = spawnpoint.x + 3;
        Speedspawnpoint = new Vector3(x_SpeedUP, 0f, 0f);
        Instantiate(IncreaseSpeed, Speedspawnpoint, Quaternion.identity);
    }


    }
