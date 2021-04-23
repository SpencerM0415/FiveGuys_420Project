﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        
        if (isBeingHeld)
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

   

}
