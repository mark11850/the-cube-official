using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class thecube : MonoBehaviour
{


    Rigidbody rb;

    private float turningspeed = 180;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * Time.deltaTime;




        if (Input.GetKey(KeyCode.F))
            rb.AddExplosionForce(100, transform.position + Vector3.down, 2);


        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down, turningspeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        health objecthitheath = collision.gameObject.GetComponent<health>();

        if (objecthitheath)
        {
            print("found health script in object hit");
            objecthitheath.takedamage(25);

            int objectmaxhealth = objecthitheath.whatsyourmaxhealth();
            if (objectmaxhealth > 100)
                objecthitheath.takedamage(100);
        }
        else
        {
            print("did not find health script");
        }
    }


   
}