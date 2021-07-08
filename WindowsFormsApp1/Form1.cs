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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //接続情報
            string Server = "localhost";
            int Port = 3306;
            string Database = "mysql";
            string Uid = "root";
            string Pwd = "設定したパスワード";

            string ConnectionString = $"Server={Server}; Port={Port}; Database={Database}; Uid={Uid}; Pwd={Pwd}";

            string SelectVersion = "SELECT version()";

            try
            {
                //コネクションオブジェクトとコマンドオブジェクトを生成。
                 MySqlConnection conn = new MySqlConnection(ConnectionString);
                 MySqlCommand command = new MySqlCommand()
                

            }
           
            
        }
    }
}
