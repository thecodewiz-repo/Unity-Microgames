using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.LEGO.Minifig {
  public class LegoGameStart : MonoBehaviour {
      void Awake() {
        Debug.Log("Hello: " + gameObject.name);
      }
    }
}
