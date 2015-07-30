/**
 * Attach this class to any object that should support rotation.
 *
 * NOTE: Rotation will be applied to ALL attached objects.
 */

using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

  // Here we define the speed of the rotation.
  private float m_RotationSpeed = 20f;

  void Update() {
    // Only perform rotation when 1 finger is touching.
    if (1 == Input.touchCount) {
      // Rotate the object arount the up/down axis.
      // The deltaPosition saves the distance between the current finger position and the last one.
      // From this distance, we only care about the x axis.
      // Time.deltaTime is used to make the movement depend on time, not FPS.
      gameObject.transform.Rotate (Vector3.down, Input.touches [0].deltaPosition.x * m_RotationSpeed * Time.deltaTime);
    }
  }
}
