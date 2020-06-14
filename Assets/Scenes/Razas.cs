using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Razas : MonoBehaviour
{
    public GameObject[] races;
    private int currentRace;

    public void SwitchRaces()
    {
        if(currentRace == races.Length - 1)
        {
            currentRace = 0;
        } else
        {
            currentRace++;
        }

        currentRace++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < races.Length; i++)
        {
            if(i == currentRace)
            {
                races[i].SetActive(true);
            } else
            {
                races[i].SetActive(false);
            }
        }
    }
}
