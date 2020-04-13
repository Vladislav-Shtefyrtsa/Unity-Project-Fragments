using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallEnabler : MonoBehaviour {

    public GameObject canzas, wall;

    private void OnMouseDown()
    {
        if (this.gameObject.name != "7X7" && this.gameObject.name != "5X5" && this.gameObject.name != "3X3" && this.name != "settingsButtonBackground222")
        {
            if (canzas.activeSelf)
            {
                canzas.SetActive(false);
            }
            else
            {
                canzas.SetActive(true);
            }
            StartCoroutine(Ff());
        }
    }
    IEnumerator Ff(){
        wall.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wall.SetActive(false);
    }
}
