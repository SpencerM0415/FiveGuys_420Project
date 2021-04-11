using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public Transform[] waypoints; //waypoints to store board locations
    public Transform startPoint;
    public Box box;
    private bool onBoard = false;

    [SerializeField] 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((box.isBeingHeld == false) && (onBoard == false))
        {
            transform.position = startPoint.transform.position;
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        onBoard = true;
        if ((box.isBeingHeld == false) && (other.tag == "Point"))
        {
            transform.position = other.transform.position;
        } 
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Point")
        {
            onBoard = false;
        }
    }


}
