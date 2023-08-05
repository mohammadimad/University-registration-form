using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dptBirthDay.MaxDate = DateTime.Now;
        }
         stInfo Info;
        struct stInfo {
            public string IdentityPhoneNumber;
            public string Nationalty;
            public string PassortValidtryDate;
            public string FirstName;
            public string LastName;
            public string Gender;
            public string BirthDate;
            public string IdType;
            public bool dontPassport;
            public string FatherName;
            public string MotherName;
            public string Address;
            public string PostCode;
            public string Country;
            public string Province;
            public string District;
            public string Phone;
            public string Email;
            public string ExamType;
            public string ExamGrade;
            public string ExamDate;
            public string Program;
            public string ImagePath;
        }
        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.Black;
            Pen penWhite = new Pen(white);
            penWhite.Width = 5;
            penWhite.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            penWhite.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            e.Graphics.DrawRectangle(penWhite, 887, 17, 96, 97);
        }

        
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (cbProgram.Text != "")
            {
                txtProgram.Text += cbProgram.Text + Environment.NewLine;
                cbProgram.Items.RemoveAt(cbProgram.SelectedIndex);
                
               
            }
            else
            {
                MessageBox.Show("Please selected Program");
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File  (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                Info.ImagePath = openFileDialog.FileName;
            }
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnNextPage2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnNextPage3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnPreviousPage2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnPreviousPage1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Info.IdentityPhoneNumber = mtxtIdentityPassportNumber.Text;
            Info.Nationalty = cbNationality.Text;
            Info.PassortValidtryDate = dptPassortValidtryDate.Value.ToString();
            Info.FirstName = txtFirstName.Text;
            Info.LastName = txtLastName.Text;
            Info.Gender = cbGender.Text;
            Info.BirthDate = dptBirthDay.Value.ToString();
            Info.IdType = cbIDType.Text;
            Info.dontPassport = chb1.Checked;
            Info.FatherName = txtFatherName.Text;
            Info.MotherName = txtMother.Text;
            Info.Address = txtAdress.Text;
            Info.PostCode = txtPostCode.Text;
            Info.Country = cbCoutryOfResidence.Text;
            Info.Province = txtProvince.Text;
            Info.District = txtDistrict.Text;
            Info.Phone = mtxtMobilephone.Text;
            Info.Email = txtEmail.Text;
            Info.ExamType = cbExamType.Text;
            Info.ExamGrade = mtxtExamGrade.Text;
            Info.Program = txtProgram.Text;
            Info.ExamDate = dtpExamDate.Value.ToString();

            Form2 Form23 = new Form2(Info.IdentityPhoneNumber, Info.Nationalty, Info.PassortValidtryDate,
                Info.FirstName, Info.LastName, Info.Gender, Info.BirthDate,
                 Info.IdType, Info.dontPassport,
                 Info.FatherName, Info.MotherName, Info.Address, Info.PostCode, Info.Country,
                 Info.Province, Info.District, Info.Phone, Info.Email, Info.ExamType,
                 Info.ExamGrade, Info.ExamDate, Info.Program, Info.ImagePath);

            Form23.ShowDialog();
        }

        
    }
}
