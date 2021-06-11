using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{
    public float speed = 0.5f;
    public float dropoffPosition = 4f;

   // public float x, y, z = 1;

    // Start is called before the first frame update
    void Start() {

      

    }

    // Update is called once per frame




    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;
        

        if (transform.position.x > dropoffPosition)
        {
           
           
            gameObject.transform.position = new Vector4(Random.Range(-1000,-700), Random.Range(1000, 1500), 5);
        }

    }
}

