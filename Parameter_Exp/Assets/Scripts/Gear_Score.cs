using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear_Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Gear_Points("Legendary","Gauntlet",12,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gear_Points(string gear_Rarity, string gear_type, int level, int power_up)
    {
        level = level + power_up;
        Debug.Log(gear_Rarity + " " + gear_type + " Increases your power by: " + level);
    }
}
