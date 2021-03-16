using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSeikaiScript : MonoBehaviour
{
    // Start is called before the first frame update

    int speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
            this.transform.position += new Vector3(speed*Time.deltaTime,0,0);
        }

        if(Input.GetKey("left")){
            this.transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        }
        if(Input.GetKey("up")){
            this.transform.position += new Vector3(0,0,speed*Time.deltaTime);
        }
        if(Input.GetKey("down")){
            this.transform.position -= new Vector3(0,0,speed*Time.deltaTime);
        }
    }
}
