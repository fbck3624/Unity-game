using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{

    private Transform m_transform;

    // Use this for initialization
    void Start()
    {
        m_transform = GameObject.Find("DoorFather").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_transform.Rotate(Vector3.up * 100);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            m_transform.Rotate(Vector3.down * 100);
        }
    }
}

