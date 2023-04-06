using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OldMan : MonoBehaviour
{
    [SerializeField] private GameObject ragdoll;
    Rigidbody rb;
    Vector3 direction;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.forward;
        rb.AddForce(direction, ForceMode.VelocityChange);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(ragdoll, transform.position, transform.rotation);

        }
    }
}
