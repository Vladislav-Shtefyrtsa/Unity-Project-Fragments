using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {
    public AudioSource gg;

    void OnMouseDown(){
        gg.Play();
    }
}
