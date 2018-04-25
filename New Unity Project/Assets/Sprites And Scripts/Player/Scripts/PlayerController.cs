﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Color[] Colors;
    public int CurrentColor;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { //If the space bar is pushed down.
            if(CurrentColor < Colors.Length)
            {
                spriteRenderer.color = Colors[CurrentColor];
                CurrentColor = CurrentColor + 1;
            }
            else
            {
                CurrentColor = 0;
                spriteRenderer.color = Colors[CurrentColor];
            }


        }

	}
}