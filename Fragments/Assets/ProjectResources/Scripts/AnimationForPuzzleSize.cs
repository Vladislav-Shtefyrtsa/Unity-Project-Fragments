using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationForPuzzleSize : MonoBehaviour {

    private void OnEnable()
    {
        Vector3 world = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        if (this.name.Contains("3X3")){
            this.gameObject.transform.localScale = new Vector3(world.x/1.8f* 1.079376432530845f, world.x/1.8f* 1.079376432530845f, 1);
        }
    }
}
