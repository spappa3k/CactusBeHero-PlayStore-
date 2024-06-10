using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 newscale;
    private float sizebullet=0;
    public float howMuchIncreaseSize;
    private new Rigidbody2D rigidbody;
    public float speedbullet;
    private bool SizeIncreasing=true;
    // Start is called before the first frame update
   
    void Start()
    {
        howMuchIncreaseSize = (howMuchIncreaseSize / 10000) + 0.005f;
        rigidbody = GetComponent<Rigidbody2D>();
        autoDestroy();
    }

    // Update is called once per frame
    void Update()
    {
        if(SizeIncreasing==true)
        {
            SizeBullet();
        }        

        rigidbody.velocity = new Vector2(-speedbullet * Time.deltaTime*40, rigidbody.velocity.y);
    }

    private void autoDestroy()
    {
        StartCoroutine(countdownDestroy());
    }

    public IEnumerator countdownDestroy()
    {
        
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    
    
    private void SizeBullet()
    {
        StartCoroutine(BulletSize());
    }

    public IEnumerator BulletSize()
    {
        SizeIncreasing = false;

        yield return new WaitForSeconds(0.001f);

        sizebullet = sizebullet + howMuchIncreaseSize;
        newscale = new Vector3(0.85f, 0.85f, 0.85f);
        transform.localScale = Vector3.Lerp(transform.localScale, newscale, Time.deltaTime * 2);
        /* newscale = new Vector3(sizebullet * Time.deltaTime * 60, sizebullet * Time.deltaTime * 60, 0.3f );*/
        /*transform.localScale = newscale;*/
        SizeIncreasing = true;
    }
}
