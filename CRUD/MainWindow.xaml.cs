using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustomerNo,CustomerName) values('"+txtcustno.Text+"','"+txtcustname.Text+"')",con);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Insert Data");
            con.Close();

            Clear();
            ShowData();
        }

        private void Btn_Show_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlDataAdapter ada = new SqlDataAdapter("select * from CustomerTbl",con);

            DataTable dt = new DataTable();

            ada.Fill(dt);

            Grid1.ItemsSource = dt.DefaultView;

            con.Close();
        }

        private void Btn_Find_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlDataAdapter ada = new SqlDataAdapter("select * from CustomerTbl where CustomerId= '"+txtcustId.Text+"'", con);

            DataTable dt = new DataTable();

            ada.Fill(dt);

            txtcustno.Text = dt.Rows[0][1].ToString();
            txtcustname.Text = dt.Rows[0][2].ToString();

            con.Close();
        }

        private void Btn_Update_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlCommand cmd = new SqlCommand("update CustomerTbl set CustomerNo='" + txtcustno.Text + "',CustomerName='" + txtcustname.Text + "' where CustomerId= '" + txtcustId.Text + "'", con);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Update Data");
            con.Close();
            Clear();
            ShowData();
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustomerId= '" + txtcustId.Text + "' ", con);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Delete Data");
            con.Close();
            Clear();
            ShowData();
        }

        void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=10.61.18.12;Initial Catalog=TestDetail;Persist Security Info=True;User ID=msdba;Password=dba@123");

            SqlDataAdapter ada = new SqlDataAdapter("select * from CustomerTbl", con);

            DataTable dt = new DataTable();

            ada.Fill(dt);

            Grid1.ItemsSource = dt.DefaultView;

            con.Close();
        }

        void Clear()
        {
            txtcustId.Text = txtcustno.Text = txtcustname.Text = "";
        }
    }
}
