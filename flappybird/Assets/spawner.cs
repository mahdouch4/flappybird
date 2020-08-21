using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float miny;
    public float maxy;
    public float  distance;
    public GameObject UR ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Obstacle")
        {

         float y =   Random.Range(miny,maxy);
            Vector3 spawnposition = new Vector3(transform.position.x+ distance ,y, transform.position.z);
            col.gameObject.transform.position =  spawnposition;
            

        }
        if (col.tag == "ff")
        {

            float y = Random.Range(miny, maxy);
            Vector3 spawnposition = new Vector3(transform.position.x + distance, y, transform.position.z);
            col.gameObject.transform.position = spawnposition;


        }




    }
}

