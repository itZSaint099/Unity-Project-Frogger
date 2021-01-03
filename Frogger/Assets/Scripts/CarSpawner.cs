using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;

    public float SpawnDelay = .3f;

    float TimeToNextSpawn = 0f;

    public Transform[] SpawnPoints;

    // Update is called once per frame
    void Update()
    {
        if(TimeToNextSpawn <= Time.time)
        {
            SpawnCar();
            TimeToNextSpawn = Time.time + SpawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);
        Transform SpawnPoint = SpawnPoints[randomIndex];

        Instantiate(car, SpawnPoint.position, SpawnPoint.rotation);
    }
}
