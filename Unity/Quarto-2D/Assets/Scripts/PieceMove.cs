using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceMove : MonoBehaviour
{
    public Transform[] waypoints; //waypoints to store board locations
    public Transform startPoint;
    public Box box;
    private bool onBoard = false;
    private Transform test;
    private int testt = 0;
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

        if (testt == 1)
        {
            transform.position = test.position;
            point = GameObject.Find(name);
            point.gameObject.GetComponent<WaypointData>().isOccupied = true;

        } else if (testt == 2)
        {
            point.gameObject.GetComponent<WaypointData>().isOccupied = false;
        }



        // Win conditions
        if (    (waypoints[0].GetComponent<WaypointData>().isOccupied) &&
                (waypoints[1].GetComponent<WaypointData>().isOccupied) &&
                (waypoints[2].GetComponent<WaypointData>().isOccupied) &&
                (waypoints[3].GetComponent<WaypointData>().isOccupied) ) {
            Debug.Log("Hello");
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
                test = other.transform;
                testt = 1;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Point")
        {
            testt = 2;
            //other.gameObject.GetComponent<WaypointData>().isOccupied = false;
            onBoard = false;
        }
    }


}
