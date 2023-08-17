using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoRigidbody : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalMove, 0f, verticalMove).normalized;

        rb.AddForce(move * force *Time.deltaTime );
    }
}
