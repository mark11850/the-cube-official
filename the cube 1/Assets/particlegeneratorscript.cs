using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlegeneratorscript : MonoBehaviour
{
    public Transform particlegenerator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
         Instantiate(particlegenerator);
        }
        
    }
}
