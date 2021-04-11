using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceMove : MonoBehaviour
{
    public Transform[] waypoints; //waypoints to store board locations
    public Transform startPoint;
    public Box box;
    public string height;
    public string color;
    public string fill;
    public string shape;

    private bool onBoard = false;
    private Transform piecePosition;
    private int collision = 0;
    private string name;
    private GameObject point;



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

        if (collision == 1)
        {
            transform.position = piecePosition.position;
            point = GameObject.Find(name);
            point.gameObject.GetComponent<WaypointData>().isOccupied = true;
            point.gameObject.GetComponent<WaypointData>().shape = this.shape;
            point.gameObject.GetComponent<WaypointData>().color = this.color;
            point.gameObject.GetComponent<WaypointData>().height = this.height;
            point.gameObject.GetComponent<WaypointData>().fill = this.fill;


        } else if (collision == 2)
        {
            point.gameObject.GetComponent<WaypointData>().isOccupied = false;
            point.gameObject.GetComponent<WaypointData>().shape = "";
            point.gameObject.GetComponent<WaypointData>().color = "";
            point.gameObject.GetComponent<WaypointData>().height = "";
            point.gameObject.GetComponent<WaypointData>().fill = "";
        }



        // Win conditions
        if (    (waypoints[0].GetComponent<WaypointData>().color == waypoints[1].GetComponent<WaypointData>().color) &&
                (waypoints[1].GetComponent<WaypointData>().color == waypoints[2].GetComponent<WaypointData>().color) &&
                (waypoints[2].GetComponent<WaypointData>().color == waypoints[3].GetComponent<WaypointData>().color) &&
                (   (waypoints[0].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[0].GetComponent<WaypointData>().color == "pink") )    )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        onBoard = true;
        if (box.isBeingHeld == false) {
            if (other.tag == "Point")
            {

                //Debug.Log("Stay");
                //other.gameObject.GetComponent<WaypointData>().isOccupied = true;
                name = other.name;
                piecePosition = other.transform;
                collision = 1;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Point")
        {
            collision = 2;
            //other.gameObject.GetComponent<WaypointData>().isOccupied = false;
            onBoard = false;
        }
    }


}
