using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
