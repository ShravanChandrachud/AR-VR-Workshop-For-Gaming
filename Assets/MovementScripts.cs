using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Vector3 x = new Vector3(1, 0, 0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + x, step);
    }
}
