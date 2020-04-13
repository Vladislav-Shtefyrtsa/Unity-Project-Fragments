using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGenerator : MonoBehaviour
{
    public Texture2D image;
    int BlocksPerLine;
    int i = 0;
    Color color;
    Vector3 world;
    public GameObject gameWall;
    public GameObject nameThree, nameFive, nameSeven;

    private void OnEnable()
    {
        StartCoroutine(Sog());
        StartCoroutine(Shuffler());
        StartCoroutine(ShufflerFive());
        StartCoroutine(ShufflerSeven());
    }

    IEnumerator Sog()
    {
        if (this.gameObject.tag == "seven")
        {
            nameSeven.SetActive(true);
            nameFive.SetActive(false);
            nameThree.SetActive(false);
        }
        if (this.gameObject.tag == "five")
        {
            nameSeven.SetActive(false);
            nameFive.SetActive(true);
            nameThree.SetActive(false);
        }
        if (this.gameObject.tag == "three")
        {
            nameSeven.SetActive(false);
            nameFive.SetActive(false);
            nameThree.SetActive(true);
        }
        yield return new WaitForSeconds(0.5f);
        if (this.gameObject.tag == "seven")
        {
            BlocksPerLine = 7;
        }
            if (this.gameObject.tag == "five")
            {
                BlocksPerLine = 5;
            }
            if (this.gameObject.tag == "three")
            {
                BlocksPerLine = 3;
            }
            world = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            int imageSize = Mathf.Min(image.width, image.height);
            int blockSize = imageSize / BlocksPerLine;
            Texture2D[,] blocks = new Texture2D[BlocksPerLine, BlocksPerLine];
            for (int x = 0; x < BlocksPerLine; x++)
            {
                for (int y = 0; y < BlocksPerLine; y++)
                {
                    i++;
                    GameObject blockObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
                    blockObject.transform.localScale = new Vector3(world.x / BlocksPerLine * 1.8f, world.x / BlocksPerLine * 1.8f, world.x / BlocksPerLine);
                    blockObject.transform.position = new Vector3(this.transform.position.x + (y - (BlocksPerLine * 0.5f - 0.5f)) * blockObject.transform.localScale.x, ((x * -1) + (BlocksPerLine * 0.5f - 0.5f)) * blockObject.transform.localScale.y, -7);
                    blockObject.transform.parent = transform;
                    blockObject.tag = i.ToString();
                    blockObject.name = "Quad" + i.ToString();
                    blockObject.AddComponent<SlicingPuzzle>();
                    Texture2D block = new Texture2D(blockSize, blockSize);
                    block.wrapMode = TextureWrapMode.Clamp;
                    block.SetPixels(image.GetPixels(y * blockSize, (BlocksPerLine - (x + 1)) * blockSize, blockSize, blockSize));
                    block.Apply();
                    blocks[x, y] = block;
                    blockObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Block");
                    blockObject.GetComponent<MeshRenderer>().material.mainTexture = block;
                yield return new WaitForSeconds(0.1f);
                }
            }
        }
    
    private void OnDisable()
    {
        i = 0;
    }

    IEnumerator Shuffler(){
        if (this.gameObject.tag == "three")
        {
            yield return new WaitForSeconds(1.5f);
            for (int z = 0; z < 15; z++)
            {
                int a = Random.Range(1, 5);
                if (a == 1)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(4, 10).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 2)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(1, 3).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 3)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(4, 6).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 4)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(7, 9).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                yield return new WaitForSeconds(0.15f);
                if(z == 14){
                    StartCoroutine(EnableGameWall());
                }
            }
        }
    }

    IEnumerator EnableGameWall(){
        yield return new WaitForSeconds(0.1f);
        gameWall.SetActive(false);
    }

    IEnumerator ShufflerFive(){
        if (this.gameObject.tag == "five")
        {
            yield return new WaitForSeconds(3.35f);
            for (int z = 0; z < 35; z++)
            {
                int a = Random.Range(1, 10);
                if (a == 1)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(6, 26).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 2)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(1, 5).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 3)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(6, 10).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 4)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(11, 15).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 5)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(16, 20).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 6)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(21, 25).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 7)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(6, 26).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 8)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(6, 26).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 9)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(6, 26).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                yield return new WaitForSeconds(0.1f);
                if (z == 34)
                {
                    StartCoroutine(EnableGameWall());
                }
            }
        }
    }

    IEnumerator ShufflerSeven(){
        if (this.gameObject.tag == "seven")
        {
            yield return new WaitForSeconds(6f);
            for (int z = 0; z < 60; z++)
            {
                int a = Random.Range(1, 13);
                if (a == 1)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 50).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 2)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(1, 7).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 3)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 14).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 4)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(15, 21).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 5)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(22, 28).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 6)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(29, 35).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 7)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(36, 42).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 8)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(43, 49).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x + world.x / BlocksPerLine * 1.8f, block.transform.position.y, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) + 1).ToString();
                }
                if (a == 9)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 50).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 10)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 50).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 11)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 50).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                if (a == 12)
                {
                    GameObject block = GameObject.Find("Quad" + Random.Range(8, 50).ToString());
                    MoveTePosition(GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()), new Vector3(block.transform.position.x, block.transform.position.y, block.transform.position.z), 0.1f);
                    MoveToPosition(block, new Vector3(block.transform.position.x, block.transform.position.y + world.x / BlocksPerLine * 1.8f, block.transform.position.z), 0.1f);
                    GameObject.Find("Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString()).name = block.name;
                    block.name = "Quad" + (int.Parse(block.name.Substring(4)) - BlocksPerLine).ToString();
                }
                yield return new WaitForSeconds(0.1f);
                if (z == 59)
                {
                    StartCoroutine(EnableGameWall());
                }
            }
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

    void MoveToPosition(GameObject blog,Vector3 target, float duration)
    {
        StartCoroutine(AnimateMove(blog,target, duration));
    }

    IEnumerator AnimateMove(GameObject blog,Vector3 target, float duration)
    {
        Vector3 initialPos = blog.transform.position;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime / duration;
            blog.transform.position = Vector3.Lerp(initialPos, target, percent);
            yield return null;
        }
    }
}
