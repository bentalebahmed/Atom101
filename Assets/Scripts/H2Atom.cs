using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2Atom : MonoBehaviour
{
    public GameObject H2;

    // Start is called before the first frame update


    private void Start()
    {
        H2.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget O")
        {
            H2.SetActive(false);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget O")
        {
            H2.SetActive(true);

        }
    }
}
