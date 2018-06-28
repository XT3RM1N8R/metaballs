using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEmitter : MonoBehaviour {
  public bool canEmit = true;
  public int countDown = 1000;
  public int emitVelocity = 100;
  public Rigidbody sourceObject;
  public int currentCount;
	// Use this for initialization
	void Start () {
    currentCount = countDown;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentCount <= 0 && canEmit) {
      Rigidbody waterSphere = (Rigidbody)Instantiate(sourceObject, /*transform.position, transform.rotation,*/ transform);
      waterSphere.velocity = new Vector3(0, emitVelocity * -1, 0);
      currentCount = countDown;
    } else {
      if (currentCount > 0) {
        currentCount--;
      }
    }
	}
}
