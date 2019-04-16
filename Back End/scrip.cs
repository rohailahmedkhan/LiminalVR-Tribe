using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public float speed = 0.3f;
    public GameObject a=null;
    public GameObject b=null;
    public GameObject c=null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 3.0f)            
        transform.position += Vector3.forward * Time.deltaTime * speed;
        if (transform.position.z > -2.8f && transform.position.z < 0.0f)
            a.SetActive(true);
        if (transform.position.z > 0.0f && transform.position.z < 1.0f)
            c.SetActive(true);
        if (transform.position.z > 1.7f)
            b.SetActive(true);



    }
}
