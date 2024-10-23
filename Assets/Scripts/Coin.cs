using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPickable
{
    public void PickUp()
    {
        GameManager.Instance.score++;
        Destroy(gameObject);
    }
}
