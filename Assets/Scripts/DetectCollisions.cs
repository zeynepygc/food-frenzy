using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)  //overriding this method from MonoBeh class
    {
       if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }

        else
        {
            Destroy(gameObject);        //for animal
            Destroy(other.gameObject);  //for food
        }
    }


}
