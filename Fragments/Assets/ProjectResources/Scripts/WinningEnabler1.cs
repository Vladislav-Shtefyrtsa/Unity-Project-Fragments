using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningEnabler1 : MonoBehaviour
{

    GameObject one,two,three,four,five,six,seven,eight,nine,ten,eleven,twele,thirteen,fourteen,fithteen,sixteen,seventeen,eightteen,nineteen,twenty,twentyone,twentytwo,twentythree,twentyfour,twentyfive;
    int y = 0;
    bool pex = false;
    bool pef = true;
    Animator gh;
    public AudioSource GH17;

    private void OnEnable()
    {
        //PlayerPrefs.SetString("UnraveledPuzzles", "");
        StartCoroutine(ur());
        pef = true;
        y = 0;
        gh = this.GetComponent<Animator>();
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
            ten = GameObject.Find("Quad" + "10");
            eleven = GameObject.Find("Quad" + "11");
            twele = GameObject.Find("Quad" + "12");
            thirteen = GameObject.Find("Quad" + "13");
            fourteen = GameObject.Find("Quad" + "14");
            fithteen = GameObject.Find("Quad" + "15");
            sixteen = GameObject.Find("Quad" + "16");
            seventeen = GameObject.Find("Quad" + "17");
            eightteen = GameObject.Find("Quad" + "18");
            nineteen = GameObject.Find("Quad" + "19");
            twenty = GameObject.Find("Quad" + "20");
            twentyone = GameObject.Find("Quad" + "21");
            twentytwo = GameObject.Find("Quad" + "22");
            twentythree = GameObject.Find("Quad" + "23");
            twentyfour = GameObject.Find("Quad" + "24");
            twentyfive = GameObject.Find("Quad" + "25");
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
    IEnumerator Ooo()
    {
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
        if (ten.name.Substring(4) != ten.tag)
        {
            return;
        }
        if (eleven.name.Substring(4) != eleven.tag)
        {
            return;
        }
        if (twele.name.Substring(4) != twele.tag)
        {
            return;
        }
        if (thirteen.name.Substring(4) != thirteen.tag)
        {
            return;
        }
        if (fourteen.name.Substring(4) != fourteen.tag)
        {
            return;
        }
        if (fithteen.name.Substring(4) != fithteen.tag)
        {
            return;
        }
        if (sixteen.name.Substring(4) != sixteen.tag)
        {
            return;
        }
        if (seventeen.name.Substring(4) != seventeen.tag)
        {
            return;
        }
        if (eightteen.name.Substring(4) != eightteen.tag)
        {
            return;
        }
        if (nineteen.name.Substring(4) != nineteen.tag)
        {
            return;
        }
        if (twenty.name.Substring(4) != twenty.tag)
        {
            return;
        }
        if (twentyone.name.Substring(4) != twentyone.tag)
        {
            return;
        }
        if (twentytwo.name.Substring(4) != twentytwo.tag)
        {
            return;
        }
        if (twentythree.name.Substring(4) != twentythree.tag)
        {
            return;
        }
        if (twentyfour.name.Substring(4) != twentyfour.tag)
        {
            return;
        }
        if (twentyfive.name.Substring(4) != twentyfive.tag)
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
