using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class ArduinoTransfer : MonoBehaviour
{
    //SerialPort sp = new SerialPort("COM11", 115200);
    float ardForce = 1000f;
    float ardHorizontalMove = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        //sp.Open();

    }

    // Update is called once per frame
    void Update()
    {
        /*        string v = sp.ReadLine();
                float irCount = 0;
                if (float.TryParse(v, out irCount))
                {
                    //use the number, force is bend sensor, fsr is horizontal move.
                    Debug.Log(irCount);

                }*/

    }
    public float getForce()
    {
        return ardForce;
    }
    public float getHorizontalMove()
    {
        return ardHorizontalMove;
    }
}