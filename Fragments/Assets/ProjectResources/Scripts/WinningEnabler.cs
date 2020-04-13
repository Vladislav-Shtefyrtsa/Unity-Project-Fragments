using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningEnabler : MonoBehaviour
{

    GameObject one,two,three,four,five,six,seven,eight,nine;
    int y = 0;
    bool pex = false;
    bool pef = true;
    Animator gh;
    public AudioSource GH17;

    private void OnEnable()
    {
        StartCoroutine(ur());
        gh = this.GetComponent<Animator>();
        pef = true;
        y = 0;
    }

    IEnumerator ur(){
        yield return new WaitForSeconds(5);
        pex = true;
    }
    private void Update()
    {
        if (pef == true)
        {
            Sz();
        }
    }

    void Sz()
    {
        if (pex == true)
        {
            one = GameObject.Find("Quad" + "1");
            two = GameObject.Find("Quad" + "2");
            three = GameObject.Find("Quad" + "3");
            four = GameObject.Find("Quad" + "4");
            five = GameObject.Find("Quad" + "5");
            six = GameObject.Find("Quad" + "6");
            seven = GameObject.Find("Quad" + "7");
            eight = GameObject.Find("Quad" + "8");
            nine = GameObject.Find("Quad" + "9");
            Checker();
            if (y == 1)
            {
                pef = false;
                if (PlayerPrefs.GetString("UnraveledPuzzles").Contains(this.name) == false)
                {
                    PlayerPrefs.SetString("UnraveledPuzzles", PlayerPrefs.GetString("UnraveledPuzzles") + this.name + "=1");
                }
                Debug.Log(PlayerPrefs.GetString("UnraveledPuzzles"));
                StartCoroutine(Ooo());
                if (PlayerPrefs.GetInt("vibrate") == 0)
                {
                    Handheld.Vibrate();
                }
            }
        }
    }
    IEnumerator Ooo(){
        yield return new WaitForSeconds(0.1f);
        gh.Play("IdlePuzzleAnimation");
        GH17.Play();
    }
    void Checker(){
        if (one.name.Substring(4) != one.tag)
        {
            return;
        }
        if (two.name.Substring(4) != two.tag)
        {
            return;
        }
        if (three.name.Substring(4) != three.tag)
        {
            return;
        }
        if (four.name.Substring(4) != four.tag)
        {
            return;
        }
        if (five.name.Substring(4) != five.tag)
        {
            return;
        }
        if (six.name.Substring(4) != six.tag)
        {
            return;
        }
        if (seven.name.Substring(4) != seven.tag)
        {
            return;
        }
        if (eight.name.Substring(4) != eight.tag)
        {
            return;
        }
        if (nine.name.Substring(4) != nine.tag)
        {
            return;
        }
        y = 1;
    }

    private void OnDisable()
    {

        y = 0;
        pex = false;
    }
}
