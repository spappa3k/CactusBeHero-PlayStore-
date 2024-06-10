using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FixScreenHeroChoose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    
        if ((Screen.width > 1900) && (Screen.height > 1300))
        {
            transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        }
    }


}