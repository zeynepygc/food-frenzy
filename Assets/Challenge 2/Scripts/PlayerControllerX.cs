using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCoolDown = 1.5f;
    private bool canSpawn = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
            Invoke("ResetSpawn", spawnCoolDown);
        }
    }

    void ResetSpawn()
    {
        canSpawn = true;
    }
}
