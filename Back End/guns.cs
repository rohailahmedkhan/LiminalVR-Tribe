using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class guns : MonoBehaviour
{
    public SteamVR_TrackedObject M = null;
   // public SteamVR_Controller.Device md;
    public float timer;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        M = GetComponent<SteamVR_TrackedObject>();
    }
    // Update is called once per frame
    void Update()
    {
        
        //float trigger = Input.GetAxis("trig");
        float trigger = Input.GetAxis("ControllerTrigger");
        timer += Time.deltaTime;
        if (Input.GetAxis("Fire1") > 0)
        {
            bulletShoot();

            timer = 0.0f;
        }
    }
    public void bulletShoot()
    {
        GameObject shoot = Instantiate(bullet, transform.position - 1.2f * transform.forward, transform.rotation);
    }
}
