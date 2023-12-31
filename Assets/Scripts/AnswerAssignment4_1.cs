using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerAssignment4_1 : MonoBehaviour
{

    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;
    
    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;


    void Start()
    {
        print("The racer model is " + carModel + ". It has a " + engineType + " engine.");

        CheckWeight();

        if (yearMade <= 2009)
        {
            print("It was first introduced in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("That makes it " + carAge + " years old.");

        } else
        {
            print("It was introduced in the 2010's");
            print("And its maximum acceleration is " + maxAcceleration + " m/s2");
        }

        print(CheckCharacteristics());
    }
    void CheckWeight()
    {
    
        if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500 kg.");
        }
        else
        {
            print("The " + carModel + " weighs over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
    
        if (isCarTypeSedan)
        {
            return "The car is a sedan type.";

        } else if (hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";
        
        } else
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }
}
