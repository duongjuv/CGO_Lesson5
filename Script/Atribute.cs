using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExSeri : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int speed;
    [Header("Player Game")]
    public string playerGame;
    [Range(0, 100)]
    public int speeds;
    

    // Update is called once per frame
}
