using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //an array of gameobjects, which we call animalPrefabs
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 15;  //spawn olacaklarý yerin x koordinatý için 
    private float spawnPosZ = 20;  //same w Z axis

    public float sideSpawnMinZ = 0;
    public float sideSpawnMaxZ = 15;
    public float sideSpawnX = 15;

    private float startDelay = 2;  //oyun baþladýktan 2 saniye sonra

    private float spawnInterval = 1.5f;    //spawn every 1.5 secs

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  //repeatedly call SpawnRanAni, 2.saniyeden itibaren, her 1.5 saniyede 

        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);

        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);

    }
    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); //(0,3) yazmakla ayný þey. 0,1,2 deðerlerini alabilir, 3 yazýyoruz ama onu saymýyor

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);  //x koordinatý -20,20 arasý y'si 0 z koordinatý da 20 olan yerlerde spawn etmek için

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }


    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));

    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));

    }
}
