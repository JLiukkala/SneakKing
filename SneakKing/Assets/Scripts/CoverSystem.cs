using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverSystem : MonoBehaviour {


    public Transform Player;
    public float _rayHeight = 0.3f;
    public float _rayWidth = 0.3f;
    private Vector3 offset;
    private Vector3 sideOffsetLeft;
    private Vector3 sideOffsetRight;



    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void LateUpdate () {
        
        offset = new Vector3(0, _rayHeight, 0);
        sideOffsetLeft = new Vector3(-_rayWidth, _rayHeight, 0);
        sideOffsetRight = new Vector3(_rayWidth, _rayHeight, 0);

        GetCover();
	}


    /// <summary>
    /// Three raycasts to look for cover, 
    /// look for left and right 
    /// if there is no more cover when in cover to stop and initiate peeking
    /// 
    /// </summary>
    private void GetCover()
    {

        //Fix the offsets god dang it!
        RaycastHit ray;
        Debug.DrawRay(Player.transform.position+offset, -Player.transform.forward, Color.red);

        Debug.DrawRay(Player.transform.position + sideOffsetLeft, -Player.transform.forward, Color.green);

        Debug.DrawRay(Player.transform.position + sideOffsetRight, -Player.transform.forward, Color.yellow);

    }
}
