using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnimation : MonoBehaviour {

    public Animator set;
    Vector2 tocuhStartPos;

    void OnMouseDown()
    {
        tocuhStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (this.gameObject.name.Contains("Button"))
        {
            set.Play("PressButtonAnimation");
            StartCoroutine(Fog());
        }
        if (this.gameObject.name.Contains("button"))
        {
            set.Play("PressButtonAnimation1");
            StartCoroutine(Fog());
        }
    }

    private void OnMouseUp()
    {
        Vector2 touchPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        if (touchPos.y < tocuhStartPos.y + 20f && touchPos.y > tocuhStartPos.y - 20f)
        {
            if (this.gameObject.name.Contains("button"))
            {
                //set.Play("MainButtonAnimtion");
            }
        }
    }
    IEnumerator Fog()
    {
        yield return new WaitForSeconds(0.2f);
        set.Play("NewState");
    }
}
