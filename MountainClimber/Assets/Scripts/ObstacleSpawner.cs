using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject boulder;

    public bool killSpawner = false;

    public int secondsMin;
    public int secondsMax; // Exclusive but we add 1 so it is inclusive.

    private void Start()
    {
        StartCoroutine("spawnObstacle");
    }

    IEnumerator spawnObstacle()
    {
        while (!killSpawner)
        {
            Instantiate(boulder, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(secondsMin, secondsMax + 1));
        }
    } 
}
