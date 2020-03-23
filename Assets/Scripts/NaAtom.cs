using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaAtom : MonoBehaviour
{

    public GameObject Na; 
   
   

    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget Cl")
        {
            Na.SetActive(false);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget Cl")
        {
            Na.SetActive(true);
            
        }
    }
}
