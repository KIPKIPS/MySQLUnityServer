using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionnaireController : MonoBehaviour {
    public GameObject error;
    public Text errorText;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void Back() {
        this.gameObject.SetActive(false);
    }

    public void Commit() {
        error.GetComponent<Animator>().SetTrigger("trigger");
        errorText.GetComponent<Text>().text = "提交成功";
        errorText.GetComponent<Text>().color = new Color(255, 255, 255, 255);
    }
}
