using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HAtom : MonoBehaviour
{
    public GameObject H;
  

    private void Start()
    {
        H.SetActive(true);
       

    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget Cl")
        {
            H.SetActive(false);


        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget Cl")
        {
            H.SetActive(true);

        }
       
    }
}
