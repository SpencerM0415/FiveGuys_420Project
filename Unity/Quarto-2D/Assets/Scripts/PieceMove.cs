using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public Transform[] waypoints; //waypoints to store board locations
    public Transform startPoint;
    public Box box;

    [SerializeField] 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        //        if (box.isBeingHeld)
        //        {
        Debug.Log("Held");
        //Destroy(this.gameObject);
        //        }
        if ((box.isBeingHeld == false) && (other.tag == "Point"))
        {
            this.transform.position = other.transform.position;
        }
    }

}
