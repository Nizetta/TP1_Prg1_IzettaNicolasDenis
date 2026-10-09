using System.Collections;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Collider powerUPCollider;


    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        powerUPCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerMov movimiento = other.GetComponent<playerMov>();

            if (movimiento!=null)
            {
                movimiento.PowerUp();
                StartCoroutine(Reaparecer());
            }
            
        }
    }

    private IEnumerator Reaparecer()
    {
        meshRenderer.enabled = false;
        powerUPCollider.enabled = false;
        
        yield return new WaitForSeconds(15f);
        
        meshRenderer.enabled = true;
        powerUPCollider.enabled = true;
    }
}
