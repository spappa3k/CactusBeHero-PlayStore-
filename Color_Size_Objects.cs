using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Size_Objects : MonoBehaviour
{

    public Sprite Orange;
    public Sprite Blue;
    public Sprite Green;
    public Sprite Red;
    public Sprite White;
    public Sprite Purple;
    public Sprite Yellow;

    public float Scale_Orange;
    public float Scale_Blue;
    public float Scale_Green;
    public float Scale_Red;
    public float Scale_White;
    public float Scale_Purple;
    public float Scale_Yellow;

    private SpriteRenderer ActualSprite;
    private int Random_Selector;
    private Vector3 Stone_Scale;
        
    // Start is called before the first frame update
    void Start()
    {
        ActualSprite = GetComponent<SpriteRenderer>();
        Random_Selector = Random.Range(0, 10);
        Stone_Scale.z = 0.3f;

        switch(Random_Selector)
        {
            case 7:
            case 8:
            case 9:
            case 0: ActualSprite.sprite = Orange;
                Stone_Scale.x = +Scale_Orange;
                Stone_Scale.y = +Scale_Orange;
                break;

            case 1:
                ActualSprite.sprite = Blue;
                Stone_Scale.x = +Scale_Blue;
                Stone_Scale.y = +Scale_Blue;
                break;
            
            case 2:
                ActualSprite.sprite = Green;
                Stone_Scale.x = +Scale_Green;
                Stone_Scale.y = +Scale_Green;
                break;
            
            case 3:
                ActualSprite.sprite = Red;
                Stone_Scale.x = +Scale_Red;
                Stone_Scale.y = +Scale_Red;
                break;
            
            case 4:
                ActualSprite.sprite = Purple;
                Stone_Scale.x = +Scale_Purple;
                Stone_Scale.y = +Scale_Purple;
                break;
            
            case 5:
                ActualSprite.sprite = White;
                Stone_Scale.x = +Scale_White;
                Stone_Scale.y = +Scale_White;
                break;
            
            case 6:
                ActualSprite.sprite = Yellow;
                Stone_Scale.x = +Scale_Yellow;
                Stone_Scale.y = +Scale_Yellow;
                break;
        }
        transform.localScale= Stone_Scale;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
