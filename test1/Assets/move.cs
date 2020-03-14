using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float moveSpeed;
    public float rotationSpeed;
    public float speed;
    public float jumpPower;
    public Transform feetTransform;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveRotation();
       // Jump();
    }
    void MoveRotation()
    {
        rb.AddRelativeForce(new Vector3(0, 0, Input.GetAxis("Vertical") * moveSpeed));
        rb.transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        float vertical = Input.GetAxis("Vertical"); //W S 上 下
        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);//W S 上 下

        /*   rb.AddRelativeForce(new Vector3(0, 0, Input.GetAxis("Vertical") * moveSpeed));
           rb.transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
        */

        //Vector3 movement = new Vector3(inputHorizontal, 0.0f, inputVertical,0.0f);
        //rb.AddForce(forward * speed);
    }
  /*  public void Jump()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }*/
}
