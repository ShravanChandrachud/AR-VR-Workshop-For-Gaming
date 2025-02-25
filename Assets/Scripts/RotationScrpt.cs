using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScrpt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2f;
        float step = speed * Time.deltaTime;
        Vector3 posX = new Vector3(5, 0, 0);
        Vector3 posY = new Vector3(0, 5, 0);
        Vector3 posZ = new Vector3(0, 0, 5);


        transform.position = Vector3.MoveTowards(transform.position, transform.position + posX, 1f * Time.deltaTime);
        transform.Rotate(new Vector3(1, 0, 0), -0.5f);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + posY - posX, 1f * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 0), 0.5f);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + posZ - posY, 1f * Time.deltaTime);
        transform.Rotate(new Vector3(1, 0, 0), -0.5f);

    }
}
