using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNewScene : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Invoke("loadFirstScene", 5f);
    }

    void loadFirstScene(){
        SceneManager.LoadScene(1);
    }
}
