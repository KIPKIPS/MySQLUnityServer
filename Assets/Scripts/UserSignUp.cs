using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class UserSignUp : UserLogIn {
    // Start is called before the first frame update
    void Start() {
        mysql = new MySqlAccess(host, port, userName, password, databaseName);
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnSignUpBtnClick() {
        mysql.OpenSql();
        //插入数据
        bool succ = mysql.Insert("users", new[] { "user_name", "user_password" }, new[] { userNameInput.text, passwordInput.text });
        Debug.Log(succ ? "注册成功,请重新登录" : "注册失败,用户名已存在,请重新注册");
    }
}
