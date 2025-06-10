using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiCollection : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D Collider2D) {
    if (Collider2D.gameObject.CompareTag("kiwi")) {
        Destroy(Collider2D.gameObject);
    }
   }
}
