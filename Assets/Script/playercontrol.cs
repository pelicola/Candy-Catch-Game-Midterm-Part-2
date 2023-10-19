using UnityEngine;


public class playercontrol : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10f;
    private bool isFacingRight = true; //Starts off with standing right


    [SerializeField] private Rigidbody2D _rb; //rigidbody
    [SerializeField] private LayerMask groundLayer; //for our ground layer of our tiles


    void Update(){


        Flip(); //check for flip everytime


        horizontalInput = Input.GetAxisRaw("Horizontal"); //Left and right press

    }


    private void FixedUpdate(){


        _rb.velocity = new Vector2(horizontalInput * speed, _rb.velocity.y); //setting x component of rb to horinput * speed.


    }



    private void Flip(){


        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f){ //If Mario is standing right direction and the input goes past 0 or below 0.
       
            isFacingRight = !isFacingRight; //set to oppo value
            Vector3 localScale = transform.localScale; //set the x,y,components of localScale
            localScale.x *= -1f; //multiplication assignment operator, it multiplies the scale by -1
            transform.localScale = localScale;
        }
    }
}
