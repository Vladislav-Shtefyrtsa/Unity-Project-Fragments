using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGameButton : MonoBehaviour {

    public GameObject game;
    public Animator gameAnimator;
    void OnMouseDown()
    {
        gameAnimator.Play("GameClose");
        StartCoroutine(Hh());
        StartCoroutine(Hg());
    }
    IEnumerator Hg(){
        yield return new WaitForSeconds(0.1f);
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("seven");

        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }
        GameObject[] gameObjectArray1 = GameObject.FindGameObjectsWithTag("five");

        foreach (GameObject gi in gameObjectArray1)
        {
            gi.SetActive(false);
        }
        GameObject[] gameObjectArray2 = GameObject.FindGameObjectsWithTag("three");

        foreach (GameObject ge in gameObjectArray2)
        {
            ge.SetActive(false);
        }
    }
    IEnumerator Hh(){
        yield return new WaitForSeconds(0.49f);
        game.SetActive(false);
    }
}
