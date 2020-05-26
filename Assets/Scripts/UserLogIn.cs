using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class UserLogIn : MonoBehaviour {
    public InputField userNameInput;
    public InputField passwordInput;
    public Image mes;
    public string host;//IP地址
    public string port;//端口号
    public string userName;//用户名
    public string password;//密码
    public string databaseName;//数据库名称
    protected MySqlAccess mysql;//封装好的数据库类

    public GameObject error;
    public Text errorText;
    // Start is called before the first frame update
    void Start() {
        mysql = new MySqlAccess(host, port, userName, password, databaseName);
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnLogInBtnClick() {
        if (userNameInput.text == "") {
            Message("请输入用户名");
        }
        else if (passwordInput.text == "") {
            Message("请输入密码");
        }
        else {
            mysql.OpenSql();
            //获取数据
            DataSet ds = mysql.Select("users", new string[] { "user_password", "user_id" }, new string[] { "user_name" }, new string[] { "=" }, new string[] { userNameInput.text, });
            if (ds != null) {
                DataTable table = ds.Tables[0];
                List<string> data = new List<string>();
                foreach (DataRow row in table.Rows) {
                    foreach (DataColumn col in table.Columns) {
                        data.Add(row[col].ToString());
                    }
                }
                if (data[0] == passwordInput.text) {
                    mes.color = Color.green;
                    Message("登录成功");
                    Manager.manager.FeaturesPanelDisplay();
                }
                else {
                    mes.color = Color.red;
                    Message("登陆失败");
                }
            }
            else {
                mes.color = Color.red;
                Message("登陆失败");
            }
            mysql.CloseSql();
        }

    }

    public void Message(string mes) {
        error.GetComponent<Animator>().SetTrigger("trigger");
        errorText.GetComponent<Text>().text = mes;
        errorText.GetComponent<Text>().color = new Color(255, 255, 255, 255);
    }
}
