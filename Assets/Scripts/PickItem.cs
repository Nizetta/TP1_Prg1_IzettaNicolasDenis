using UnityEngine;

public class PickItem : MonoBehaviour
{

    [SerializeField]private Transform mano;
    private GameObject currentItem=null;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Item") && currentItem == null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Pick(other.gameObject);
            }
            
        }
    }


    private void Pick(GameObject item)
    {
        currentItem = item;

        item.transform.SetParent(mano);
        item.transform.localPosition = Vector3.zero;
        item.transform.localRotation = Quaternion.identity;


    } 

    public GameObject DropItem()
    {
        GameObject temp = currentItem;
        currentItem = null;
        return temp;
    }
}
