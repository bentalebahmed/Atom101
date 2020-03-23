using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OAtom : MonoBehaviour
{
    public GameObject O;
    public GameObject H2O;



    private void Start()
    {
        O.SetActive(true);
        H2O.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O.SetActive(false);
           

        }else if (_name == "ImageTarget H2")
        {
            O.SetActive(false);
            H2O.SetActive(true);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O.SetActive(true);
            
        }else if (_name == "ImageTarget H2")
        {
            O.SetActive(true);
            H2O.SetActive(false);


        }
    }
}
