using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System;
using UnityEngine.UI;

public class MySQLToUnity : MonoBehaviour {
    private Text sqlText;
    private string sql = "";
    // Start is called before the first frame update
    void Start() {
        sqlText=GameObject.Find("SQLText").GetComponent<Text>();
        string constructorString = "datasource=127.0.0.1;port=3306;database=mysql_unity_server;user=root;pwd=123123;";
        MySqlConnection msc=new MySqlConnection(constructorString);
        try {
            msc.Open();
            Debug.Log("已经建立连接");
            sql = "select * from users where user_id=1";
            MySqlCommand command = new MySqlCommand(sql, msc);
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read()) {
                sqlText.text = dataReader.GetString("user_name") + " : " + dataReader.GetString("user_password");
            }
        }
        catch (Exception e) {
            Debug.Log(e.Message);
        }
        finally {
            msc.Close();
            Debug.Log("数据库连接断开");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
