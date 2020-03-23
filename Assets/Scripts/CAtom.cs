using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAtom : MonoBehaviour
{
    public GameObject C;
    public GameObject CO;
    public GameObject CO2;


    private void Start()
    {
        CO.SetActive(false);
        C.SetActive(true);
        CO2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget O")
        {
            C.SetActive(false);
            CO.SetActive(true);

        } else if (_name == "ImageTarget O2")
        {
            C.SetActive(false);
            CO2.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget O")
        {
            C.SetActive(true);
            CO.SetActive(false);

        }
        else if (_name == "ImageTarget O2")
        {
            C.SetActive(true);
            CO2.SetActive(false);

        }
    }
}
