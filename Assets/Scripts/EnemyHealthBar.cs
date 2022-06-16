using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
   public float health;
   public float maxHealth;

   public GameObject healthBarUI;
   public Slider slider;


   public void updateHealthBar(float maxHealth ,float currentHealth)
   {
      slider.value = currentHealth / maxHealth;
   }
   
   // Start is called before the first frame update
   void Start()
   {
      health = maxHealth;
      slider.value = CalculateHealth();
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

  /* private void OnMouseDown()
   {
      health -= 10;
   }*/

   private void OnCollisionEnter(Collision collision)
   {
      if (collision.transform.tag == "spraycans")
      {
         health -= 10;
      }
      
      /*if(collision.transform.tag == "Enemy")
      {
         health -= 40;
      }*/
   }
   
   private void OnTriggerEnter(Collider other)
   {
      if (other.transform.tag == "Enemy")
      {
         //gameObject.SetActive(false);
         health -= 40;
         Debug.Log("planted area collision");
      }
   }
}
