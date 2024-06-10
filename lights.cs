using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
  [SerializeField]
    UnityEngine.Experimental.Rendering.Universal.Light2D m_light2D = null;
    public bool lightOn;
    public bool infinite;
    private bool PauseInfiniteLoop=false;
    private bool canStartInfinite;

    void Awake()
    {
        if (infinite == false)
        {
           lightsOn();
        }
        else
        {
            
            StartCoroutine(crashUfo());
        }

    }


    void Update()
    {


        if ((PauseInfiniteLoop == false)&&(infinite==true)&&(canStartInfinite==true))
        {
            lightsOn();
        }
    }


    public IEnumerator crashUfo()
    {
        m_light2D.enabled = true;
        yield return new WaitForSeconds(2.5f);
        canStartInfinite = true;

    }



    public void lightsOn() { 

    StartCoroutine(Lightswork());
    }

    public IEnumerator Lightswork()
    {
        if (infinite == true)
        {
            if (lightOn == false)
            {
                m_light2D.enabled = true;
                PauseInfiniteLoop = true;
                yield return new WaitForSeconds(1f);
                PauseInfiniteLoop = false;
                m_light2D.enabled = false;
                lightOn = true;
            }
            if (lightOn == true)
            {
                m_light2D.enabled = false;
                PauseInfiniteLoop = true;
                yield return new WaitForSeconds(1f);
                PauseInfiniteLoop = false;
                m_light2D.enabled = true;
                lightOn = false;
            }
        }
        else
        {


            if (lightOn == false)
            {
                m_light2D.enabled = true;
                PauseInfiniteLoop = true;
                yield return new WaitForSeconds(0.3f);
                PauseInfiniteLoop = false;
                m_light2D.enabled = false;
                lightOn = true;
            }
            if (lightOn == true)
            {
                m_light2D.enabled = false;
                PauseInfiniteLoop = true;
                yield return new WaitForSeconds(0.3f);
                PauseInfiniteLoop = false;
                m_light2D.enabled = true;
                lightOn = false;
            }

        }
        }
    }
