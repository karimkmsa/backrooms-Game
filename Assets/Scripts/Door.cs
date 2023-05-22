using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
   public GameObject destroyedDoorPrefab;
   public PlayerInventory playerInventory;

   void OnCollisionEnter(Collision col) {
      if(col.gameObject.tag == "Player" && playerInventory.NumberOfDiamonds>=2) {
         Destroy(gameObject);
      }
   }
}