using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string nom = gameObject.name;
        // print(nom.Substring(0, 3).ToString());
        Destroy(gameObject);
        if (nom.Substring(0, 3).ToString() == "vie")
        {
            LightRadius.instance.aggrandirHallo();
        }
        else
        {
            PlayerMovement.instance.nbPiles++;
            // print(PlayerMovement.instance.nbPiles);
            if (PlayerMovement.instance.nbPiles == 4)
            {
                ilFautSortir();
            }
        }
    }

    private void ilFautSortir()
    {
        ChronoBis.instance.lanceChrono();
    }
}
