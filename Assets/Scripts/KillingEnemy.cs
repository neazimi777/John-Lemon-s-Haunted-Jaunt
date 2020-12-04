using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillingEnemy : MonoBehaviour
{
    public Image frontGround;

     public GameObject bullet;

   


void OnTriggerEnter (Collider other)
{ 
        if (other.gameObject.tag == "bullet")
         {
            
             frontGround.fillAmount -= 0.25f;
             
            // Debug.Log(" frontGround.fillAmount" +  frontGround.fillAmount);
         }

        if (frontGround.fillAmount==0)
            {
                   Destroy(gameObject);
               
            }
  
}  
}