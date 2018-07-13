﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    GameObject player;
    private GameObject StonePrefab;
    private GameObject bc;
   
    IEnumerator OnTriggerEnter(Collider collider)
    {
        if (!player || (player && collider.gameObject.tag == "player"))
        {
            PdAPI pd = GameObject.Find("PureData").GetComponent<PdAPI>();
            double[] pos = new double[] { 0.1, 0.5 };
            Destroy(this.gameObject);
            StonePrefab = GameObject.FindGameObjectWithTag("Projectile");
            DestroyObject(StonePrefab);
            pd.changeValue(pos);
            GameCount.scoreValue += 10;
            pd.playAudio();
            Debug.Log(collider.gameObject);
            yield return new WaitForSeconds(0.7f);
        }
       
        
    }
}