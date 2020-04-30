using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject boulder;

    private bool killSpawner = false;

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
            GameObject randomBoulder = boulder;
            float randomScale = Random.Range(1f, 3f);
            randomBoulder.gameObject.transform.localScale = new Vector3(randomScale, randomScale, 1f);
            Instantiate(randomBoulder, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(secondsMin, secondsMax + 1));
        }
    } 
}
