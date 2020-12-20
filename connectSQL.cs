using System.Data.SqlClient;
SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = ..; Connect Timeout = 30; Encrypt=False; TrustServerCertificate=False;ApplicationIntent=ReadWrite; MultiSubnetFailover = False");

void connet(...)
{
  con.Open();
  SqlCommand cmd = new SqlCommand(@"INSERT INTO .. VALUES('" + textBox1.Text + "'...)");
  cmd.ExecuteNonQuery();
  con.Close();
  }

// Display table on dataGridView

void Display()
{
  SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM .");
  DataTable dt = new DataTable();
  sda.Fill(dt);
  dataGridView1.Rows.Clear();
  foreach(DataRow item in dt.Rows)
  {
    int n= dataGridView1.Rows.Add();
    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
    ...
    
  }
}
