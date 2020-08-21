using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RPCY : MonoBehaviour
{
    public Transform Bird;
    private float range;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        range = transform.position.z - Bird.position.z;
        transform.position = new Vector3(Bird.position.x, Bird.position.y, Bird.position.z + range + Bird.position.z);
    }
}
