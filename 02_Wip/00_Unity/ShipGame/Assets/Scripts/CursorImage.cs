﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorImage : MonoBehaviour {

	//Put an image intead of the cursor
    public Texture2D cursor;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(cursor,Vector2.zero,CursorMode.Auto);
	}

}
