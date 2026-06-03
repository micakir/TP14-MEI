using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    
    InteractiveArea interactiveArea;

    void Start()
    {
        interactiveArea = FindObjectOfType<InteractiveArea>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coleccionable"))
        {
            interactiveArea.SumarPunto();
            Destroy(col.gameObject);
        }
    }
}
