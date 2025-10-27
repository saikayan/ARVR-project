using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_around : MonoBehaviour
{

    public Transform earth;

    public Transform moon;


    // Start is called before the first frame update
    void Start()
    {
        earth=GameObject.FindGameObjectWithTag("earth").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        moon.RotateAround(earth.position, Vector3.up, 30 * Time.deltaTime);

    }
}
