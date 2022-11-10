using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipGenerator : MonoBehaviour
{
    public GameObject spaceShip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("newShip");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator newShip()
    {
        while (true)
        {
            Vector3 newPos = new Vector3(transform.position.x + Random.Range(-10f, 10f), transform.position.y, transform.position.z);
            GameObject ship = Instantiate(spaceShip, newPos, spaceShip.transform.rotation);
            
            yield return new WaitForSeconds(1);
        }
    }
}
