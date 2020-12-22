using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //================================================================================
    // Public Variables ==============================================================
    //================================================================================
    public Rigidbody Player;
    public float speed = 1000f;

    //================================================================================
    // Start is called before the first frame update =================================
    //================================================================================
    void Start()
    {
        
    
    }
    //================================================================================
    // Update is called once per frame ===============================================
    //================================================================================
    void FixedUpdate()
    {
        // Move Up
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            Player.AddForce(0, 0, speed * Time.deltaTime);
        }
        // Move Down
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            Player.AddForce(0, 0, -speed * Time.deltaTime);
        }
        // Move Left
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Player.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        // Move Right
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Player.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }
}
