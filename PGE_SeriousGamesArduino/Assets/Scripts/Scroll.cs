using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scroll : MonoBehaviour {

    public Material material;
    public float xVel = 0.1f;
    Vector2 offset;

	// Use this for initialization
	void Start () {
        material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        offset = new Vector2(xVel, 0);
        material.mainTextureOffset += offset * Time.deltaTime;
	}
}
