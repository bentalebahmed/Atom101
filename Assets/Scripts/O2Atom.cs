using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2Atom : MonoBehaviour
{
    public GameObject O2;

    // Start is called before the first frame update
    

    private void Start()
    {
        O2.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O2.SetActive(false);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O2.SetActive(true);

        }
    }
}
