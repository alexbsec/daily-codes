using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStatus : MonoBehaviour
{

    private int maxHealth = 10;
    private int currentHealth;


    private float maxHunger = 1f;
    private float currentHunger = 0f;
    private float hungerIncreaseRate = 0.01f;
    private float increaseHungerTimer = 1.0f;
    private float increaseTimeBy = 1.0f;

    private float maxThirst = 1f;
    private float currentThirst = 0f;
    private float thirstIncreaseRate = 0.005f;
    private float increaseThirstTimer = 1.0f;


    private bool isAlive;
    public void Update()
    {

        isAlive = currentHealth >= 0f;

        
        if (isAlive)
        {
            increaseHungerTimer -= Time.deltaTime;
            increaseThirstTimer -= Time.deltaTime;

            bool hungerTimer = increaseHungerTimer < 0;
            bool thirstTimer = increaseThirstTimer < 0;

            if (hungerTimer)
            {
                // Hunger starts to go up
                currentHunger += hungerIncreaseRate;

                Debug.Log("Your hunger is:");
                Debug.Log(currentHunger);

                // If hunger exceeds maxHunger then target starts to die
                if (currentHunger >= maxHunger)
                {
                    currentHunger = maxHunger;
                    currentHealth -= 1;
                }

                // restart timer

                increaseHungerTimer += increaseTimeBy;
                hungerTimer = increaseHungerTimer < 0;

            }

            if (thirstTimer)
            {
                // Hunger starts to go up
                currentThirst += thirstIncreaseRate;

                Debug.Log("Your thirst is:");
                Debug.Log(currentThirst);

                // If hunger exceeds maxHunger then target starts to die
                if (currentThirst >= maxThirst)
                {
                    currentThirst = maxThirst;
                    currentHealth -= 1;
                }

                // restart timer

                increaseThirstTimer += increaseTimeBy;
                thirstTimer = increaseThirstTimer < 0;

            }
        }

        else
        {
            Debug.Log("You died");
        }

    }
}
