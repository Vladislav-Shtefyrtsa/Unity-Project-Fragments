using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningEnabler2 : MonoBehaviour
{

    GameObject one,two,three,four,five,six,seven,eight,nine,ten,eleven,twele,thirteen,fourteen,fithteen,sixteen,seventeen,eightteen,nineteen,twenty,twentyone,twentytwo,twentythree,twentyfour,twentyfive,twentysix,twentyseven,twentyeight,twentynine,thirty,thirtyone,thirtytwo,thirtythree,thirtyfour,thirtyfive,thirtysix,thirtyseven,thirtyeight,thirtynine,fourty,fourtyone,fourtytwo,fourtythree,fourtyfour,fourtyfive,fourtysix,fourtyseven,fourtyeight,fourtynine;
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
        this.transform.localScale = new Vector3(1,1,1);
    }

    IEnumerator ur(){
        yield return new WaitForSeconds(10);
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
            twentysix = GameObject.Find("Quad" + "26");
            twentyseven = GameObject.Find("Quad" + "27");
            twentyeight = GameObject.Find("Quad" + "28");
            twentynine = GameObject.Find("Quad" + "29");
            thirty = GameObject.Find("Quad" + "30");
            thirtyone = GameObject.Find("Quad" + "31");
            thirtytwo = GameObject.Find("Quad" + "32");
            thirtythree = GameObject.Find("Quad" + "33");
            thirtyfour = GameObject.Find("Quad" + "34");
            thirtyfive = GameObject.Find("Quad" + "35");
            thirtysix = GameObject.Find("Quad" + "36");
            thirtyseven = GameObject.Find("Quad" + "37");
            thirtyeight = GameObject.Find("Quad" + "38");
            thirtynine = GameObject.Find("Quad" + "39");
            fourty = GameObject.Find("Quad" + "40");
            fourtyone = GameObject.Find("Quad" + "41");
            fourtytwo = GameObject.Find("Quad" + "42");
            fourtythree = GameObject.Find("Quad" + "43");
            fourtyfour = GameObject.Find("Quad" + "44");
            fourtyfive = GameObject.Find("Quad" + "45");
            fourtysix = GameObject.Find("Quad" + "46");
            fourtyseven = GameObject.Find("Quad" + "47");
            fourtyeight = GameObject.Find("Quad" + "48");
            fourtynine = GameObject.Find("Quad" + "49");
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
        if (twentysix.name.Substring(4) != twentysix.tag)
        {
            return;
        }
        if (twentyseven.name.Substring(4) != twentyseven.tag)
        {
            return;
        }
        if (twentyeight.name.Substring(4) != twentyeight.tag)
        {
            return;
        }
        if (twentynine.name.Substring(4) != twentynine.tag)
        {
            return;
        }
        if (thirty.name.Substring(4) != thirty.tag)
        {
            return;
        }
        if (thirtyone.name.Substring(4) != thirtyone.tag)
        {
            return;
        }
        if (thirtytwo.name.Substring(4) != thirtytwo.tag)
        {
            return;
        }
        if (thirtythree.name.Substring(4) != thirtythree.tag)
        {
            return;
        }
        if (thirtyfour.name.Substring(4) != thirtyfour.tag)
        {
            return;
        }
        if (thirtyfive.name.Substring(4) != thirtyfive.tag)
        {
            return;
        }
        if (thirtysix.name.Substring(4) != thirtysix.tag)
        {
            return;
        }
        if (thirtyseven.name.Substring(4) != thirtyseven.tag)
        {
            return;
        }
        if (thirtyeight.name.Substring(4) != thirtyeight.tag)
        {
            return;
        }
        if (thirtynine.name.Substring(4) != thirtynine.tag)
        {
            return;
        }
        if (fourty.name.Substring(4) != fourty.tag)
        {
            return;
        }
        if (fourtyone.name.Substring(4) != fourtyone.tag)
        {
            return;
        }
        if (fourtytwo.name.Substring(4) != fourtytwo.tag)
        {
            return;
        }
        if (fourtythree.name.Substring(4) != fourtythree.tag)
        {
            return;
        }
        if (fourtyfour.name.Substring(4) != fourtyfour.tag)
        {
            return;
        }
        if (fourtyfive.name.Substring(4) != fourtyfive.tag)
        {
            return;
        }
        if (fourtysix.name.Substring(4) != fourtysix.tag)
        {
            return;
        }
        if (fourtyseven.name.Substring(4) != fourtyseven.tag)
        {
            return;
        }
        if (fourtyeight.name.Substring(4) != fourtyeight.tag)
        {
            return;
        }
        if (fourtynine.name.Substring(4) != fourtynine.tag)
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
