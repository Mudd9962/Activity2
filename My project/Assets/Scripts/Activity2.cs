using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity2 : MonoBehaviour
{
    public int strenght;
    public int agility;
    public int intelligence;
    public int statPool;
    void Start()
    {
        statPool = 20;
        strenght = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        intelligence = Random.Range(0, 10);
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("My player stats are :");
            Debug.Log("Strengt : " + strenght);
            Debug.Log("Agility : " + agility);
            Debug.Log("Intelligence : " + intelligence);
        }
    }
}
