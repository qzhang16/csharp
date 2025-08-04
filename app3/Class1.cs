using System;
using System.Data.Odbc;

namespace app3
{
    public class Class1
    {


        public void Ace01()
        {
            Console.WriteLine("hello from Ace01 !");
            string connectionString = "DSN=PLEX;Uid=qzhang16;";
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("odbc connection is good !");
                    // string sql01 = "select count(*) from part_v_part a";
                    string sql01 = "select top 20 part_no from part_v_part a";
                    using (OdbcCommand cmd = new OdbcCommand(sql01, conn))
                    {
                        // long count = (long)cmd.ExecuteScalar();
                        // Console.WriteLine("part count: " + count);
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string part_no = reader.GetString(0);
                                Console.WriteLine("part no: " + part_no);
                            }

                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("odbc error: " + e.Message);
                }
            }


        }

        private string getAbc()
        {
            throw new NotImplementedException();
        }
    }
}
