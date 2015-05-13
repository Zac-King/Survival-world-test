using UnityEngine;
using System.Collections;

public class BaseInteractObject : MonoBehaviour {

    public GameObject interactableObject;
    private bool drawGUI = false;
    private GameObject player;
    public string objectName;
    public string objectPrompt;


    void Start()
    {
        if (objectPrompt == null)
            objectPrompt = "e";
    }

    // Update is called once per frame
    void Update()
    {
        if (drawGUI && Input.GetKeyDown( objectPrompt ) && interactableObject.activeSelf)
        {
            //Destroy(interactableObject);
            // Access player's inventory
            // Add this object to that and set it to inactive.
                // In the player script or the inventory script, you can do whatever you want to the inventory....
            drawGUI = false;
            player.GetComponent<InventoryScript>().addItem(interactableObject);
            interactableObject.SetActive(false);
            print("It worked");
        }
    }


    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            drawGUI = true;
            player = c.gameObject;
        }
    }
    void OnTriggerExit()
    {
        drawGUI = false;
    }
    void OnGUI()
    {
        Rect a = new Rect(Screen.width / 2 - 50, 200, 102, 22);
        if (drawGUI)
        GUI.Box(a, "Press "+ objectPrompt.ToUpper() + " to use " + objectName);
    }
}
