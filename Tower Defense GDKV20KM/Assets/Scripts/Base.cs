using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public float totalhealth = 100f;
    private float currentHealth;

    public Slider baseHealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalhealth;

        baseHealthSlider.maxValue = totalhealth;
        baseHealthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageToTake)
    {
        currentHealth -= damageToTake;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            gameObject.SetActive(false);
        }

        baseHealthSlider.value = currentHealth;
    }
}
