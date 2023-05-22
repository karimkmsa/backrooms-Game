using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
{


PlayerInventory playerInventory=other.GetComponent<PlayerInventory>();
if(playerInventory !=null)
{
    playerInventory.DiamonCollected();
    gameObject.SetActive(false);
    
}
}
}
