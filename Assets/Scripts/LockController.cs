﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockController : MonoBehaviour {
    public Button[] mybuttons;
    public Sprite lock_image;
    public int level;
    public static bool realAttemptBall; //Refresh Real AttemptBall
    // Use this for initialization
    void Start () {
        realAttemptBall = true;
        print("OOOOOOOOOOOkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
        level = PlayerPrefs.GetInt("level", LivesCount.levelIncre);
        for (int i = level; i < mybuttons.Length; i++)
        {
            mybuttons[i].GetComponent<Image>().sprite = lock_image;
            mybuttons[i].GetComponent<Button>().interactable = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
       

    }
    public void loadByIndex(int sceneIndex)
    {
        realAttemptBall = true;
        StaticClass.CrossSceneInformation = sceneIndex.ToString();
        SceneManager.LoadScene(sceneIndex);
    }
    public static class StaticClass
    {
        
        public static string CrossSceneInformation { get; set; }
    }
 
}
