using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public int NumberOfBullets  ;
    public Text displayBullets;
    public GameObject bullet;
    public GameObject player;
    private AudioSource someSound;

     private MeshRenderer BulletMeshRen ;
    void Start()
    {
        NumberOfBullets = 50 ;
        BulletMeshRen = bullet.GetComponent<MeshRenderer>();
         BulletMeshRen.enabled  = false;
        someSound = GetComponent<AudioSource>();
     
    }
    void Update()
    { 
          BulletMeshRen.enabled  = false;
       
            displayBullets.text = NumberOfBullets.ToString();
        if (Input.GetKeyDown("space") &&  NumberOfBullets > 0 )
        {  BulletMeshRen.enabled  = true;
           NumberOfBullets--;
           GameObject instBullet = Instantiate(bullet,transform.position,Quaternion.identity);
           Rigidbody instBulletRigid = instBullet.GetComponent<Rigidbody>();
         
         instBulletRigid.AddForce(player.transform.forward * 1000f ,ForceMode.Force);
        
            Destroy(instBullet, 1.0f );

            someSound.Play();
    
        }
        
       if(Input.GetKeyDown("space") &&  NumberOfBullets == 0 )
         { 
            NumberOfBullets += 50;
          }
                
        if (Input.GetKeyUp("space")) 
         {
                someSound.Stop();
         }

          
        
    }

     
}
