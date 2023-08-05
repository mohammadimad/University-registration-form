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
    public partial class Form2 : Form
    {
        private string ImagePath;
        string value;
        public Form2(string _IdentityPhoneNumber,string _Nationalty,string _PassortValidtryDate,
            string _FirstName,string _LastName,string _Gender,string _BirthDate,string _IdType,
            bool _dontPassport,
            string _FatherName,string _MotherName,string _Address,string _PostCode,
            string _Country, string _Province,string _District,string _Phone,string _Email,
            string _ExamType,string _ExamGrade,string _ExamDate,string _Program,string _ImagePath)
        {
            InitializeComponent();
            lblPassportNo.Text = _IdentityPhoneNumber;
            lblFirstName.Text = _FirstName;
            lblLastName.Text = _LastName;
            lblNationaltity.Text = _Nationalty;
            lblFatherName.Text= _FatherName;
            lblMotherName.Text = _MotherName;
            lblBirthDay.Text = _BirthDate;
            lblGender.Text = _Gender;

            lblAddress.Text = _Address;
            lblCountry.Text = _Country;
            lblProvince.Text = _Province;
            lblPhoneNo.Text = _Phone;
            lblEmail.Text = _Email;

            lblExamType.Text = _ExamType;
            lblExamGrade.Text = _ExamGrade;
            lblExamDate.Text = _ExamDate;

            value = _Program;
            ImagePath = _ImagePath;
        }

        void GetProgrms()
        {
            
            string[] lines = value.Split(new[] { "\n" }, StringSplitOptions.None);
            int counter = lines.Length;
            if (true)
            {
                counter--;
                if (counter == 0)
                    return;
                lblProg1.Text = lines[0];
                if (counter == 0)
                    return;
                counter--;
                lblProg2.Text = lines[1];
                if (counter == 0)
                    return;
                counter--;
                lblProg3.Text = lines[2];
                if (counter == 0)
                    return;
                counter--;
                lblProg4.Text = lines[3];
                if (counter == 0)
                    return;
                counter--;
                lblProg5.Text = lines[4];
                if (counter == 0)
                    return;
                counter--;
                lblProg6.Text = lines[5];
                if (counter == 0)
                    return;
                counter--;
                lblProg7.Text = lines[6];
                if (counter == 0)
                    return;
                counter--;
                lblProg8.Text = lines[7];
                if (counter == 0)
                    return;
                counter--;
                lblProg9.Text = lines[8];
                if (counter == 0)
                    return;
                counter--;
                lblProg10.Text = lines[9];
                
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GetProgrms();
            if (!string.IsNullOrWhiteSpace(ImagePath))
                pictureBox1.Image = Image.FromFile(ImagePath);
        }
    }
}
