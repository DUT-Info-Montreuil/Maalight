using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Destroy(gameObject);  
            LightRadius.instance.aggrandirHallo();
    }
}
