using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillingEnemy : MonoBehaviour
{
    public GameObject bullet;
    public Image frontGround;

    void Start()
    { 

     } 


    void Update()
    {
        void OnTriggerEnter (Collider other)
      {
        if (other.gameObject == bullet)
         {
            frontGround.fillAmount -= 0.33f ;
           print (frontGround.fillAmount);
         }

       }
    }
}
    