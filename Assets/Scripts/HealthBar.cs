using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Slider slider;
   public Gradient gradient;
   public Image image;

   private float percentage;
   private float maxHealth;
   private float speed = .25f;

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        maxHealth = slider.value;
        percentage = maxHealth;
    }

   public void setHealth(int health)
   {      
        StartCoroutine(Decrementar(health));
   }

   public void colorBarra()
   {
        image.color = gradient.Evaluate(percentage);
   }

   private void Start() {
        colorBarra();
   }

   private void Update() {
        colorBarra();
        
   }

   private IEnumerator Decrementar(int health)
   {
     float value = slider.value;

     float elapsedTime = 0f;

     while(elapsedTime < speed)
     {
          elapsedTime += Time.deltaTime;
          
          slider.value = Mathf.Lerp(value, health, (elapsedTime / speed));


          yield return null;
     }

     percentage = slider.value / maxHealth;
   }

}
