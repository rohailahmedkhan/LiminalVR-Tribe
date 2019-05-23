using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
  
  public float health =50f;
  public void TakeDamage(float amount){
	  health-=amount;
	  
  }
  
	 void OnTriggerEnter(Collider collision)
    {
if(health<=0f && collision.gameObject.tag == "ps"){
		  	  Destroy(gameObject);

	  }
}
  
  
  }
