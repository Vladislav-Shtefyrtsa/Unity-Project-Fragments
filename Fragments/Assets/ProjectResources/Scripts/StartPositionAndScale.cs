using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartPositionAndScale : MonoBehaviour {

    public GameObject BackGround;
    public GameObject GradientBackground;
    public GameObject ScrollItems;
    public RectTransform transformrect;
    public RectTransform mainrect;
    public GameObject settingsbackground;
    public GameObject arrow;
    public GameObject longButtons;
    public GameObject buttonsSetting;
    public GameObject bottom;
    public GameObject top;
    public GameObject GameBackground;
    public GameObject arrowGameBack;
    public GameObject transition;
    Vector3 TopPosition;
    float scale;

    private void Update()
    {
        scale = (top.transform.position.y - bottom.transform.position.y)*mainrect.sizeDelta.y/10;
        transformrect.sizeDelta = new Vector2(transformrect.sizeDelta.x, scale);
        DisplayWorldCorners(new Vector3[4]);
        Vector3 world = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        GameBackground.transform.localScale = new Vector3(world.x/5,world.y/9,1);
        arrowGameBack.transform.position = new Vector3(-world.x + 0.8f,arrowGameBack.transform.position.y,arrowGameBack.transform.position.z);
        if (world.x <= 2.974203f)
        {
            buttonsSetting.transform.localScale = new Vector3(world.x / 3.14f, world.x / 3.14f, 1);
        }
        else{
            buttonsSetting.transform.localScale = new Vector3(0.9375332f, 0.9375332f, 1);
        }
        transition.transform.localScale = new Vector3(world.x/4,world.x/4,1);
        if (world.x <= 2.974203f)
        {
            longButtons.transform.localScale = new Vector3(world.x / 3, world.x / 3, 1);
        }else{
            longButtons.transform.localScale = new Vector3(0.9812848f, 0.9812848f, 1);
        }
        settingsbackground.transform.localScale = new Vector3(world.x/10,world.y/10,1);
        BackGround.transform.localScale = new Vector3(world.x/3f, world.x / 3f, 1);
        GradientBackground.transform.localScale = new Vector3(world.x / 5.394734f, world.y / 9, 1);
        ScrollItems.transform.position = new Vector3(ScrollItems.transform.position.x,TopPosition.y,ScrollItems.transform.position.z);
    }
    void DisplayWorldCorners(Vector3[] v)
    {
        transformrect.GetWorldCorners(v);
        TopPosition = v[1];
    }
}
