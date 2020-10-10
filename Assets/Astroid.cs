using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeCounter;
    float speed;
    float a;
    void Start()
    {
        speed = 2;
        TimeCounter = 0;
        a = 6;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime * speed;
        float y = 6 + a / 4 * (3 * Mathf.Sin(TimeCounter) - Mathf.Sin(3 * TimeCounter));
        float x = a / 4 * (3 * Mathf.Cos(TimeCounter) + Mathf.Cos(3 * TimeCounter));
        float z = 6;
        transform.position = new Vector3(x, y, z);
    }
}