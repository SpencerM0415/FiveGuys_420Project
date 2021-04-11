using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Check : MonoBehaviour
{
    Box box;
    //public CircleCollider2D spaceCollider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
//        if (box.isBeingHeld)
//        {
            Debug.Log("Held");
            //Destroy(this.gameObject);
//        }
        //transform.position = startPoint.transform.position;
    }

}
