using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Instantiate : MonoBehaviour
{
    Stack Set_0 = new Stack(), Set_1 = new Stack(), Set_2 = new Stack(),
        Set_3 = new Stack(), Set_4 = new Stack(), Set_5 = new Stack(), Set_6 = new Stack();
    
    // Start is called before the first frame update
    void Start()
    {
        // Adding Elements to Stack
        if (AddPositions()) { Debug.Log("Monster Loading: Success"); }
        
    }

    // Update is called once per frame
    void Update()
    {        
    }

    public bool AddMonster(string stage)
    {
        try {
            GameObject monster = GameObject.Find("M1");
            Vector3 pos = new Vector3();
            if (stage == "Set_0") { pos = (Vector3)Set_0.Pop(); }
            if (stage == "Set_1") { pos = (Vector3)Set_1.Pop(); }
            if (stage == "Set_2") { pos = (Vector3)Set_2.Pop(); }
            if (stage == "Set_3") { pos = (Vector3)Set_3.Pop(); }
            if (stage == "Set_4") { pos = (Vector3)Set_4.Pop(); }
            if (stage == "Set_5") { pos = (Vector3)Set_5.Pop(); }
            if (stage == "Set_6") { pos = (Vector3)Set_6.Pop(); }

            if (CreateMonster(monster, pos)) { return true; }
            else { return false; }

        }
        catch(System.Exception) { return false; }
    }

    bool CreateMonster(GameObject monster, Vector3 position)
    {
        // Position Assignment
        var player = GameObject.Find("Player");

        // Instantiate Object
        var RandObj = Instantiate(monster, position, Quaternion.identity);

        // Attach Tag
        RandObj.tag = "RandMonster";
        // RandObj.GetComponent<Renderer>().enabled = true;
        // RandObj.GetComponent<Rigidbody>().mass = level.MonsterMass;
        RandObj.isStatic = false;
        // Attach Script
        RandObj.AddComponent<Monster>();
        RandObj.name = "CMonster";

        return true;
    }

    bool AddPositions()
    {
        try { 
            // Set 0
            Set_0.Push(new Vector3(60.4f, -0.005f, -30.4f));
            Set_0.Push(new Vector3(57.5f, 0.001f, -12.9f));
            Set_0.Push(new Vector3(57.5f, 0.0299965f, -22.5f));
            Set_0.Push(new Vector3(48.7f, 0.029999f, -22.6f));
            Set_0.Push(new Vector3(44.8f, 0.029998f, -31f));
            Set_0.Push(new Vector3(40.4f, 0.03f, -23.11f));
            Set_0.Push(new Vector3(39.1f, 0.0299981f, -28.8f));
            Set_0.Push(new Vector3(34.8f, 0.8f, -18.5f));
            Set_0.Push(new Vector3(29.5f, -0.009f, -20.989f));
            Set_0.Push(new Vector3(13.89996f, -0.024f, -29.86f));
            Set_0.Push(new Vector3(12.6f, 0.012f, -18.92f));
            Set_0.Push(new Vector3(-15.18f, 1.25f, -35.78f));
            Set_0.Push(new Vector3(9.478151f, 0.058f, -19.13f));
            Set_0.Push(new Vector3(2.06f, 0.008f, -28.48f));
            Set_0.Push(new Vector3(-2.88f, -0.007f, -20.78f));
            Set_0.Push(new Vector3(-9.36f, 0.25f, -16.99f));
            Set_0.Push(new Vector3(-9.73f, 0.0300152f, -33.77f));

            // Set 1
            Set_1.Push(new Vector3(163.42f, -0.009f, -27.194f));
            Set_1.Push(new Vector3(153.28f, 0.055f, -19.44f));
            Set_1.Push(new Vector3(155.87f, -0.016f, -28.61f));
            Set_1.Push(new Vector3(147.11f, -0.008f, -31.002f));
            Set_1.Push(new Vector3(123.56f, 0.801f, -31.79f));
            Set_1.Push(new Vector3(121.92f, 0.556f, -31.00f));
            Set_1.Push(new Vector3(98.137f, 0.576f, -19.674f));
            Set_1.Push(new Vector3(92.022f, 0.477f, -20.63f));
            Set_1.Push(new Vector3(89.31f, 0.003f, -22.82f));
            Set_1.Push(new Vector3(82.51f, 0.003f, -30.29f));
            Set_1.Push(new Vector3(74.19f, 0.003f, -31.29f));

            // Set 2
            Set_2.Push(new Vector3(154.62f, -0.009f, 154.62f));
            Set_2.Push(new Vector3(162.47f, -0.009f, -46.803f));
            Set_2.Push(new Vector3(161.86f, -0.009f, -41.64f));
            Set_2.Push(new Vector3(155.64f, -0.009f, -39.7f));
            Set_2.Push(new Vector3(151.59f, -0.009f, -37.16f));
            Set_2.Push(new Vector3(162.089f, -0.009f, -36.02f));

            // Set 3
            Set_3.Push(new Vector3(221.69f, -0.009f, -69.92f));
            Set_3.Push(new Vector3(194.20f, -0.009f, -70.92f));
            Set_3.Push(new Vector3(184.48f, -0.009f, -60.35f));
            Set_3.Push(new Vector3(179.03f, -0.009f, -71.46f));
            Set_3.Push(new Vector3(174.92f, -0.009f, -69.86f));
            Set_3.Push(new Vector3(170.88f, -0.009f, -64.9f));

            // Set 4
            Set_4.Push(new Vector3(221.34f, -0.005f, -41.38f));
            Set_4.Push(new Vector3(214.37f, 0.232f, -41.38f));
            Set_4.Push(new Vector3(229.89f, 0.000f, -55.17f));
            Set_4.Push(new Vector3(214.37f, 0.000f, -57.96f));

            // Set 5
            Set_5.Push(new Vector3(265.45f, 0.005f, -36.69f));
            Set_5.Push(new Vector3(258.7f, 0.005f, -39.75f));
            Set_5.Push(new Vector3(256.96f, 0.010f, -27.92f));
            Set_5.Push(new Vector3(242.55f, 0.015f, -40.42f));
            Set_5.Push(new Vector3(234.00f, 0.020f, -29.22f));
            Set_5.Push(new Vector3(225.98f, 0.026f, -31.31f));

            // Set 6
            Set_6.Push(new Vector3(254.99f, 0.005f, 20.13f));
            Set_6.Push(new Vector3(263.87f, 0.005f, 20.13f));
            Set_6.Push(new Vector3(262.87f, 0.010f, 05.57f));
            Set_6.Push(new Vector3(252.42f, 0.015f, -6.31f));
            Set_6.Push(new Vector3(266.14f, 0.020f, -13.69f));
            Set_6.Push(new Vector3(251.51f, 0.020f, -18.93f));
            Set_6.Push(new Vector3(256.52f, 0.020f, -21.70f));
            Set_6.Push(new Vector3(266.51f, 0.020f, -34.98f));

            return true;
        }
       catch(System.Exception)
        { return false; }
    }

}
