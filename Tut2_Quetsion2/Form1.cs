using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut2_Quetsion2
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;
        private Data[] data;
        private int currentIndex = 0;  
       
       

        public Form1()
        {

            InitializeComponent();
            dataManager = new DataManager();
            data= dataManager.ReadFromFile();
            
        }


        private void DisplayData(Data[] data)
        {
            dataList.Items.Clear();
            foreach (Data item in data)
            {

                dataList.Items.Add($"{item.Number}\t\t{item.Name}\t\t{item.Surname}\t\t{item.Email}\t\t{item.Gender}\t\t{item.Ip}");

               


            }
        }


        private void UpdateRecord()
        {
            if (data != null && data.Length > 0)
            {
                Data currentData = data[currentIndex];
                numberTxbx.Text = currentData.Number.ToString();
                nameTxbx.Text = currentData.Name;
                surnameTxbx.Text = currentData.Surname;
                emailTxbx.Text = currentData.Email;
                genderGrpbx.Text = currentData.Gender;                
                ipTxbx.Text = currentData.Ip;
            }
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        
        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= data.Length)
            {
                currentIndex = 0;
            }
            UpdateRecord();
            UpdateGenderGroupBoxText();

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = data.Length - 1;
            }
            UpdateRecord();
            UpdateGenderGroupBoxText();
        }
        private void UpdateGenderGroupBoxText()
        {
            
            if (data != null && data.Length > 0)
            {
                genderGrpbx.Text = $"Gender";
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {


            if (data != null && data.Length > 0)
            {
                currentIndex = 0;
                UpdateRecord();
                UpdateGenderGroupBoxText();
            }
        }

        private void dotcomRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Data[] filteredData = dataManager.determineDomain(".com");
                DisplayData(filteredData);
            }
            else
            {
                dataList.Items.Clear(); 
            }

        }

        private void dotgovRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Data[] filteredData = dataManager.determineDomain(".gov");
                DisplayData(filteredData);
            }

        }

        private void doteduRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
               
                Data[] filteredData = dataManager.determineDomain(".edu");
                DisplayData(filteredData);
            }
        }

        private void dotruRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
             
                Data[] filteredData = dataManager.determineDomain(".ru");
                DisplayData(filteredData);
            }
        }

        private void dotukRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
               
                Data[] filteredData = dataManager.determineDomain(".uk");
                DisplayData(filteredData);
            }
        }

        private void dotjpRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                
                Data[] filteredData = dataManager.determineDomain(".jp");
                DisplayData(filteredData);
            }
        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {

                Data[] filteredData = data.Where(item => item.Gender.ToLower() == "female").ToArray();
                DisplayData(filteredData);
                
            }

        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Data[] filteredData = data.Where(item => item.Gender.ToLower() == "male").ToArray();
                DisplayData(filteredData);
            }

        }
    }
}
