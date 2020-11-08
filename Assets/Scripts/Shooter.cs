using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private int NumberOfBullets;
    
    void Start()
    {
         NumberOfBullets = 50;
    }
    void Update()
    { 
        print("this is update ");
        
        if (Input.GetKey(KeyCode.Space))
        {
            print("space key was pressed");
            NumberOfBullets--;
            print(NumberOfBullets);
        }
    }
}
