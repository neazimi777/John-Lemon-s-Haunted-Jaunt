using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    private int NumberOfBullets;
 public Text displayBullets;

    
    void Start()
    {
         NumberOfBullets = 50;
    }
    void Update()
    { 
       // print("this is update ");
            displayBullets.text = NumberOfBullets.ToString();
        if (Input.GetKeyDown("space") &&  NumberOfBullets > 0 )
        {
           // print("space key was pressed");
            NumberOfBullets--;
           // print(NumberOfBullets);
        }
    }
}
