
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  public Slider slider;  
  
  public void setMaxHealth(int health)
  {
      slider.maxValue = health;
      slider.value = health;
  }

  public void increaseHealth(double value)
  {
    slider.value += (float)value;
  }

  public void decreaseHealth(double value)
  {
    slider.value -= (float)value;
  }


  public void setHealth(int health){
      slider.value = health;
  }


  public float getHealth(){
    return slider.value;
  }
}
