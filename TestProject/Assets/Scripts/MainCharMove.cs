using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharMove : MonoBehaviour
{
    float HorizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = GameObject.Find("arduinoReceiver").GetComponent<ArduinoTransfer>().getHorizontalMove() * 0.01f;
        transform.position += new Vector3(HorizontalMove, 0, 0);
    }
}
