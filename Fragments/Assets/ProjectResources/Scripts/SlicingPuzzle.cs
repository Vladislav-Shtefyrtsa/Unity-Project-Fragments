using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicingPuzzle : MonoBehaviour
{

    int blocksperline;
    float blocksize;
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public bool detectSwipeOnlyAfterRelease = false;
    public float SWIPE_THRESHOLD = 20f;
    bool OnlyOne = false;
    Vector2Int coord;
    GameObject gameWall;

    private void OnDisable()
    {
        Destroy(this.gameObject);
    }

    private void Start()
    {
        gameWall = GameObject.Find("GameWall");
        Vector3 world = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (this.transform.parent.tag == "ten")
        {
            blocksperline = 10;
        }
        if (this.transform.parent.tag == "six")
        {
            blocksperline = 6;
        }
        if (this.transform.parent.tag == "seven")
        {
            blocksperline = 7;
        }
        if (this.transform.parent.tag == "three")
        {
            blocksperline = 3;
        }
        if (this.transform.parent.tag == "four")
        {
            blocksperline = 4;
        }
        if (this.transform.parent.tag == "five")
        {
            blocksperline = 5;
        }
        blocksize = world.x / blocksperline * 1.8f;
    }

    private void OnMouseDown()
    {
        OnlyOne = true;
        fingerUp = Input.mousePosition;
        fingerDown = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        if (!detectSwipeOnlyAfterRelease)
        {
            fingerDown = Input.mousePosition;
            checkSwipe();
        }
    }

    private void OnMouseUp()
    {
        OnlyOne = false;
        fingerDown = Input.mousePosition;
        checkSwipe();
    }


    void checkSwipe()
    {
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            if (fingerDown.y - fingerUp.y > 0) // Up Swipe
            {
                if (OnlyOne == true && gameWall.activeSelf == false)
                {
                    if (blocksperline == 3)
                    {
                        if(this.name.Substring(4) != "1" && this.name.Substring(4) != "2" && this.name.Substring(4) != "3") {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y + blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 5)
                    {
                        if (this.name.Substring(4) != "1" && this.name.Substring(4) != "2" && this.name.Substring(4) != "3" && this.name.Substring(4) != "4" && this.name.Substring(4) != "5")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y + blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 7)
                    {
                        if (this.name.Substring(4) != "1" && this.name.Substring(4) != "2" && this.name.Substring(4) != "3" && this.name.Substring(4) != "4" && this.name.Substring(4) != "5" && this.name.Substring(4) != "6" && this.name.Substring(4) != "7")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y + blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                }
            }
            else if (fingerDown.y - fingerUp.y < 0)//Down swipe
            {
                if (OnlyOne == true && gameWall.activeSelf == false)
                {
                    if (blocksperline == 3)
                    {
                        if (this.name.Substring(4) != "7" && this.name.Substring(4) != "8" && this.name.Substring(4) != "9")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y - blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 5)
                    {
                        if (this.name.Substring(4) != "21" && this.name.Substring(4) != "22" && this.name.Substring(4) != "23" && this.name.Substring(4) != "24" && this.name.Substring(4) != "25")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y - blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 7)
                    {
                        if (this.name.Substring(4) != "43" && this.name.Substring(4) != "44" && this.name.Substring(4) != "45" && this.name.Substring(4) != "46" && this.name.Substring(4) != "47" && this.name.Substring(4) != "48" && this.name.Substring(4) != "49")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x, this.transform.position.y - blocksize, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + blocksperline).ToString();
                            OnlyOne = false;
                        }
                    }
                }
            }
            fingerUp = fingerDown;
        }

        else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
        {
            if (fingerDown.x - fingerUp.x > 0)//Right Swipe
            {
                if (OnlyOne == true && gameWall.activeSelf == false)
                {
                    if (blocksperline == 3)
                    {
                        if (this.name.Substring(4) != "3" && this.name.Substring(4) != "6" && this.name.Substring(4) != "9")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x + blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 5)
                    {
                        if (this.name.Substring(4) != "5" && this.name.Substring(4) != "10" && this.name.Substring(4) != "15" && this.name.Substring(4) != "20" && this.name.Substring(4) != "25")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x + blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 7)
                    {
                        if (this.name.Substring(4) != "7" && this.name.Substring(4) != "14" && this.name.Substring(4) != "21" && this.name.Substring(4) != "28" && this.name.Substring(4) != "35" && this.name.Substring(4) != "42" && this.name.Substring(4) != "49")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x + blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) + 1).ToString();
                            OnlyOne = false;
                        }
                    }
                }
            }
            else if (fingerDown.x - fingerUp.x < 0)
            {
                if (OnlyOne == true && gameWall.activeSelf == false) //Left Swipe
                {
                    if (blocksperline == 3)
                    {
                        if (this.name.Substring(4) != "1" && this.name.Substring(4) != "4" && this.name.Substring(4) != "7")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x - blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 5)
                    {
                        if (this.name.Substring(4) != "1" && this.name.Substring(4) != "6" && this.name.Substring(4) != "11" && this.name.Substring(4) != "16" && this.name.Substring(4) != "21")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x - blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString();
                            OnlyOne = false;
                        }
                    }
                    if (blocksperline == 7)
                    {
                        if (this.name.Substring(4) != "1" && this.name.Substring(4) != "8" && this.name.Substring(4) != "15" && this.name.Substring(4) != "22" && this.name.Substring(4) != "29" && this.name.Substring(4) != "36" && this.name.Substring(4) != "43")
                        {
                            MoveTePosition(GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()), new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), 0.1f);
                            MoveToPosition(new Vector3(this.transform.position.x - blocksize, this.transform.position.y, this.transform.position.z), 0.1f);
                            GameObject.Find("Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString()).name = this.name;
                            this.name = "Quad" + (int.Parse(this.name.Substring(4)) - 1).ToString();
                            OnlyOne = false;
                        }
                    }
                }
            }
            fingerUp = fingerDown;
        }
        else
        {
        }
    }

    float verticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }

    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }

    void MoveToPosition(Vector3 target, float duration)
    {
        StartCoroutine(AnimateMove(target, duration));
    }

    IEnumerator AnimateMove(Vector3 target, float duration)
    {
        Vector3 initialPos = transform.position;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime / duration;
            transform.position = Vector3.Lerp(initialPos, target, percent);
            yield return null;
        }
    }
    void MoveTePosition(GameObject anotherblock, Vector3 target, float duration)
    {
        StartCoroutine(AnimateMeve(anotherblock, target, duration));
    }


    IEnumerator AnimateMeve(GameObject anotherblock, Vector3 target, float duration)
    {
        Vector3 initialPos = anotherblock.transform.position;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime / duration;
            anotherblock.transform.position = Vector3.Lerp(initialPos, target, percent);
            yield return null;
        }
    }
}

