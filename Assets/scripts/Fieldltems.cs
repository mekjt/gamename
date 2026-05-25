using UnityEngine;

public class Fieldltems : MonoBehaviour
{
    public Item item;
    public SpriteRenderer Image;

    public void Setltem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;

        Image.sprite = _item.itemImage;
    }
    public Item Getltem()
    {
        return item;
    }
    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
