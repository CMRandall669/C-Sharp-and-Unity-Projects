using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{

    public float speed = 0.0f;
    public float distance = 0.00f;
    public float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = distance / time;
        print("You are traveling at " + speed + "MPH");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
