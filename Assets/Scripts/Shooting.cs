using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Components/Shooting")]
public class Shooting : MonoBehaviour
    
{
    public Vector3 markPositon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay( new Vector3(Screen.width/2,Screen.height/2,0));
        if (Physics.Raycast(ray, out hit)) 
        {
            if (hit.collider.tag == ("Shooted")) {
               // if (Input.GetKeyDown(KeyCode.Mouse0)) 
               // {
                    Destroy(hit.collider.gameObject);
                //}
            }
        }
    }
}
