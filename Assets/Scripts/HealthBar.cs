using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public float health;
   public float maxHealth;

   public GameObject healthBarUI;
   public Slider slider;
   
   // Start is called before the first frame update
   void Start()
   {

      //_cam = Camera.main;
      health = maxHealth;
      slider.value = CalculateHealth();
   }
   
   
   public void updateHealthBar(float maxHealth ,float currentHealth)
   {
      slider.value = currentHealth / maxHealth;
   }
   
  
   
   
   // Update is called once per frame
   void Update()
   {
      slider.value = CalculateHealth();
      if (health < maxHealth)
      {
         healthBarUI.SetActive(true);
      }

      if (health <= 0)
      {
         Destroy(gameObject);
      }

      if (health > maxHealth)
      {
         health = maxHealth;
      }
   }
   
   public float CalculateHealth()
   {
      return health / maxHealth;
   }
   
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.transform.tag == "spraycans")
      {
         health -= 10;
      }
      
      if (collision.transform.tag == "Enemy")
      {
         health -= 40;
      }
   }
}
