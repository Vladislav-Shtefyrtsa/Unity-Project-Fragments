using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonPress : MonoBehaviour
{
    public Animator set;
    Vector2 tocuhStartPos;
    public GameObject game;
    public GameObject wall, canvaz;
    public GameObject puzzle;
    public GameObject gameWall;
    public GameObject picture;
    public GameObject backgroundAndIcons;
    public AudioSource gh;

    private void OnEnable()
    {
        if (PlayerPrefs.GetString("UnraveledPuzzles").Contains(puzzle.name))
        {
            picture.SetActive(true);
        }
        if (PlayerPrefs.GetString("UnraveledPuzzles").Contains(puzzle.name + "=1"))
        {
            foreach (Transform child in this.transform)
            {
                if (child.tag == "WiningLight")
                    if(PlayerPrefs.GetString("UnraveledPuzzles").Contains(puzzle.name + "=1")){
                    child.gameObject.SetActive(true);
                }
            }
            StartCoroutine(Ctt());
        }
    }
    IEnumerator Ctt(){
        yield return new WaitForSeconds(2f);
        PlayerPrefs.SetString("UnraveledPuzzles", PlayerPrefs.GetString("UnraveledPuzzles").Replace(puzzle.name + "=1", puzzle.name + "=0"));
        foreach (Transform child in this.transform)
        {
            if (child.tag == "WiningLight")
                child.gameObject.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetString("UnraveledPuzzles"));
    }

    void OnMouseDown()
    {
        tocuhStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    private void OnMouseUp()
    {
        Vector2 touchPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (touchPos.y < tocuhStartPos.y + 20 && touchPos.y > tocuhStartPos.y - 20 && touchPos.x < tocuhStartPos.x + 20 && touchPos.x > tocuhStartPos.x - 20)
        {
            set.Play("MainButtonAnimtion");
            game.SetActive(true); 
            puzzle.SetActive(true);
            StartCoroutine(Ger());
            gameWall.SetActive(true);
            gh.Play();
        }
    }

    IEnumerator Ger(){
        wall.SetActive(true);canvaz.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        wall.SetActive(false);
        backgroundAndIcons.SetActive(false);
    }
}
