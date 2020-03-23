using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronOrbitOne : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform parent;
    private float speed = 250f;
    void Start()
    {

        parent = transform.parent.transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(parent.transform.position, parent.up, speed * Time.deltaTime);
    }
}
