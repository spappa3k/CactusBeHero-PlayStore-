using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CameraScreenResolution : MonoBehaviour
{



    public bool maintainWidth = true;
    public bool maintainHeight = true;
    float defaultWidth;
    float defaultHeight;
    [Range(-1,1)]
    public int adaptposition;

    Vector3 CameraPos;
   
    // Start is called before the first frame update
    void Start()
    {
        CameraPos = Camera.main.transform.position;

        defaultHeight =6.0280f;/* Camera.main.orthographicSize;*/
        defaultWidth = 10.7265f; /*Camera.main.orthographicSize * Camera.main.aspect;*/
        Debug.Log("altezza= " + defaultHeight + " larghezza= " + defaultHeight);

    }

    // Update is called once per frame
    void Update()
    {

    if(maintainWidth == true)
        {


            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;

            Camera.main.transform.position = new Vector3(CameraPos.x, adaptposition * (defaultHeight - Camera.main.orthographicSize)-0.40f,CameraPos.z);
        }
        if (maintainHeight== true)
        {


            Camera.main.orthographicSize = defaultHeight / Camera.main.aspect;

            Camera.main.transform.position = new Vector3(adaptposition * (defaultWidth - Camera.main.orthographicSize),CameraPos.y, CameraPos.z);
        }
    }
}
