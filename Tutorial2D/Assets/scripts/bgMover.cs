using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMover : MonoBehaviour
{
    public float startX,endX;

    private void Update() {
        if(transform.position.x < endX)
            transform.position = new Vector2(startX,transform.position.y);
    }
}
