using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class CubeController : OVRGrabbable
{
    private GameController scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("GameController").GetComponent<GameController>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Add to score when the player hits a cube
            GameController.score++;
            // Destroy the cube
            Destroy(gameObject);
        } 
        else if (collision.gameObject.name == "Character") {
            // Minus from NPC score when NPC collides with a cube
            GameController.npcScore--;
            // Destroy the cube
            Destroy(gameObject);
        }
    }

    //Override the base GrabBegin function
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        scoreManager.OnCubeGrabbed();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
