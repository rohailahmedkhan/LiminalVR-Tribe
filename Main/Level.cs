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
    int MonsterMass { set; get; } // Setting Monsters Mass
}

public class Level : ILevel
{
    string scene; // Storing Scene Name
    float speed, mspeed; // Storing player speed and monster speed to player
    GameObject target, playerN; // Storing target information and player information
    int maxMonsters, cloneMonsters, monsterMass; // Storing maximum monster on game at a time, current number of monsters and
    // life of monsters per Level though there will be changes...


    // Setting up default constructor with default scene name as Level 1
    public Level (string LevelName = "Level_1")
    {
        // Getting the current scene name
        this.SceneName = SceneManager.GetActiveScene().name;
        
        // Updating the current scene name
        this.SceneName = LevelName;

        // Updates Specific to Level
        switch (LevelName) {
            case "Level_1": // Specifications for Level 1
                this.speed = 0.08f;
                this.mspeed = 0.07f;
                this.maxMonsters = 5;
                this.cloneMonsters = 0;
                this.monsterMass = 4;
                break;
            case "Level_2":// Specifications for Level 2
                this.speed = 0.15f;
                this.mspeed = 0.07f;
                this.maxMonsters = 7;
                this.cloneMonsters = 0;
                this.monsterMass = 6;
                break;
            case "Level_3":// Specifications for Level 3
                this.speed = 0.2f;
                this.mspeed = 0.07f;
                this.maxMonsters = 9;
                this.cloneMonsters = 0;
                this.monsterMass = 8;
                break;
        }

        // Getting position to end the level..
        this.EndObject = GameObject.Find("End");
    }

    //Implementing Properties from Interface
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

    public int MonsterMass
    {
        get { return monsterMass; }
        set { monsterMass = value; }
    }
}
