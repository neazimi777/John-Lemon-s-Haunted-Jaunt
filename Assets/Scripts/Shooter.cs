using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    private int NumberOfBullets  ;
    public Text displayBullets;
    public GameObject bullet;
     private MeshRenderer BulletMeshRen ;
    void Start()
    {
        NumberOfBullets = 50 ;
        BulletMeshRen = bullet.GetComponent<MeshRenderer>();
         BulletMeshRen.enabled  = false;
       
     
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
          
          instBulletRigid.AddForce(Vector3.forward * 100f ,ForceMode.Impulse);
            Destroy(instBullet, 0.1f );
        }
          
        
    }

     
}
