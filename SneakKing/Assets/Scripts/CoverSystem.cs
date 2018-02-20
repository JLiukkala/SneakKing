using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverSystem : MonoBehaviour {


    public Transform Player;
    public float _rayHeight = 0.15f;
    public float _rayWidth = 0.15f;
    private Vector3 offset;
    private Vector3 helperOffset;
    GameObject helper;
    

    // Use this for initialization
    void Start () {
        helper = GameObject.CreatePrimitive(PrimitiveType.Cube);
        helper.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        helper.active = false;
        helper.layer = 8;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        
        offset = new Vector3(0, _rayHeight, 0);
        
        GetCover();
	}

    private void GetCover()
    {
        RaycastHit ray;
        Debug.DrawRay(Player.transform.position+offset, Player.transform.forward, Color.red);

        if (Physics.Raycast(Player.transform.position + offset, Player.transform.forward,out ray ,3f))
        {
            helper.active = true;
            helper.transform.position = ray.transform.position+helperOffset;
        }  else
        {
            helper.active = false;
        }
    }
}
