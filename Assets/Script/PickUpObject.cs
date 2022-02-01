using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public int nbPiles = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string nom = gameObject.name;
        print(nom.Substring(0, 3).ToString());
        Destroy(gameObject);  
        if(nom.Substring(0, 3).ToString() == "vie")
        {
            LightRadius.instance.aggrandirHallo();   
        }else{
            if(nbPiles == 4)
            {
                ilFautSortir();
            }
        }
    }

    private void ilFautSortir()
    {
        
    }
}
