using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField] private CollectableItemType _itemType = null;
    
    private void Start() 
    {
        _itemType.Setup(gameObject);
    }
    
    private void GotItem() 
    {
        _itemType.ItemEffect(gameObject);
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D p_other)
    {
        PacMan pacman = p_other.GetComponent<PacMan>();
        if (pacman != null) 
        {
            GotItem();
        }
    }
}
