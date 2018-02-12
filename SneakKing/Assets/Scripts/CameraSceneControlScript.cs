using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSceneControlScript : MonoBehaviour {

    
    private Collider TriggerArea;
    private Transform Spot;
    public float _cameraLerpTime;
    public float _sceneTime=5f;
    private bool scene = false;
	// Use this for initialization
	void Awake () {
        TriggerArea = GetComponent<BoxCollider>();
        Spot = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
       
        scene = true;
        
        Debug.Log("Collision detected");
        
    }

    private void Update()
    {
        if (scene) { 
        TimedCamera();
        Destroy(this.gameObject);
        }
        
    }


    IEnumerator TimedCamera()
    {
        Debug.Log("Collision detected");
        Vector3 cameraMove = Vector3.Lerp(Camera.main.transform.position, Spot.position, _cameraLerpTime);
        Camera.main.transform.LookAt(cameraMove);
        

        yield return new WaitForSeconds(_sceneTime);

        

    }

}
