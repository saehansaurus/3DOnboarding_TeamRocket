using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float defaultRunSpeed;
    public float sideMoveSpeed;
    void Start()
    {
        // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, defaultRunSpeed);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * defaultRunSpeed * Time.deltaTime);
        if (Input.GetKey("left")) {
            transform.Translate(Vector3.left * sideMoveSpeed * Time.deltaTime);
        } else if (Input.GetKey("right")) {
            transform.Translate(Vector3.right * sideMoveSpeed * Time.deltaTime);
        }
    }
}
