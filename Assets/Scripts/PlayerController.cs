using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody playerRigidbody;
    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forawrdInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * forawrdInput * speed);
    }
}
