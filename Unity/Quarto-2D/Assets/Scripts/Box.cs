using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameControl gameControl;
    public GameObject gameController;
    public PieceMove pieceMove;

    public static List<Box> boxes = new List<Box>();

    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;

    public Color originalColor;
    private Color hoverColor = Color.white;
    private SpriteRenderer m_Renderer;
    public bool chosen = false;

    void Start()
    {
        pieceMove = GetComponent<PieceMove>();
        boxes.Add(this);
        m_Renderer = GetComponent<SpriteRenderer>();
        originalColor = m_Renderer.color;
        gameController = GameObject.Find("GameController");
        gameControl = gameController.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!chosen && !pieceMove.onBoard)
        {
            m_Renderer.color = originalColor;
        }

        if (pieceMove.onBoard)
        {
            m_Renderer.color = hoverColor;
        }

        if (isBeingHeld && chosen)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log(this.gameObject.name);
            this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }

    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {

        isBeingHeld = false;

    }

    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        m_Renderer.color = hoverColor;
        if (Input.GetMouseButtonDown(1))
        {
            if (gameControl.choose)
            {
                gameControl.choose = false;
                foreach (Box go in boxes)
                {
                    go.chosen = false;
                }
                Debug.Log("Reset");
            }
            //gameControl.reset = false;
            chosen = true;
            gameControl.choose = true;
        }
    }

    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        if (!chosen) m_Renderer.color = originalColor;

    }

}
