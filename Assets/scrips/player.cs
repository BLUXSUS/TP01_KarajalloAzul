using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    bool canjump = false;
    public Rigidbody rigidbody;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            canjump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            canjump = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            canjump = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Keyboard.current.wKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);

        }
        if (Keyboard.current.sKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.back * Time.fixedDeltaTime * speed, ForceMode.Impulse);

        }
        if (Keyboard.current.aKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.left * Time.fixedDeltaTime * speed, ForceMode.Impulse);

        }
        if (Keyboard.current.dKey.IsPressed())
        {
            rigidbody.AddForce(Vector3.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);

        }
        
    }
}
