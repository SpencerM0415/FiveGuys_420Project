using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject player1Pick;
    public GameObject player1Place;
    public GameObject player2Pick;
    public GameObject player2Place;
    public bool choose = false;
    public bool placed = false;
    public bool gameWon = false;


    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1Pick = GameObject.Find("Player1Pick");
        player1Place = GameObject.Find("Player1Place");
        player2Pick = GameObject.Find("Player2Pick");
        player2Place = GameObject.Find("Player2Place");


        //player1.GetComponent<PlayerData>().wonGame

        StartCoroutine(Game());
    }

    IEnumerator Game()
    {
        player1Pick.gameObject.SetActive(false);
        player1Place.gameObject.SetActive(false);
        player2Pick.gameObject.SetActive(false);
        player2Place.gameObject.SetActive(false);

        player1Pick.gameObject.SetActive(true);
        yield return StartCoroutine(WaitForPieceChoose());
        
        player1Pick.gameObject.SetActive(false);

        player2Place.gameObject.SetActive(true);
        yield return StartCoroutine(WaitForPiecePlace());
        player2Place.gameObject.SetActive(false);
        placed = false;
        choose = false;
        PlayerPrefs.SetInt("Player", 2);
        if (gameWon)
        {
            Debug.Log(2);
        }


        player2Pick.gameObject.SetActive(true);
        yield return StartCoroutine(WaitForPieceChoose());
        player2Pick.gameObject.SetActive(false);
        

        player1Place.gameObject.SetActive(true);
        yield return StartCoroutine(WaitForPiecePlace());
        player1Place.gameObject.SetActive(false);
        placed = false;
        choose = false;
        PlayerPrefs.SetInt("Player", 1);
        if (gameWon)
        {
            Debug.Log(1);
        }

        StartCoroutine(Game());

    }

    private IEnumerator WaitForPieceChoose()
    {
        while (!choose) // essentially a "while true", but with a bool to break out naturally
        {
            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }

    }

    private IEnumerator WaitForPiecePlace()
    {
        while (!placed) // essentially a "while true", but with a bool to break out naturally
        {
            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

}
