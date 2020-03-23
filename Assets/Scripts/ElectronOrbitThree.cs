using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronOrbitThree : MonoBehaviour
{
    private Transform parent;
    private float speed = 250f;
    void Start()
    {

        parent = transform.parent.transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(parent.transform.position, parent.right, speed * Time.deltaTime);
    }
}
