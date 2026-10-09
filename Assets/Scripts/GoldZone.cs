using UnityEngine;
public class GoldZone : MonoBehaviour
{
    [SerializeField]private Transform goal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickItem pickItem = other.GetComponent<PickItem>();
            if (pickItem != null)
            {
                GameObject item = pickItem.DropItem();
                if (item != null)
                {
                    ItemInZone(item);
                    Debug.Log("item entregado correctamente");
                    Debug.Log("ganaste");
                }
                else
                {
                    Debug.Log("derrota o llego a la meta sin el item");
                }
            }
        }
    }

    private void ItemInZone(GameObject item)
    {
        item.transform.SetParent(goal);
        
    }

}