
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    // UnityEngine.Experimental.Rendering.Universal.Light2D playerLight;
    public HealthBar healthBar;

   


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        // playerLight = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            takeDamage(20);
        }
        // print(playerLight);
    }


    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }
}
