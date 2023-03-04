
//My Contacts: email kmtflx@gmail.com
//Whatsapp: +254113500084
//Twitter: @s_kimza

namespace WeeksTime
{
    public partial class WeekHour : Form
    {
        public WeekHour()
        {
            InitializeComponent();
        }


        //array holds number of hours
        int[] hours_per_day = new int[7];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbDaysWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedDay.Text = cmbDaysWeek.SelectedItem.ToString();

            int hours_worked = int.Parse(txtboxTime.Text.Trim());

            if (cmbDaysWeek.Text.Equals("Monday"))
            {
                hours_per_day[0] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Tuesday"))
            {
                hours_per_day[1] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Wednesday"))
            {
                hours_per_day[2] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Thursday"))
            {

                hours_per_day[3] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Friday"))
            {

                hours_per_day[4] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Saturday"))
            {

                hours_per_day[5] = hours_worked;
            }
            else if (cmbDaysWeek.Text.Equals("Sunday"))
            {
                hours_per_day[6] = hours_worked;
            }
        }

        private void txtUserVal_TextChanged(object sender, EventArgs e)
        {
            //clear the lable
            lblHoursW.Text = "";

            //StringComparison.InvariantCultureIgnoreCase - ingore string case

            if (txtUserVal.Text.Equals("Monday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[0].ToString();
            }else if (txtUserVal.Text.Equals("Tuesday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[1].ToString();
            }
            else if (txtUserVal.Text.Equals("Wednesday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[2].ToString();
            }
            else if (txtUserVal.Text.Equals("Thursday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[3].ToString();
            }
            else if (txtUserVal.Text.Equals("Friday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[4].ToString();
            }
            else if (txtUserVal.Text.Equals("Saturday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[5].ToString();
            }
            else if (txtUserVal.Text.Equals("Sunday", StringComparison.InvariantCultureIgnoreCase))
            {
                lblHoursW.Text = hours_per_day[6].ToString();
            }
        }

        private void lblHoursW_Click(object sender, EventArgs e)
        {
            ///lblHoursW.Text = "";
        }
    }
}
