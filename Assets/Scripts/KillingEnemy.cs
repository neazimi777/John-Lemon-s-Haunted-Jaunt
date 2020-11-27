using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingEnemy : MonoBehaviour
{
  public GameObject bullet;
   
    public Image frontGround ;
    bool m_enterBullrt = false;

    void Update()
    {
      
        amountOfHealth(m_enterBullrt);
    }

void OnTriggerEnter (Collider other)
{
    print("OnTriggerEnter");
        if (other.gameObject == bullet)
         {
           m_enterBullrt =true;
           
         }

}
  
 void amountOfHealth(bool m_enterBullrt)
 { 

  
  if ( m_enterBullrt && frontGround.fillAmount>=0)
   {  
    //  print(" update + m_enterBullrt");
      frontGround.fillAmount -= 0.33f;
      // Debug.Log( " frontGround.fillAmount; \t" + frontGround.fillAmount);

   }

}

}
      