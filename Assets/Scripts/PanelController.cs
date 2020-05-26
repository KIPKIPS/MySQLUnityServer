using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject[] panels;
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void GradeBtn() {
        panels[0].SetActive(true);
    }
    public void ClassBtn() {
        panels[1].SetActive(true);
    }
    public void NewsBtn() {
        panels[2].SetActive(true);
    }
    public void QuestionnaireBtn() {
        panels[3].SetActive(true);
    }
}
