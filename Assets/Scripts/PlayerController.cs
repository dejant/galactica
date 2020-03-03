using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    [Tooltip("meter pro seconds")] [SerializeField] float speed = 30f;
    [Tooltip("meter")] [SerializeField] float xRange = 10f;
    [Tooltip("meter")] [SerializeField] float yRange = 7f;


    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        updatePosition();

    }

    void updatePosition(){
        float xInput = CrossPlatformInputManager.GetAxis("Horizontal");
        float yInput = CrossPlatformInputManager.GetAxis("Vertical");

        float xOffset = xInput * speed * Time.deltaTime;
        float yOffset = yInput * speed * Time.deltaTime;

        float rawPosX = transform.localPosition.x + xOffset;
        float rawPosY = transform.localPosition.y + yOffset;

        float clampedPosX = Mathf.Clamp(rawPosX, -xRange, xRange);
        float clampedPosY = Mathf.Clamp(rawPosY, -yRange, yRange);

        transform.localPosition = new Vector3(clampedPosX, clampedPosY, transform.localPosition.z);
    }

}
