using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public static Manager manager;
    public GameObject featuresPanel;
    void Awake() {
        manager = this;
    }
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void FeaturesPanelDisplay() {
        Invoke("Function",2);
        
    }

    public void Function() {
        featuresPanel.SetActive(true);
    }
}
