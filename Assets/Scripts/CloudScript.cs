using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{

    public GameObject movingClouds;
    public float cloudSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movingClouds.transform.Translate(Vector3.forward * cloudSpeed * Time.deltaTime);
    }
}
