/* ConnectionClass.cs
 * Created by Jordan James Turner for Seneca College TPJ655 project
 * Date Created: September 10th 2014
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

public class ConnectionClass
{
    public MySqlConnection Connection { get; private set; } //MySqlConnection property object
    public string Server { get; private set; } //String that holds server name parameter, can only be set in ConnectionClass.cs
    public string Database { get; private set; } //String that holds server database parameter, can only be set in ConnectionClass.cs
    public string Uid { get; private set; } //String that holds server user id parameter, can only be set in ConnectionClass.cs
    public string Password { get; private set; } //String that holds server password parameter, can only be set in ConnectionClass.cs
    public string ConnectionString { get; private set; } //String that holds complete MySQL connection statement, can only be set in ConnectionClass.cs
    public int[] Measurements { get; set; } //Array to hold measurements done by Xbox Kinect to relay to KinecFit Software and realy to database
    public string UserBrand { get; set; } //Holds user input
    public string UserGender { get; set; } //Holds user input
    public string UserStyle { get; set; } //Holds user input
    public string TrueStyle { get; set; } //For database
    public string UserPart1 { get; set; } //Holds first body part that the Xbox Kinect will measure
    public string UserPart2 { get; set; } //Holds second body part that the Xbox Kinect will measure
    public string UserSize { get; set; } //Holds size determined by database based on Xbox Kinect measurements

    public ConnectionClass()
    {
        Server = "";
        Database = "";
        Uid = "";
        Password = "";

        ConnectionString = "Server = " + Server + "; Database = " + Database + "; Uid = " + Uid + "; Pwd = " + Password + ";";
        Connection = new MySqlConnection(ConnectionString);
    }

    //Open Connection to Database
    public void OpenConnection()
    {
        try
        {
            Connection.Open();
        }
        catch (MySqlException ex)
        {
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            //Each result will inform the user
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;
                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
                case 1042:
                    MessageBox.Show(ex.ToString());
                    break;
            }
        }
    }

    //Check Connection
    public bool isConnected()
    {
        if (Connection.State == System.Data.ConnectionState.Open)
            return true;
        else if (Connection.State == System.Data.ConnectionState.Broken || Connection.State == System.Data.ConnectionState.Closed)
            return false;
        else
            return false;
    }

    //Get parts for brand
    public void getParts()
    {
        Measurements = new int[2];
        DataTable dt = new DataTable();
        String statement = "";
        switch(UserBrand)
        {
            case("zara"):
                statement = "select distinct(part) from zaraSize where type='"+ UserStyle + "' and gender = '"+ UserGender +"'";
                break;
            case("H&M"):
                statement = "select distinct(part) from hmSize where type='" + UserStyle + "' and gender = '" + UserGender + "'";
                break;
            case("Gap"):
                statement = "select distinct(part) from gapSize where type='" + UserStyle + "' and gender = '" + UserGender + "'";
                break;
            case("Hugo Boss"):
                statement = "select distinct(part) from hugoBossSize where type='" + UserStyle + "' and gender = '" + UserGender + "'";
                break;
            case("Urban Outfitters"):
                statement = "select distinct(part) from urbanOutfittersSize where type='" + UserStyle + "' and gender = '" + UserGender + "'";
                break;
        }
        if (isConnected())
        {
            MySqlDataAdapter da = new MySqlDataAdapter(statement, Connection);
            int i = 0;
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                i++;
                if(i==1)
                    UserPart1 = row.ItemArray[0].ToString();
                else
                    UserPart2 = row.ItemArray[0].ToString();
            }
        }
    }

    //Get size from measurements
    public void getSize()
    {
        DataTable dt = new DataTable();
        String result1 = "";
        String result2 = "";
        String statement = "";
        
        statement = getStatement(UserPart1,Measurements[0]);
        if (isConnected())
        {
            MySqlDataAdapter da = new MySqlDataAdapter(statement, Connection);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
                if(i==1)
                    result1 = row.ItemArray[0].ToString();
            }
        }
        statement = getStatement(UserPart2, Measurements[1]);
        if (isConnected())
        {
            MySqlDataAdapter da = new MySqlDataAdapter(statement, Connection);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
                if(i==1)
                    result2 = row.ItemArray[0].ToString();
            }
        }

        if (result1 == "S" && result2 == "M")
            UserSize = "S";
        else if (result1 == "S" && result2 == "L")
            UserSize = "M";
        else if (result1 == "S" && result2 == "XL")
            UserSize = "L";

        else if (result1 == "M" && result2 == "S")
            UserSize = "M";
        else if (result1 == "M" && result2 == "L")
            UserSize = "M";
        else if (result1 == "M" && result2 == "XL")
            UserSize = "L";

        else if (result1 == "L" && result2 == "S")
            UserSize = "M";
        else if (result1 == "L" && result2 == "M")
            UserSize = "L";
        else if (result1 == "L" && result2 == "XL")
            UserSize = "L";

        else if (result1 == "XL" && result2 == "S")
            UserSize = "L";
        else if (result1 == "XL" && result2 == "M")
            UserSize = "L";
        else if (result1 == "XL" && result2 == "L")
            UserSize = "XL";

        else if (result1 == result2)
            UserSize = result1.ToString();
    }

    private string getStatement(String part, int measurement)
    {
        String statement = "";
        switch (UserBrand)
        {
            case ("zara"):
                if(part == "Shoulder")
                    statement = "select distinct(size) from zaraSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart <= " + measurement.ToString() + " and rgEnd > " + measurement.ToString() + "";
                else if(part == "Chest")
                    statement = "select distinct(size) from zaraSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart <= " + measurement.ToString() + " and rgEnd > " + measurement.ToString() + "";
                break;
            case ("H&M"):
                if(part == "Waist")
                    statement = "select distinct(size) from hmSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart < " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + " or rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() +" ";
                else if (part == "Chest")
                    statement = "select distinct(size) from hmSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                break;
            case ("Gap"):
                if (part == "Waist")
                    statement = "select distinct(size) from gapSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart <" + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + " or rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + " ";
                else if(part == "Chest")
                {
                    if(measurement <= 104)
                        statement = "select distinct(size) from gapSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart <" + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                    else
                        statement = "select distinct(size) from gapSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart >" + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                }       
                break;
            case ("Hugo Boss"):
                if(part == "Waist")
                    statement = "select distinct(size) from hugoBossSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                else if(part == "Chest")
                    statement = "select distinct(size) from hugoBossSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                break;
            case ("Urban Outfitters"):
                if(part == "Waist")
                    statement = "select distinct(size) from urbanOutfittersSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart < " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + " or rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + " ";
                else if(part == "Chest")
                    statement = "select distinct(size) from urbanOutfittersSize where type='" + UserStyle + "' and gender = '" + UserGender + "' and part='" + part + "' and rgStart > " + measurement.ToString() + " and rgEnd >= " + measurement.ToString() + "";
                break;
        }
        return statement;
    }

    //Close connection
    public void CloseConnection()
    {
        
    }

    //Insert statement
    public void Insert(String statement,String name, String size,int sizeAmt, DateTime estDate, int cid)
    {
        MySqlCommand command = Connection.CreateCommand();
        command.CommandText = statement;

        command.Parameters.AddWithValue("?brand", UserBrand);
        command.Parameters.AddWithValue("?gender", UserGender);
        command.Parameters.AddWithValue("?name", name);
        command.Parameters.AddWithValue("?type", TrueStyle);
        command.Parameters.AddWithValue("?size", size);
        command.Parameters.AddWithValue("?sizeAmt", sizeAmt);
        command.Parameters.AddWithValue("?estDate", estDate.Date.ToString("yyyy-MM-dd HH:mm:ss"));
        command.Parameters.AddWithValue("?cid", cid);

        command.ExecuteNonQuery();
    }

    public void StyleInsert(String statement,String name, String type)
    {
        MySqlCommand command = Connection.CreateCommand();
        command.CommandText = statement;

        command.Parameters.AddWithValue("?brand", UserBrand);
        command.Parameters.AddWithValue("?gender", UserGender);
        command.Parameters.AddWithValue("?name", name);
        command.Parameters.AddWithValue("?type", type);
        command.Parameters.AddWithValue("?size", 'S');

        command.ExecuteNonQuery();
    }

    //Update statement
    public bool Update(String statement)
    {
        MySqlCommand MyCommand2 = new MySqlCommand(statement, Connection);
        MySqlDataReader MyReader2;
        MyReader2 = MyCommand2.ExecuteReader();
        while(MyReader2.Read())
        {
            //............:)........:D.......>:D
        }
        MyReader2.Close();
        return true;

    }

    //Delete statement
    public void Delete(String statement)
    {
        MySqlCommand MyCommand2 = new MySqlCommand(statement, Connection);
        MySqlDataReader MyReader2;
        MyReader2 = MyCommand2.ExecuteReader();
        while (MyReader2.Read())
        {
            //............:)........:D.......>:D
        }
        MyReader2.Close();
    }

    //Populate data table with results from select statement
    public DataTable queryResults(String statement)
    {
        DataTable dt = new DataTable();
        if (isConnected())//Check DB connection
        {
            MySqlDataAdapter da = new MySqlDataAdapter(statement, Connection);
            da.Fill(dt); 
            return dt;
        }
        else
            return dt;
    }

    //Select statement
    /*public List<string>[] Select()
    {
    }*/

    //Count statement
    public int Count()
    {
        return 0;
    }

    //Backup
    public void Backup()
    {
    }

    //Restore
    public void Restore()
    {
    }
}

