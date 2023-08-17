using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("AAA");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Xuong");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Trai");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Phai");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Chuot Trai");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Chuot phai");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("Chuoi giua");
        }

    }
}
