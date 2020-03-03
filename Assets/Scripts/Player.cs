using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    public float xySpeed = 20;

    // Start is called before the first frame update 
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        LocalMove(h, v, xySpeed);
        ClampPosition();
    }

    void LocalMove(float x, float y, float speed) {
        transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime;
    }

    void ClampPosition() {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);     
        pos.x = Mathf.Clamp(transform.localPosition.x, -8f, 8f);
        pos.y = Mathf.Clamp(transform.localPosition.y, -4f, 4f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
