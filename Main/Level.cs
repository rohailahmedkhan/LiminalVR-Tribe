using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public interface ILevel
{
    float PlayerSpeed { set; get; } // To get Players Speed for Specific Level
    float MonsterSpeed { set; get; } // To get Players Speed for Specific Level
    GameObject EndObject { set; get; } // To get mesh End Object
    string SceneName { set; get; } // To set Scene Name based on Levels
    int MaxMonsters { set; get; } // Number of Maximum Monsters in a Level
    int CloneMonsters { set; get; } // Number of Monsters currently in a game
    int MonsterLife { set; get; } // Setting Monsters Mass
}

public class Level : ILevel
{
    string scene;
    float speed, mspeed;
    GameObject target, playerN;
    int maxMonsters, cloneMonsters, monsterLife;

    public Level (string LevelName = "Set_0")
    {        
        // Updating the current set name
        this.SceneName = LevelName;

        // Updates Specific to Level
        switch (LevelName) {
            case "Set_0":
                this.speed = 1.25f;
                this.mspeed = 0.00f;
                this.maxMonsters = 3;
                this.cloneMonsters = 0;
                this.monsterLife = 2;
                break;
            case "Set_1":
                this.speed = 1.5f;
                this.mspeed = 0.10f;
                this.maxMonsters = 4;
                this.cloneMonsters = 0;
                this.monsterLife = 6;
                break;
            case "Set_2":
                this.speed = 1.75f;
                this.mspeed = 2.0f;
                this.maxMonsters = 5;
                this.cloneMonsters = 0;
                this.monsterLife = 8;
                break;
            case "Set_3":
                this.speed = 1.75f;
                this.mspeed = 0.30f;
                this.maxMonsters = 6;
                this.cloneMonsters = 0;
                this.monsterLife = 8;
                break;
            case "Set_4":
                this.speed = 2f;
                this.mspeed = 0.40f;
                this.maxMonsters = 7;
                this.cloneMonsters = 0;
                this.monsterLife = 8;
                break;
            case "Set_5":
                this.speed = 2.5f;
                this.mspeed = 0.50f;
                this.maxMonsters = 7;
                this.cloneMonsters = 0;
                this.monsterLife = 8;
                break;
            case "Set_6":
                this.speed = 3.0f;
                this.mspeed = 0.60f;
                this.maxMonsters = 8;
                this.cloneMonsters = 0;
                this.monsterLife = 8;
                break;
        }
        this.EndObject = GameObject.Find("End");
    }

    public float PlayerSpeed {
        get { return speed; }
        set { speed = value; }
    }

    public float MonsterSpeed
    {
        get { return mspeed; }
        set { mspeed = value; }
    }

    public GameObject EndObject {
        get { return target; }
        set { target = value; }
    }

    public string SceneName {
        get { return scene; }
        set { scene = value; }
    }

    public int MaxMonsters
    {
        get { return maxMonsters; }
        set { maxMonsters = value; }
    }

    public int CloneMonsters
    {
        get { return cloneMonsters; }
        set { cloneMonsters = value; }
    }

    public int MonsterLife
    {
        get { return monsterLife; }
        set { monsterLife = value; }
    }
}
