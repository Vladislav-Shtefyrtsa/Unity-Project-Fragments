using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public Animator circleAnimator;
    public GameObject circle;
    public GameObject mainitems;
    bool ed = true;
    bool press = true;


    private void OnMouseDown()
    {
        if (press == true)
        {
            if (ed == true)
            {
                StartCoroutine(Disabling());
            }
            if (ed == false)
            {
                StartCoroutine(Enabling());
            }
            StartCoroutine(pressonoff());
        }
                            }
    IEnumerator pressonoff(){
        press = false;
        yield return new WaitForSeconds(0.5f);
        press = true;
    }

    IEnumerator Enabling(){
        mainitems.SetActive(true);
        circleAnimator.Play("Transition2DAnimation 1");
        yield return new WaitForSeconds(0.5f);
        circle.SetActive(false);

        ed = true;
    }
    IEnumerator Disabling(){
        circle.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ed = false;
    }
}
