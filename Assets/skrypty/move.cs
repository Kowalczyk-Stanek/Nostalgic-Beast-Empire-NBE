using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{
    public float speed = 2.0f;
    public float dropoffPosition = 4f;

    // Start is called before the first frame update
    void Start() {

      

    }

    // Update is called once per frame




    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;
        

        if (transform.position.x > dropoffPosition)
        {
           
           
            gameObject.transform.position = new Vector4(-500, 1500, 0);
        }

    }
}

