using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public GameObject xsound;
    public GameObject xvibrate;
    public GameObject xmusic;
    public GameObject xmoon,music,sound;
    
    private void Start()
    {
        //PlayerPrefs.SetString("UnraveledPuzzles","");
        if (PlayerPrefs.GetInt("sound") == 0){
            xsound.SetActive(false);
            sound.SetActive(true);
        }
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            xsound.SetActive(true);
            sound.SetActive(false);
        }
        if (PlayerPrefs.GetInt("vibrate") == 0)
        {
            xvibrate.SetActive(false);
        }
        if (PlayerPrefs.GetInt("vibrate") == 1)
        {
            xvibrate.SetActive(true);
        }
        if (PlayerPrefs.GetInt("music") == 0)
        {
            xmusic.SetActive(false);
            music.SetActive(true);
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            xmusic.SetActive(true);
            music.SetActive(false);
        }
        if (PlayerPrefs.GetInt("moon") == 1)
        {
            xmoon.SetActive(false);
            GameObject[] objs;
            objs = GameObject.FindGameObjectsWithTag("white");
            foreach (GameObject li in objs)
            {
                li.GetComponent<SpriteRenderer>().color = new Color(0.225f,0.225f,0.225f);
            }
        }
        if (PlayerPrefs.GetInt("moon") == 0)
        {
            xmoon.SetActive(true);
            GameObject[] objs;
            objs = GameObject.FindGameObjectsWithTag("white");
            foreach (GameObject li in objs)
            {
                li.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }
        }
    }
}
