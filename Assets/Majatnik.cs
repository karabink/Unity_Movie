using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Majatnik : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 3f;
    public Vector3 Direction;
    public GameObject Opora;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Opora.transform.position, Vector3.up, Speed * Time.deltaTime);
        if (transform.position.x <= 50)
        {
            Direction *= -3;
        }
        if (transform.position.x >= 30)
        {
            Direction *= -3;
        }
    }
}
