using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraP : MonoBehaviour
{

    /*public GameObject Player;*/
    private Vector3 PlayerPosition;
    private float yplayer;
    public float positionxplayer;
    public float horizontalFoV = 90.0f;
    PlayerController Player1;

    Camera _camera;




    public bool maintainWidth = true;
    float defaultWidth;
    float defaultHeight;
    [Range(-1, 1)]
    public int adaptposition;

    Vector3 CameraPos;

    // Start is called before the first frame update
    void Start()
    {
        CameraPos = Camera.main.transform.position;
        Player1 = FindObjectOfType<PlayerController>();
        defaultHeight = 6.0280f;/*Camera.main.orthographicSize;*/
        defaultWidth = 10.7265f;/*Camera.main.orthographicSize * Camera.main.aspect;*/

       
    }

    // Update is called once per frame
    void Update()
    {
        
        moveCamera();

        re_size();

    }

    public void moveCamera()
    {
        if (Player1 == null)
        {
            return;
        }
        PlayerPosition = new Vector3(Player1.transform.position.x-positionxplayer+10, adaptposition * (defaultHeight - Camera.main.orthographicSize)-0.40f, transform.position.z);

        transform.position = PlayerPosition;
    }

    public void re_size ()
    {
        if (maintainWidth == true)
        {


            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;

            /*  Camera.main.transform.position = new Vector3(CameraPos.x, adaptposition * (defaultHeight - Camera.main.orthographicSize), CameraPos.z);*/
        }
     
    }


    public void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }



 
}

