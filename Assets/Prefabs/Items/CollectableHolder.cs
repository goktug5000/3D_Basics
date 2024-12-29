using UnityEngine;

public class CollectableHolder : MonoBehaviour
{
    public Inventory inventory;
    [SerializeField] public CollectableItem item;

    private void Start()
    {
        inventory = PlayerConstantsHolder._playerConstantsHolder.playerInventory;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CollectMe();
        }
    }

    public void CollectMe()
    {
        if (item?.itemSo != null)
        {
            inventory.AddItem(item);
        }
        Destroy(this.gameObject);
    }
}
