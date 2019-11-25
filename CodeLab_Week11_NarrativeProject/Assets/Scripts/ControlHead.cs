using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHead : MonoBehaviour
{
    public GameObject Head;
    public float moveAmount =10f;
    public float maxZ= 10f;
    public GameObject GameOverObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            print("I'm moving forward");
            if (transform.position.z >= maxZ){
            transform.position = transform.position - new Vector3(0, 0, moveAmount);
            }
            else{
                GameOverObject.SetActive(true);
            }
        }
    }
}
