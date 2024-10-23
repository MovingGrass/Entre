using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IPickable pickable = collision.gameObject.GetComponent<IPickable>();
        if (pickable != null) pickable.PickUp();
    }
}
