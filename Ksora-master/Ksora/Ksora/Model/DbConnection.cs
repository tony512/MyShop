using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Ksora.Model {


    class DbConnection {

        private static SQLiteConnection sqlCon;
        static private SQLiteCommand sqlCommand;

        static private void setConnection() {

            try {

                sqlCon = new SQLiteConnection("Data Source = Db/db.db");
                
            }
            catch (SQLiteException e) {

                Console.Write("Error: " + e);
                throw;
                
            }
            
        }

        static public void add(string toAdd) {

            try {

                setConnection();
                sqlCon.Open();

                string query = "INSERT INTO Productos(Nombre,Categoria,Cantidad) VALUES ("+ toAdd +");";

                sqlCommand = sqlCon.CreateCommand();
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();

                sqlCon.Close();
                

            }
            catch (SQLiteException e) {

                Console.Write("Error: " + e);
                throw;
            }
            

        }
        



    }
}
