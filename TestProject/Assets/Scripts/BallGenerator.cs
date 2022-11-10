using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("eachBall");
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator eachBall()
    {
        while (true)
        {
            GameObject newBall = Instantiate(ball, transform.parent.position + new Vector3(0, 0, 5), Quaternion.identity, transform.parent);
            yield return new WaitForSeconds(1);
        }
    }
}
