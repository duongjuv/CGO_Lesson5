using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteCarWithRigibory : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private float force;
    /*void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.back * force);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.forward * force);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * force);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * force);
        }
    }*/
    public float moveForce = 100f;
    public float jumpForce = 70f;
    public float rotationSpeed = 1000f;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Kiểm tra xem người chơi đang tiếp đất hay không
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Điều khiển di chuyển
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        rb.AddForce(moveDirection * moveForce);

        // Kiểm tra và xử lý nhảy
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Điều khiển xoay
        /*float rotationInput = Input.GetAxis("Rotate");
        rb.AddTorque(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);*/
    }
}



