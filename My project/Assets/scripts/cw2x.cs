using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2x : MonoBehaviour
{ string heroname = "captin majid";
    int hero_age = 15;
    float heroheight = 170.9f;
    string heroSuperPower = "flight";
    string villianname = "bad";
    float villianheight = 190.2f;
    int villian_age = 900;
    string villiansuperpower = "smart"; 
    // Start is called before the first frame update
    void Start()
    {
        int age_difference = villian_age - hero_age;
        print("im the hero of this village, my name is " + heroname + " i am " + hero_age + " im " + heroheight + " cm tall and i have the ability of " + heroSuperPower);
        print("im the villian here to demolish this village and i am " + villianname + ", im " + villianheight + " cm tall and my age is " + villian_age + " and i am super " + villiansuperpower);
        print("the age difference between the hero and villian is" + age_difference + "years");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
