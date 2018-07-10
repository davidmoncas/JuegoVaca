using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

	public Transform Player;
	public Vector3 CameraDistance;
	public GameObject[] pisos= new GameObject[3];

	private Vector3 moveTo;

	// Use this for initialization
	void Start () {
		moveTo=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0;i<pisos.Length;i++)
		{
			if (pisos[i].GetComponent<MeshCollider>().bounds.Contains(Player.position))
			{
				
				moveTo=pisos[i].transform.position+CameraDistance;
			}
		}

		this.transform.position=Vector3.Lerp(this.transform.position,moveTo,0.1f);
	}
}
