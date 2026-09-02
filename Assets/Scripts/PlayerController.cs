//============================================================
//Author:  Marcel Dahmoun
//Date:    09-02-2026
//Desc:    Handles all player Behavior
//Attach:  Player Object
//============================================================

using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    //This is the rigidbody that was added to the player
    //We will make the connection between code and Unity in the Start() function
    private Rigidbody2D rb;
    public float horizontalSpeed;
    public float jumpForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //The only reason I can get this component is because the rigidbody2d is attached to the player
        //and this script is attached to the player
        rb = GetComponent<Rigidbody2D>();

        Debug.Log("Rigidbody found");
    }

    // Update is called once per frame
    void Update()
    {
        //call the movePlayerLateral() function to get player movement
        movePlayerLateral();
    }



    private void movePlayerLateral()
    {
        //if A/D/->/<- are pressed move the player accordingly
        //"Horizontal" is defined in the basic unity input system. this can be found in the
        //project settings
        //The line below will either return
        //0 - no button pressed
        //1 - right arrow or d pressed
        //-1 - left arrow or a pressed

        //determine if the player pressed a button that should move their character
        float inputHorizontal = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(horizontalSpeed * inputHorizontal, rb.linearVelocity.y);
    }
}
