using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class UserSignUp : UserLogIn {
    // Start is called before the first frame update
    void Start() {
        mysql = new MySqlAccess(host, port, userName, password, databaseName);
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnSignUpBtnClick() {
        if (userNameInput.text == "") {
            Message("用户名不能为空");
        }
        else if (passwordInput.text == "") {
            Message("密码不能为空");
        }
        else {
            mysql.OpenSql();
            //插入数据
            bool succ = mysql.Insert("users", new[] { "user_name", "user_password" }, new[] { userNameInput.text, passwordInput.text });
            Debug.Log(succ ? "注册成功,请重新登录" : "注册失败,用户名已存在,请重新注册");
            if (succ) {
                Message("注册成功,请登录");
            }
            else {
                Message("注册失败,请重新注册");
            }
        }
    }
}
