using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverTouch : MonoBehaviour {
 
 
 private Vector3 pos;
 private Vector3 goTo;


 void Start()
 {
	 
	 goTo=this.transform.position;
 }

 void Update()
 {

	 if (Input.GetMouseButton(0)) 
	 {
		
		goTo=GetWorldPositionOnPlane(Input.mousePosition , 0f);
		
	 }
	
	
	if ( Mathf.Abs( Vector3.Distance(goTo,this.transform.position) ) > 0.1f )
	{
		this.transform.position+=(goTo-this.transform.position).normalized*Time.deltaTime*10;
	}

 }
 public Vector3 GetWorldPositionOnPlane(Vector3 screenPosition, float y) {
     Ray ray = Camera.main.ScreenPointToRay(screenPosition);
     Plane xy = new Plane(Vector3.up, new Vector3(0, y, 0));
     float distance;
     xy.Raycast(ray, out distance);
     return ray.GetPoint(distance);
 }

}
