using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /*[SerializeField] public Transform target;
    public Vector3 offset;
    private float smoothedSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        *//*transform.position = target.transform.position - offset;
        transform.LookAt(target.transform.position);*//*
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Cập nhật vị trí của target dựa trên input
        if (moveDirection.magnitude > 0.1f)
        {
            Vector3 targetDirection = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * moveDirection;
            target.Translate(targetDirection * smoothedSpeed * Time.deltaTime, Space.World);
        }

        // Cập nhật vị trí của camera để theo dõi target
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothedSpeed * Time.deltaTime);*//*

    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothedSpeed * Time.deltaTime);

        Quaternion quaternion = Quaternion.LookRotation(offset, Vector3);
        //transform.rotation = quaternion;
        transform.position = target.position - offset;
       // transform.Translate (smoothedPosition);
        transform.LookAt(target.position);
    }*/
    public Transform targetObject; // GameObject mà camera sẽ theo dõi
    public float smoothSpeed = 0.125f; // Tốc độ di chuyển mượt của camera
    public Vector3 offset; // Khoảng cách tương đối giữa camera và đối tượng
    private void Start()
    {
        offset = targetObject.position - transform.position;
    }
    private void LateUpdate()
    {
        if (targetObject == null)
        {
            Debug.LogWarning("Target object is not assigned for camera follow.");
            return;
        }

        Vector3 desiredPosition = targetObject.position - offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(targetObject);
        //transform.rotation = targetObject.rotation;
        
    }
}
