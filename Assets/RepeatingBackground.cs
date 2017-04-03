using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundgorizontalLenght;



	// Use this for initialization
	void Start () {
        groundCollider = GetComponent<BoxCollider2D>();
        groundgorizontalLenght = groundCollider.size.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundgorizontalLenght)
        {
            RepositionBackgroud();
        }
	}

    private void RepositionBackgroud()
    {
        Vector2 groundOffset = new Vector2(groundgorizontalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
