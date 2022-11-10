using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float timeToDestroy = 5f;
    float force = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        force = GameObject.Find("arduinoReceiver").GetComponent<ArduinoTransfer>().getForce();
        Vector3 upForce = new Vector3(0, 1, 0);
        GetComponent<Rigidbody>().AddForce((transform.forward * 10 + upForce) * force);
    }

    // Update is called once per frame
    void Update()
    {
        
        timeToDestroy -= Time.deltaTime;
        float seconds = Mathf.FloorToInt(timeToDestroy % 60);
        if (seconds <= 0)
        {
            timerUp();
        }
    }
    void timerUp()
    {
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), this.GetComponent<Collider>());
        }
    }
}
