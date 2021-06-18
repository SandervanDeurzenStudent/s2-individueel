using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Hondenrace
{
    class Player
    {
        public string Name;
        public int playerBalance = 0;
        public Label mylbl = null;
        public NumericUpDown NuD = null;
        DB db = new DB();
        public void UpdateLabels(Player player, int balance)
        {
            db.OpenConnection();
            int i = Login.userId;
            string Query = "UPDATE users SET user_credits = " + balance +  " WHERE id = " + i;
            MySqlCommand command = new MySqlCommand(Query, db.GetConnection());
            command.ExecuteNonQuery();

            player.mylbl.Text = "Your balance:" + balance.ToString();
        }
        public int SetLabels(Player player, int balance)
        {
            int uid = Login.userId;
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE id = @uid", db.GetConnection());
            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = uid;
            


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string PlayerCurrency = reader.GetString("user_credits");
                   String returnString = player.mylbl.Text= "Your balance:" + PlayerCurrency.ToString();
                    return Convert.ToInt32(PlayerCurrency);
                }
            }
            //in case of an error
            return 0;

        }
    
    }
   
}
