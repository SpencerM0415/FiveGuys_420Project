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
    new private string name;
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


        }
        else if (collision == 2)
        {
            if (point != null)
            {
                point.gameObject.GetComponent<WaypointData>().isOccupied = false;
                point.gameObject.GetComponent<WaypointData>().shape = "";
                point.gameObject.GetComponent<WaypointData>().color = "";
                point.gameObject.GetComponent<WaypointData>().height = "";
                point.gameObject.GetComponent<WaypointData>().fill = "";
            }
        }


        // Win conditions
        /* COLORS */
        // First row same color
        if (    (waypoints[0].GetComponent<WaypointData>().color == waypoints[1].GetComponent<WaypointData>().color) &&
                (waypoints[1].GetComponent<WaypointData>().color == waypoints[2].GetComponent<WaypointData>().color) &&
                (waypoints[2].GetComponent<WaypointData>().color == waypoints[3].GetComponent<WaypointData>().color) &&
                (   (waypoints[0].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[0].GetComponent<WaypointData>().color == "pink") )    )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second row same color
        if (    (waypoints[4].GetComponent<WaypointData>().color == waypoints[5].GetComponent<WaypointData>().color) &&
                (waypoints[5].GetComponent<WaypointData>().color == waypoints[6].GetComponent<WaypointData>().color) &&
                (waypoints[6].GetComponent<WaypointData>().color == waypoints[7].GetComponent<WaypointData>().color) &&
                (   (waypoints[4].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[4].GetComponent<WaypointData>().color == "pink") )    )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third row same color
        if (    (waypoints[8].GetComponent<WaypointData>().color == waypoints[9].GetComponent<WaypointData>().color) &&
                (waypoints[9].GetComponent<WaypointData>().color == waypoints[10].GetComponent<WaypointData>().color) &&
                (waypoints[10].GetComponent<WaypointData>().color == waypoints[11].GetComponent<WaypointData>().color) &&
                (   (waypoints[8].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[8].GetComponent<WaypointData>().color == "pink") )    )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth row same color
        if (    (waypoints[12].GetComponent<WaypointData>().color == waypoints[13].GetComponent<WaypointData>().color) &&
                (waypoints[13].GetComponent<WaypointData>().color == waypoints[14].GetComponent<WaypointData>().color) &&
                (waypoints[14].GetComponent<WaypointData>().color == waypoints[15].GetComponent<WaypointData>().color) &&
                (   (waypoints[12].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[12].GetComponent<WaypointData>().color == "pink") )   )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        
        //First column same color
        if (    (waypoints[0].GetComponent<WaypointData>().color == waypoints[4].GetComponent<WaypointData>().color) &&
                (waypoints[4].GetComponent<WaypointData>().color == waypoints[8].GetComponent<WaypointData>().color) &&
                (waypoints[8].GetComponent<WaypointData>().color == waypoints[12].GetComponent<WaypointData>().color) &&
                (   (waypoints[0].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[0].GetComponent<WaypointData>().color == "pink") )   )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second column same color
        if (    (waypoints[1].GetComponent<WaypointData>().color == waypoints[5].GetComponent<WaypointData>().color) &&
                (waypoints[5].GetComponent<WaypointData>().color == waypoints[9].GetComponent<WaypointData>().color) &&
                (waypoints[9].GetComponent<WaypointData>().color == waypoints[13].GetComponent<WaypointData>().color) &&
                (   (waypoints[1].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[1].GetComponent<WaypointData>().color == "pink") )   )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third column same color
        if (    (waypoints[2].GetComponent<WaypointData>().color == waypoints[6].GetComponent<WaypointData>().color) &&
                (waypoints[6].GetComponent<WaypointData>().color == waypoints[10].GetComponent<WaypointData>().color) &&
                (waypoints[10].GetComponent<WaypointData>().color == waypoints[14].GetComponent<WaypointData>().color) &&
                (   (waypoints[2].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[2].GetComponent<WaypointData>().color == "pink") )   )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth column same color
        if (    (waypoints[3].GetComponent<WaypointData>().color == waypoints[7].GetComponent<WaypointData>().color) &&
                (waypoints[7].GetComponent<WaypointData>().color == waypoints[11].GetComponent<WaypointData>().color) &&
                (waypoints[11].GetComponent<WaypointData>().color == waypoints[15].GetComponent<WaypointData>().color) &&
                (   (waypoints[3].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[3].GetComponent<WaypointData>().color == "pink") )   )
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 1
        if ((waypoints[0].GetComponent<WaypointData>().color == waypoints[5].GetComponent<WaypointData>().color) &&
                (waypoints[5].GetComponent<WaypointData>().color == waypoints[10].GetComponent<WaypointData>().color) &&
                (waypoints[10].GetComponent<WaypointData>().color == waypoints[15].GetComponent<WaypointData>().color) &&
                ((waypoints[0].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[0].GetComponent<WaypointData>().color == "pink")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 2
        if ((waypoints[3].GetComponent<WaypointData>().color == waypoints[6].GetComponent<WaypointData>().color) &&
                (waypoints[6].GetComponent<WaypointData>().color == waypoints[9].GetComponent<WaypointData>().color) &&
                (waypoints[9].GetComponent<WaypointData>().color == waypoints[12].GetComponent<WaypointData>().color) &&
                ((waypoints[3].GetComponent<WaypointData>().color == "orange") ||
                    (waypoints[3].GetComponent<WaypointData>().color == "pink")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }


        /* HEIGHTS */
        // First row same height
        if ((waypoints[0].GetComponent<WaypointData>().height == waypoints[1].GetComponent<WaypointData>().height) &&
                (waypoints[1].GetComponent<WaypointData>().height == waypoints[2].GetComponent<WaypointData>().height) &&
                (waypoints[2].GetComponent<WaypointData>().height == waypoints[3].GetComponent<WaypointData>().height) &&
                ((waypoints[0].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[0].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second row same height
        if ((waypoints[4].GetComponent<WaypointData>().height == waypoints[5].GetComponent<WaypointData>().height) &&
                (waypoints[5].GetComponent<WaypointData>().height == waypoints[6].GetComponent<WaypointData>().height) &&
                (waypoints[6].GetComponent<WaypointData>().height == waypoints[7].GetComponent<WaypointData>().height) &&
                ((waypoints[4].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[4].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third row same height
        if ((waypoints[8].GetComponent<WaypointData>().height == waypoints[9].GetComponent<WaypointData>().height) &&
                (waypoints[9].GetComponent<WaypointData>().height == waypoints[10].GetComponent<WaypointData>().height) &&
                (waypoints[10].GetComponent<WaypointData>().height == waypoints[11].GetComponent<WaypointData>().height) &&
                ((waypoints[8].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[8].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth row same height
        if ((waypoints[12].GetComponent<WaypointData>().height == waypoints[13].GetComponent<WaypointData>().height) &&
                (waypoints[13].GetComponent<WaypointData>().height == waypoints[14].GetComponent<WaypointData>().height) &&
                (waypoints[14].GetComponent<WaypointData>().height == waypoints[15].GetComponent<WaypointData>().height) &&
                ((waypoints[12].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[12].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

        //First column same height
        if ((waypoints[0].GetComponent<WaypointData>().height == waypoints[4].GetComponent<WaypointData>().height) &&
                (waypoints[4].GetComponent<WaypointData>().height == waypoints[8].GetComponent<WaypointData>().height) &&
                (waypoints[8].GetComponent<WaypointData>().height == waypoints[12].GetComponent<WaypointData>().height) &&
                ((waypoints[0].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[0].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second column same height
        if ((waypoints[1].GetComponent<WaypointData>().height == waypoints[5].GetComponent<WaypointData>().height) &&
                (waypoints[5].GetComponent<WaypointData>().height == waypoints[9].GetComponent<WaypointData>().height) &&
                (waypoints[9].GetComponent<WaypointData>().height == waypoints[13].GetComponent<WaypointData>().height) &&
                ((waypoints[1].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[1].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third column same height
        if ((waypoints[2].GetComponent<WaypointData>().height == waypoints[6].GetComponent<WaypointData>().height) &&
                (waypoints[6].GetComponent<WaypointData>().height == waypoints[10].GetComponent<WaypointData>().height) &&
                (waypoints[10].GetComponent<WaypointData>().height == waypoints[14].GetComponent<WaypointData>().height) &&
                ((waypoints[2].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[2].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth column same height
        if ((waypoints[3].GetComponent<WaypointData>().height == waypoints[7].GetComponent<WaypointData>().height) &&
                (waypoints[7].GetComponent<WaypointData>().height == waypoints[11].GetComponent<WaypointData>().height) &&
                (waypoints[11].GetComponent<WaypointData>().height == waypoints[15].GetComponent<WaypointData>().height) &&
                ((waypoints[3].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[3].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 1
        if ((waypoints[0].GetComponent<WaypointData>().height == waypoints[5].GetComponent<WaypointData>().height) &&
                (waypoints[5].GetComponent<WaypointData>().height == waypoints[10].GetComponent<WaypointData>().height) &&
                (waypoints[10].GetComponent<WaypointData>().height == waypoints[15].GetComponent<WaypointData>().height) &&
                ((waypoints[0].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[0].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 2
        if ((waypoints[3].GetComponent<WaypointData>().height == waypoints[6].GetComponent<WaypointData>().height) &&
                (waypoints[6].GetComponent<WaypointData>().height == waypoints[9].GetComponent<WaypointData>().height) &&
                (waypoints[9].GetComponent<WaypointData>().height == waypoints[12].GetComponent<WaypointData>().height) &&
                ((waypoints[3].GetComponent<WaypointData>().height == "tall") ||
                    (waypoints[3].GetComponent<WaypointData>().height == "short")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

        /* SHAPE */
        // First row same shape
        if ((waypoints[0].GetComponent<WaypointData>().shape == waypoints[1].GetComponent<WaypointData>().shape) &&
                (waypoints[1].GetComponent<WaypointData>().shape == waypoints[2].GetComponent<WaypointData>().shape) &&
                (waypoints[2].GetComponent<WaypointData>().shape == waypoints[3].GetComponent<WaypointData>().shape) &&
                ((waypoints[0].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[0].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second row same shape
        if ((waypoints[4].GetComponent<WaypointData>().shape == waypoints[5].GetComponent<WaypointData>().shape) &&
                (waypoints[5].GetComponent<WaypointData>().shape == waypoints[6].GetComponent<WaypointData>().shape) &&
                (waypoints[6].GetComponent<WaypointData>().shape == waypoints[7].GetComponent<WaypointData>().shape) &&
                ((waypoints[4].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[4].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third row same shape
        if ((waypoints[8].GetComponent<WaypointData>().shape == waypoints[9].GetComponent<WaypointData>().shape) &&
                (waypoints[9].GetComponent<WaypointData>().shape == waypoints[10].GetComponent<WaypointData>().shape) &&
                (waypoints[10].GetComponent<WaypointData>().shape == waypoints[11].GetComponent<WaypointData>().shape) &&
                ((waypoints[8].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[8].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth row same shape
        if ((waypoints[12].GetComponent<WaypointData>().shape == waypoints[13].GetComponent<WaypointData>().shape) &&
                (waypoints[13].GetComponent<WaypointData>().shape == waypoints[14].GetComponent<WaypointData>().shape) &&
                (waypoints[14].GetComponent<WaypointData>().shape == waypoints[15].GetComponent<WaypointData>().shape) &&
                ((waypoints[12].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[12].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

        //First column same shape
        if ((waypoints[0].GetComponent<WaypointData>().shape == waypoints[4].GetComponent<WaypointData>().shape) &&
                (waypoints[4].GetComponent<WaypointData>().shape == waypoints[8].GetComponent<WaypointData>().shape) &&
                (waypoints[8].GetComponent<WaypointData>().shape == waypoints[12].GetComponent<WaypointData>().shape) &&
                ((waypoints[0].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[0].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second column same shape
        if ((waypoints[1].GetComponent<WaypointData>().shape == waypoints[5].GetComponent<WaypointData>().shape) &&
                (waypoints[5].GetComponent<WaypointData>().shape == waypoints[9].GetComponent<WaypointData>().shape) &&
                (waypoints[9].GetComponent<WaypointData>().shape == waypoints[13].GetComponent<WaypointData>().shape) &&
                ((waypoints[1].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[1].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third column same shape
        if ((waypoints[2].GetComponent<WaypointData>().shape == waypoints[6].GetComponent<WaypointData>().shape) &&
                (waypoints[6].GetComponent<WaypointData>().shape == waypoints[10].GetComponent<WaypointData>().shape) &&
                (waypoints[10].GetComponent<WaypointData>().shape == waypoints[14].GetComponent<WaypointData>().shape) &&
                ((waypoints[2].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[2].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth column same shape
        if ((waypoints[3].GetComponent<WaypointData>().shape == waypoints[7].GetComponent<WaypointData>().shape) &&
                (waypoints[7].GetComponent<WaypointData>().shape == waypoints[11].GetComponent<WaypointData>().shape) &&
                (waypoints[11].GetComponent<WaypointData>().shape == waypoints[15].GetComponent<WaypointData>().shape) &&
                ((waypoints[3].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[3].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 1
        if ((waypoints[0].GetComponent<WaypointData>().shape == waypoints[5].GetComponent<WaypointData>().shape) &&
                (waypoints[5].GetComponent<WaypointData>().shape == waypoints[10].GetComponent<WaypointData>().shape) &&
                (waypoints[10].GetComponent<WaypointData>().shape == waypoints[15].GetComponent<WaypointData>().shape) &&
                ((waypoints[0].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[0].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 2
        if ((waypoints[3].GetComponent<WaypointData>().shape == waypoints[6].GetComponent<WaypointData>().shape) &&
                (waypoints[6].GetComponent<WaypointData>().shape == waypoints[9].GetComponent<WaypointData>().shape) &&
                (waypoints[9].GetComponent<WaypointData>().shape == waypoints[12].GetComponent<WaypointData>().shape) &&
                ((waypoints[3].GetComponent<WaypointData>().shape == "square") ||
                    (waypoints[3].GetComponent<WaypointData>().shape == "circle")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }


        /* FILL */
        // First row same fill
        if ((waypoints[0].GetComponent<WaypointData>().fill == waypoints[1].GetComponent<WaypointData>().fill) &&
                (waypoints[1].GetComponent<WaypointData>().fill == waypoints[2].GetComponent<WaypointData>().fill) &&
                (waypoints[2].GetComponent<WaypointData>().fill == waypoints[3].GetComponent<WaypointData>().fill) &&
                ((waypoints[0].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[0].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second row same fill
        if ((waypoints[4].GetComponent<WaypointData>().fill == waypoints[5].GetComponent<WaypointData>().fill) &&
                (waypoints[5].GetComponent<WaypointData>().fill == waypoints[6].GetComponent<WaypointData>().fill) &&
                (waypoints[6].GetComponent<WaypointData>().fill == waypoints[7].GetComponent<WaypointData>().fill) &&
                ((waypoints[4].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[4].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third row same fill
        if ((waypoints[8].GetComponent<WaypointData>().fill == waypoints[9].GetComponent<WaypointData>().fill) &&
                (waypoints[9].GetComponent<WaypointData>().fill == waypoints[10].GetComponent<WaypointData>().fill) &&
                (waypoints[10].GetComponent<WaypointData>().fill == waypoints[11].GetComponent<WaypointData>().fill) &&
                ((waypoints[8].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[8].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth row same fill
        if ((waypoints[12].GetComponent<WaypointData>().fill == waypoints[13].GetComponent<WaypointData>().fill) &&
                (waypoints[13].GetComponent<WaypointData>().fill == waypoints[14].GetComponent<WaypointData>().fill) &&
                (waypoints[14].GetComponent<WaypointData>().fill == waypoints[15].GetComponent<WaypointData>().fill) &&
                ((waypoints[12].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[12].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

        //First column same fill
        if ((waypoints[0].GetComponent<WaypointData>().fill == waypoints[4].GetComponent<WaypointData>().fill) &&
                (waypoints[4].GetComponent<WaypointData>().fill == waypoints[8].GetComponent<WaypointData>().fill) &&
                (waypoints[8].GetComponent<WaypointData>().fill == waypoints[12].GetComponent<WaypointData>().fill) &&
                ((waypoints[0].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[0].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Second column same fill
        if ((waypoints[1].GetComponent<WaypointData>().fill == waypoints[5].GetComponent<WaypointData>().fill) &&
                (waypoints[5].GetComponent<WaypointData>().fill == waypoints[9].GetComponent<WaypointData>().fill) &&
                (waypoints[9].GetComponent<WaypointData>().fill == waypoints[13].GetComponent<WaypointData>().fill) &&
                ((waypoints[1].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[1].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Third column same fill
        if ((waypoints[2].GetComponent<WaypointData>().fill == waypoints[6].GetComponent<WaypointData>().fill) &&
                (waypoints[6].GetComponent<WaypointData>().fill == waypoints[10].GetComponent<WaypointData>().fill) &&
                (waypoints[10].GetComponent<WaypointData>().fill == waypoints[14].GetComponent<WaypointData>().fill) &&
                ((waypoints[2].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[2].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Fourth column same fill
        if ((waypoints[3].GetComponent<WaypointData>().fill == waypoints[7].GetComponent<WaypointData>().fill) &&
                (waypoints[7].GetComponent<WaypointData>().fill == waypoints[11].GetComponent<WaypointData>().fill) &&
                (waypoints[11].GetComponent<WaypointData>().fill == waypoints[15].GetComponent<WaypointData>().fill) &&
                ((waypoints[3].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[3].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 1
        if ((waypoints[0].GetComponent<WaypointData>().fill == waypoints[5].GetComponent<WaypointData>().fill) &&
                (waypoints[5].GetComponent<WaypointData>().fill == waypoints[10].GetComponent<WaypointData>().fill) &&
                (waypoints[10].GetComponent<WaypointData>().fill == waypoints[15].GetComponent<WaypointData>().fill) &&
                ((waypoints[0].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[0].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        //Diagonal 2
        if ((waypoints[3].GetComponent<WaypointData>().fill == waypoints[6].GetComponent<WaypointData>().fill) &&
                (waypoints[6].GetComponent<WaypointData>().fill == waypoints[9].GetComponent<WaypointData>().fill) &&
                (waypoints[9].GetComponent<WaypointData>().fill == waypoints[12].GetComponent<WaypointData>().fill) &&
                ((waypoints[3].GetComponent<WaypointData>().fill == "solid") ||
                    (waypoints[3].GetComponent<WaypointData>().fill == "hollow")))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Point") onBoard = true;
        if (box.isBeingHeld == false) {
            if (other.tag == "Point")
            {
                //Debug.Log("Stay");
                if (other.gameObject.GetComponent<WaypointData>().isOccupied == true)
                {
                    transform.position = startPoint.transform.position;
                    return;
                }
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
