using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity1 : MonoBehaviour
{
    public float randomNumber;

    void Start()
    {
        randomNumber = Random.Range(1, 10);

        if (randomNumber == 1 )
        {
            Debug.Log("The number was exactly 1.");
        }
        else if (randomNumber > 3||randomNumber < 5)
        {
            Debug.Log("The number is greater than 3 and less than 5. ");
        }
        else
        {
            Debug.Log("The number is " +  randomNumber);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
