using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    bool Canjump = false;
    public Rigidbody rigidbody;
    public float speed = 10f;
    public float jump = 11;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Canjump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Canjump = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Canjump = true;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.wKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.forward * Time.fixedDeltaTime * speed, ForceMode.Force);

        }
        if (Keyboard.current.sKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.back * Time.fixedDeltaTime * speed, ForceMode.Force);

        }
        if (Keyboard.current.aKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.left * Time.fixedDeltaTime * speed, ForceMode.Force);

        }
        if (Keyboard.current.dKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.right * Time.fixedDeltaTime * speed, ForceMode.Force);
        }
        if (Keyboard.current.spaceKey.IsPressed()&& Canjump)
        {
            rigidbody.AddForce(Vector3.up * jump * Time.fixedDeltaTime, ForceMode.Force);
        }
    }
}
