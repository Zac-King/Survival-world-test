using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour {


    GameObject inventory = null;
    public void addItem (GameObject o)
    {
        if(inventory == null)
            inventory = o;
    }

    public void dropItem()
    {
        inventory.SetActive(true);
        inventory.transform.position = transform.position + transform.forward * 1.5f;

        Rigidbody rb = inventory.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * rb.velocity.magnitude * 2; 
            

        inventory = null;
        //inventory.RemoveAt(0);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.H))
        {
            dropItem();
        }

	}
}
