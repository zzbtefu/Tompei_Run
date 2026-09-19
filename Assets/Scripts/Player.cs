using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 3.0f;

    private float inputx;
    private float inputz;

    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputz = Input.GetAxis("Vertical");
        velocity = new Vector3(inputx, 0, inputz) * speed;
        this.transform.Translate(velocity * Time.deltaTime);
    }
}
