using System;
using System.Windows.Forms;

namespace Design
{
    public partial class AgeCalculator : Form
    {

        public AgeCalculator()
        {
            InitializeComponent();
            DT_DateOfBirth.MaxDate = DateTime.Today;
            DT_SpecificDate.MaxDate = DateTime.Today;
            DT_DateOfBirth_ValueChanged(DT_DateOfBirth, EventArgs.Empty);

        }
        DateTime FromDateTime;
        DateTime ToDateTime;
        private void CB_Custom_CheckedChanged(object sender, System.EventArgs e)
        {
            DT_SpecificDate.Enabled = ((CheckBox)sender).Checked;

        }

        private Byte _GetMonthDaysNumber(Byte MonthNumber)
        {
            Byte[] Arr_MonthsDays = new byte[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return (byte)((MonthNumber == 2) ? (DateTime.IsLeapYear(Byte.Parse(TB_Years.Text)) ? 29 : 28) : Arr_MonthsDays[MonthNumber - 1]);
        }

        private void BT_Calculate_Click(object sender, System.EventArgs e)
        {
            if (CB_Custom.Checked)
                ToDateTime = DT_SpecificDate.Value.Date;
            else
                ToDateTime = DateTime.Today;


            TimeSpan Span = ToDateTime.Subtract(FromDateTime);
            DateTime Age = DateTime.MinValue + Span;

            Byte Years = Convert.ToByte(Age.Year - 1);
            Byte Months = Convert.ToByte(Age.Month - 1);
            Byte Days = Convert.ToByte(Age.Day - 1);

            TB_Years.Text = Years.ToString();
            TB_Months.Text = Months.ToString();
            TB_Days.Text = Days.ToString();


            //TB_Months.Text
            //TB_Days.Text =
        }



        private void DT_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            FromDateTime = DT_DateOfBirth.Value.Date;
        }
    }
}