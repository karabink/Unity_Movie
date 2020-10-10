using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plita : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 5f;
    public Vector3 Direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Speed * Time.deltaTime);
        if (transform.position.x <= -9)
        {
            Direction *= -1;
        }
        if (transform.position.x >= 18.5)
        {
            Direction *= -1;
        }
    }
}
