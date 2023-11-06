using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    public float vitesse = 10.0f;
    public float vitesseRotation = 100.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float transaltion = Input.GetAxis("Vertical") * vitesse;
        float rotation = Input.GetAxis("Horizontal") * vitesseRotation;

        transaltion *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, transaltion);
        transform.Rotate(0, rotation, 0);
    }
}
