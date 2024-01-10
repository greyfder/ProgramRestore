using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramRestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Veri Dosyasını seçiniz|*.bak";
            ofd.ShowDialog();
            tDosya.Text=ofd.FileName;
        }

        private void bYukle_Click(object sender, EventArgs e)
        {
            if (tDosya.Text != "")
            {
                try
                {
                    //DESKTOP-EK61UGP
                    string strSql = @"Server=DESKTOP-EK61UGP;User Id=barkod;Password=0101;Database=Barkod1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    // string strSql = @"Server=DESKTOP-PMC8L57\SQLEXPRESS;User Id=barkod;Password=0101;Database=Barkod1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    //string strSql = @"data Source =(LOCALDB)\MSSQLLocalDb;attachdbfilename=|DataDirectory|\Barkod1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                    Cursor.Current=Cursors.WaitCursor;
                    string yedekyolu=tDosya.Text;
                    Application.DoEvents();// ekran donmöasın diye
                    string str = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Barkod1.mdf";
                    //string str = Application.StartupPath + @"\Barkod1.mdf"; //Önceki
                    using (SqlConnection connection = new SqlConnection(strSql))
                    {
                        connection.Open();

                        SqlCommand isle = new SqlCommand(@"USE MASTER;If Exists(Select * from sys.databases where name ='Barkod1') Drop Database["+ str + "];RESTORE DATABASE["+ str +"] FROM DISK=N'"+tDosya.Text+"'",connection);
                        isle.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Veriler Yüklenmiştir.");
                    Process.Start(Application.StartupPath + @"\SahinBarkod(1).exe");
                    Cursor.Current= Cursors.Default;
                    Application.Exit();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
