using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * speed;
        float horisontal = Input.GetAxis("Horizontal") * speed;

        vertical *= Time.deltaTime;
        horisontal *= Time.deltaTime;

        transform.Translate(horisontal, vertical, 0);
    }
}
