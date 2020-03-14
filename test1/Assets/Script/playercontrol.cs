using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;
    public float rotationSpeed;
    public float jumppower;
    public Transform feetTransform;


    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody>();
        rb.freezeRotation = true;       //禁止轉動
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAndRotation();
        Jump();
    }
    public void Jump()
    {
        if(Physics.Raycast(feetTransform.position,Vector3.down,2f)&&Input.GetKeyUp(KeyCode.Space)){
            rb.AddForce(new Vector3(0,jumppower,0),ForceMode.Impulse);
        }

    }
    void MoveAndRotation()
    {
        rb.AddRelativeForce(new Vector3(0,0,Input.GetAxis("Vertical")*moveSpeed));          //相對位置
        rb.transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
        //尤拉角


    }
}
