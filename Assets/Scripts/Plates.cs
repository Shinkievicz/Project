using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour
{
    public GameObject Button;
    public GameObject Plate;
    public Vector3 direction;
    public float acceleration;
    public Rigidbody rb;
    public bool PlateBool = false;
    public Vector3 CreateZone1 = new Vector3(-0.23f, 0.645076f, -8.54f);
    public Vector3 CreateZone2 = new Vector3(-0.7f, 0.22f, -7.82f);
    public float timer = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        //  if (Input.GetMouseButtonDown(0))
        //  {
        //     // GetComponent<Rigidbody>().useGravity = true;
        //      rb.AddForce(direction.normalized * acceleration, ForceMode.Impulse);
        //
        //  }
        if (PlateBool == true)
        {
            // GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Plates>().direction.x = Random.Range(-0.4f, 0.4f);
            rb.AddForce(direction.normalized * acceleration, ForceMode.Impulse);
            PlateBool = false;

        }
        {
            // if (Input.GetMouseButtonDown(1))
            // {
            //     Instantiate(Plate, new Vector3(-0.23f, 0.645076f, -8.54f), Quaternion.identity);
            //
            //
            // }
            //rb.AddForce(direction.normalized * acceleration);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            Destroy(Plate,1);
            //Destroy(GetComponent<Rigidbody>(),1);
            //Destroy(gameObject, 1);
            Debug.Log("Ground");
        }
    }
    public void FlyPlate()
    {
        bool Boolean = (Random.value > 0.5f);
        if (Boolean is true)
        {
            Instantiate(Plate, CreateZone1, Quaternion.identity);
        }
        else
        {
            Instantiate(Plate, CreateZone2, Quaternion.identity);
            Plate.GetComponent<Rigidbody>().useGravity = true;
            PlateBool = true;
        }
    }
}
