using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace peoplePicture
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=localhost;port=8806;user=root;password=; database=mydb;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                String sql = "select * from user where u=@u and p=@p";
                MySqlCommand myCmd = new MySqlCommand(sql,conn);
                myCmd.Parameters.AddWithValue("@u", textBox1.Text.ToString());
                myCmd.Parameters.AddWithValue("@p", textBox2.Text.ToString());
                MySqlDataReader reader = myCmd.ExecuteReader();
                if(reader.Read())
                {
                    Console.WriteLine("登陆成功");
                    this.Hide();
                    choose ch = new choose();
                    ch.Show();
                    

                }
                //在这里可以使用代码对数据库进行增删查改的操作
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);//有错则报出错误
            }
            finally
            {
                conn.Close();//关闭通道
            }
        }
    }
}
