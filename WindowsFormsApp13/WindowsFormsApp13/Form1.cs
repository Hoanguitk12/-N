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
using System.Globalization;
using System.Text.RegularExpressions;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SaveOrEdit = 0;//biến để xác định nút lưu khi sữa với nút lưu khi thêm
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string conStr = "Data Source=DESKTOP-N3C8F8L\\HOANGUITK12; Initial Catalog=QLSV;InteGrated Security=true";
            SqlConnection myCon = new SqlConnection(conStr);
            myCon.Open();
            string CommStr = "SELECT HoTen,MSSV,Lop,NgaySinh,GioiTinh,MaVung,SDT,Email FROM SinhVien";
            SqlCommand myComm = new SqlCommand(CommStr, myCon);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myComm;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            dataGridView1.DataSource = myDT;
            myCon.Close();
            button1.Visible = false;
        }
       
        //hàm lấy dữ liệu giới tính từ radiobutton
        private string GioiTinhText()
        {
            if (txtNam.Checked == true)
            {
                return txtNam.Text;
            }
            else if (txtNu.Checked == true)
            {
                return txtNu.Text;
            }
            else
                return txtcxd.Text;
        }
        private void button2_Click(object sender, EventArgs e)//nút thêm
        {
            txtHoTen.Text = string.Empty;
            txtMSSV.Text = string.Empty;
            txtLop.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            if (txtNam.Checked == true)
                txtNam.Checked = false;
            if (txtNu.Checked == true)
                txtNu.Checked = false;
            if (txtcxd.Checked == true)
                txtcxd.Checked = false;
            txtMaVung.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtHoTen.Focus();
            button2.Visible = false;
            button1.Visible = true;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int Index = dataGridView1.CurrentCell.RowIndex;
            txtHoTen.Text = dataGridView1.Rows[Index].Cells[0].Value.ToString();
            txtMSSV.Text= dataGridView1.Rows[Index].Cells[1].Value.ToString();
            txtLop.Text= dataGridView1.Rows[Index].Cells[2].Value.ToString();
            dateTimePicker1.Value=Convert.ToDateTime(dataGridView1.Rows[Index].Cells[3].Value);
            txtMaVung.Text= dataGridView1.Rows[Index].Cells[5].Value.ToString();
            txtSDT.Text= dataGridView1.Rows[Index].Cells[6].Value.ToString();
            txtEmail.Text= dataGridView1.Rows[Index].Cells[7].Value.ToString();
            if (dataGridView1.Rows[Index].Cells[4].Value.ToString() == "Nam")
                txtNam.Checked = true;
            else if (dataGridView1.Rows[Index].Cells[0].Value.ToString() == "Nữ")
                txtNu.Checked = true;
            else
                txtcxd.Checked = true;

        }
        
        private void button3_Click(object sender, EventArgs e)//nút sữa
        {
            SaveOrEdit = 1;//đổi thành 1 để kiểm tra khi nút lưu là nút lưu của nút sữa
            button3.Visible = false;
            button1.Visible = true;

           
            
        }

        private void button4_Click(object sender, EventArgs e)//nút xóa
        {
            if(MessageBox.Show("Do you want to delete?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string conStr = "Data Source=DESKTOP-N3C8F8L\\HOANGUITK12; Initial Catalog=QLSV;InteGrated Security=true";
                SqlConnection myCon = new SqlConnection(conStr);
                myCon.Open();
                string CommTr = "DELETE FROM SinhVien WHERE MSSV='" + txtMSSV.Text + "'";
                SqlCommand myComm = new SqlCommand(CommTr, myCon);
                myComm.ExecuteNonQuery();
                myCon.Close();
                LoadData();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)//nút lưu
        {
            if (CheckData())
            {
                if (SaveOrEdit == 0)//saveoredit=0 là thêm
                {
                    string conStr = "Data Source=DESKTOP-N3C8F8L\\HOANGUITK12; Initial Catalog=QLSV;InteGrated Security=true";
                    SqlConnection myCon = new SqlConnection(conStr);
                    myCon.Open();
                    string CommTr = "INSERT INTO SinhVien(HoTen,MSSV,Lop,NgaySinh,GioiTinh,MaVung,SDT,Email) VALUES( N'" + txtHoTen.Text + "','" + txtMSSV.Text + "','" + txtLop.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' ,N'" + GioiTinhText() + "','" + txtMaVung.GetItemText(txtMaVung.SelectedItem) + "','" + txtSDT.Text.Trim() + "','" + txtEmail.Text + "')";
                    SqlCommand myComm = new SqlCommand(CommTr, myCon);
                    myComm.ExecuteNonQuery();
                    myCon.Close();
                    LoadData();
                    button2.Visible = true;
                    button1.Visible = false;
                }
                else//saveoreidt=1 là sữa
                {
                    string conStr = "Data Source=DESKTOP-N3C8F8L\\HOANGUITK12; Initial Catalog=QLSV;InteGrated Security=true";
                    SqlConnection myCon = new SqlConnection(conStr);
                    myCon.Open();
                    string CommTr = "UPDATE SinhVien SET HoTen=N'" + txtHoTen.Text + "',Lop='" + txtLop.Text + "',NgaySinh='" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "',GioiTinh=N'" + GioiTinhText() + "',MaVung='" + txtMaVung.GetItemText(txtMaVung.SelectedItem) + "',SDT='" + txtSDT.Text.Trim() + "',Email='" + txtEmail.Text + "'" + "WHERE MSSV='" + txtMSSV.Text + "'";
                    SqlCommand myComm = new SqlCommand(CommTr, myCon);
                    myComm.ExecuteNonQuery();
                    myCon.Close();
                    LoadData();
                    button3.Visible = true;
                    button1.Visible = false;
                }
            }
            
        }
        //Chuẩn hóa họ tên
        public static string FormatProperCase(string str)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }
        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.Text = FormatProperCase(txtHoTen.Text);
        }
        // kiem tra sdt hop le
        private bool isPhoneNumber(string pText)
        {
            Regex regex = new Regex(@"^\d{9,11}$");
            return regex.IsMatch(pText);
        }

        // kiem tra email hop le
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        // Kiem tra ho ten hop le
        private bool isName(string pText)
        {
            Regex regex = new Regex(@"\D[^~!@#$%^&*()_+-=\]{}|:'<>,.?`\/\\]{1,}$");
            return regex.IsMatch(pText);
        }

        //Ki?m tra ngày sinh hop le
        private bool isDoB(DateTime date)
        {
            DateTime now = DateTime.Now;
            if (17 <= now.Year - date.Year && now.Year - date.Year <= 35)
                return true;
            else return false;
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || isName(txtHoTen.Text)==false)
            {
                MessageBox.Show("Bạn nhập họ tên chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMSSV.Focus();
                return false;
            }
            if (isDoB(dateTimePicker1.Value.Date)==false)
            {
                MessageBox.Show("Ngày sinh chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return false;
            }
            if (txtNam.Checked == false && txtNu.Checked == false && txtcxd.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (string.IsNullOrEmpty(txtMaVung.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã vùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVung.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtSDT.Text) || isPhoneNumber(txtSDT.Text)==false)
            {
                MessageBox.Show("Bạn chưa nhập sdt hoặc sdt chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (isValidEmail(txtEmail.Text) ==false|| string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập Email hoặc email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        }

    }





