using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetButton : MonoBehaviour {
    public GameObject x,music,sound;

    private void OnMouseDown()
    {
        if(this.name == "soundButton"){
            if(PlayerPrefs.GetInt("sound") == 1){
                PlayerPrefs.SetInt("sound", 0);
                x.SetActive(false);
                sound.SetActive(true);
            }
            else
            {
                PlayerPrefs.SetInt("sound", 1);
                x.SetActive(true);
                sound.SetActive(false);
            }
        }
        if (this.name == "vibrateButton")
        {
            if (PlayerPrefs.GetInt("vibrate") == 1)
            {
                PlayerPrefs.SetInt("vibrate", 0);
                x.SetActive(false);
            }else{
                PlayerPrefs.SetInt("vibrate", 1);
                x.SetActive(true);
            }
        }
        if (this.name == "musicButton")
        {
            if (PlayerPrefs.GetInt("music") == 1)
            {
                PlayerPrefs.SetInt("music", 0);
                x.SetActive(false);
                music.SetActive(true);
            }
            else
            {
                PlayerPrefs.SetInt("music", 1);
                x.SetActive(true);
                music.SetActive(false);
            }
        }
        if (this.name == "moonButton")
        {
            if (PlayerPrefs.GetInt("moon") == 0)
            {
                PlayerPrefs.SetInt("moon", 1);
                x.SetActive(false);
                GameObject[] objs;
                objs = GameObject.FindGameObjectsWithTag("white");
                foreach (GameObject li in objs)
                {
                    li.GetComponent<SpriteRenderer>().color = new Color(.225f, .225f, .225f);
                }
            }
            else
            {
                PlayerPrefs.SetInt("moon", 0);
                x.SetActive(true);
                GameObject[] objs;
                objs = GameObject.FindGameObjectsWithTag("white");
                foreach (GameObject li in objs)
                {
                    li.GetComponent<SpriteRenderer>().color = new Color(1, 1f, 1f);
                }
            }
        }
    }
}
