using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //saða sola bastýðýnda o inputu alýcak. bw -1 and 1
    public float horizontalInput;
    public float verticalInput;

    public float speed = 10.0f;

    public float xRange = 10.0f;  //boundary
    public float zMin = -4.0f;
    public float zMax = 15.0f;


    public GameObject projectilePrefab;  //value yerine (int, float etc) gameobject'in kendisini store ediyoruz
    public Transform projectileSpawnPoint;  //food'un spawn olacaðý yerin konumu için



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -xRange)  //bu boundary deðerinden sola gidemesin, yerinde kalsýn
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        if (transform.position.z < zMin)  //bu boundary deðerinden aþaðý gidemesin, yerinde kalsýn
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }

        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile at the player's location with the prefab's rotation
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);

        }


        horizontalInput = Input.GetAxis("Horizontal");

        //to be able to move the player left-right over that speed over a certain time
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);



        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
