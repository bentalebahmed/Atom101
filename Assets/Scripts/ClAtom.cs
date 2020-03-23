using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClAtom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cl;
    public GameObject NaCl;
    public GameObject HCl;


    private void Start()
    {
        NaCl.SetActive(false);
        Cl.SetActive(true);
        HCl.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget Na")
        {
            Cl.SetActive(false);
            NaCl.SetActive(true);
        }
        else if (_name == "ImageTarget H")
        {
            Cl.SetActive(false);
            HCl.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        string _name = other.name;

        if (_name == "ImageTarget Na")
        {
            Cl.SetActive(true);
            NaCl.SetActive(false);
        }
        else if (_name == "ImageTarget H")
        {
            Cl.SetActive(true);
            HCl.SetActive(false);
        }
    }
}
