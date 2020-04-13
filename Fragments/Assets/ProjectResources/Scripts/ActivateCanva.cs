using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCanva : MonoBehaviour {

    public GameObject canava;
    public GameObject gameWall;
    public GameObject backgroundAndIcons;
    private void OnMouseDown()
    {
        canava.SetActive(true);
        backgroundAndIcons.SetActive(true);
        gameWall.SetActive(false);
    }
}
