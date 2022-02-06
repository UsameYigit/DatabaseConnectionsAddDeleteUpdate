using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseConnectionsAddDeleteUpdate
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server = .; Database = Northwind; UID = sa; PWD = 12345");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShipperAdd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShipperUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShipperDelete();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetListView();
        }

        void ShipperAdd()
        {
            if (string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtShipperName.Text))
                MessageBox.Show("You need to fill the Shipper Name and Phone in order to add the shipper.");
            else
            {
                cmd = new SqlCommand("INSERT INTO Shippers VALUES (@CompanyName, @Phone)", con);

                cmd.Parameters.AddWithValue("@CompanyName", txtShipperName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                CommandExecution();

                SetListView();
            }
            ResetTextFields();
        }

        void ShipperUpdate()
        {
            if (lvShippers.SelectedItems.Count == 0 || (string.IsNullOrEmpty(txtPhone.Text) && string.IsNullOrEmpty(txtShipperName.Text)))
                MessageBox.Show("You need to fill the Shipper Name and Phone at the same time and you have to select a shipper to update.");
            else
            {
                if (string.IsNullOrEmpty(txtPhone.Text))
                    cmd = new SqlCommand("UPDATE Shippers SET CompanyName = @CompanyName WHERE ShipperID = @ShipperID", con);
                else if (string.IsNullOrEmpty(txtShipperName.Text))
                    cmd = new SqlCommand("UPDATE Shippers SET Phone = @Phone WHERE ShipperID = @ShipperID", con);
                else
                    cmd = new SqlCommand("UPDATE Shippers SET CompanyName = @CompanyName, Phone = @Phone WHERE ShipperID = @ShipperID", con);

                cmd.Parameters.AddWithValue("@CompanyName", txtShipperName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@ShipperID", lvShippers.SelectedItems[0].SubItems[0].Text);

                CommandExecution();
            }
            ResetTextFields();
        }

        void ShipperDelete()
        {
            if (lvShippers.SelectedItems.Count == 0)
                MessageBox.Show("You have to choose a Shipper to delete.");
            else
            {
                cmd = new SqlCommand("DELETE FROM Shippers WHERE ShipperID = @ShipperID", con);

                cmd.Parameters.AddWithValue("@ShipperID", lvShippers.SelectedItems[0].SubItems[0].Text);

                CommandExecution();

            }
            ResetTextFields();
        }

        void ResetTextFields()
        {
            txtPhone.Text = "";
            txtShipperName.Text = "";
        }

        void CommandExecution()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                int rowsEffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsEffected + " row(s) effected!");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
            SetListView();
        }

        void SetListView()
        {
            lvShippers.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM Shippers", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                        lvi.SubItems.Add(reader.GetString(1));
                        lvi.SubItems.Add(reader.GetString(2));
                        lvShippers.Items.Add(lvi);
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
            lvShippers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
