using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UIElements;

public class TheCircle : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turningPoint;
    [SerializeField] float downSpeed;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x >= turningPoint || 
            transform.position.x <= -turningPoint)
        {
            speed = -speed;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, 0);
        }
    }
}
