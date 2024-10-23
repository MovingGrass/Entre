using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPickable
{
    public void PickUp()
    {
        Debug.Log("Added 1 coin");
        Destroy(gameObject);
    }
}
