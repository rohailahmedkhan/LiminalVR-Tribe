using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{public float damage=10f;
public float range=100f;
public float fire_Rate=15f;
public float impforce=30f;
public Camera fpsCam;
public ParticleSystem flash;
public GameObject go;
private float next_timetofire=0f;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update(){
    if((GvrControllerInput.ClickButtonDown)&&Time.time>=next_timetofire)
    {
        next_timetofire=Time.time+1f/fire_Rate;

        Shoot();
    }
}


void Shoot(){
    flash.Play();
    RaycastHit hit;
    if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit,range)){
        Debug.Log(hit.transform.name);
        Target target =hit.transform.GetComponent<Target>();
        if(target!=null){
            target.TakeDamage(damage);
        }
        if(hit.rigidbody!=null){
          //  hit.rigidbody.AddForce(hit.normal*impforce);
        }
        GameObject impactgo=Instantiate(go, hit.point,Quaternion.LookRotation(hit.normal));
        Destroy(impactgo,2f);
    }
}
}
