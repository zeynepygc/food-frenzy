using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    //destroy food and animals when they move out of our view

    private float topBound = 30;
    private float lowBound = -10;
    private float sideBound = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object goes past the players view, remove it
        if(transform.position.z > topBound)  
        {
            Destroy(gameObject);
        }

        else if(transform.position.z < lowBound)
        {
            Debug.Log("Game Over!");  //ekranýn sol altýndaki kýsýmda görünecek
            Destroy(gameObject);
        }

        if(transform.position.x > sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        else if(transform.position.x < -sideBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}
