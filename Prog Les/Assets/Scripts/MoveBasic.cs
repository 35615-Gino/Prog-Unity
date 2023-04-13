using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;

    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    //start van de frame
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = speed * Input.GetAxis("Vertical");
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;


        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 1.1f;
        }
    }
}
