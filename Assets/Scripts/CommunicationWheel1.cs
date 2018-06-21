﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CommunicationWheel1 : MonoBehaviour, IPointerDownHandler // required interface when using the OnPointerDown method.
{
    public void OnPointerDown(PointerEventData data)
    {
        RectTransform circle = GetComponent<RectTransform>();
        Vector2 localCursor;
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(circle, data.position, data.pressEventCamera, out localCursor))
            return;
       // Debug.Log("Distance from center: " + Vector2.Distance(localCursor, circle.sizeDelta));
        Debug.Log("LocalCursor: x: " + (localCursor.x / circle.sizeDelta.x) * 2 +" y:" + (localCursor.y / circle.sizeDelta.y) * 2);
    }
    // Use this for initialization
    void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {
		
	}


  
}
