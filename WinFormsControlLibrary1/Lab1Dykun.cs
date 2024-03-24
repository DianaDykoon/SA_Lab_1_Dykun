namespace WinFormsControlLibrary1
{
    [ToolboxBitmap(@"C:\Users\User\Desktop\лабы 4\.Net\Solution1\WinFormsControlLibrary1\Lab1Dykun.ico")]
    public partial class Lab1Dykun : UserControl
    {
        private double number; // Властивість - число
        private double meters; // Властивість - метри
        private string? unit; // Властивість - одиниця довжини

        public Lab1Dykun()
        {
            InitializeComponent();
        }

        public double Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }

        public double Meters
        {
            get { return meters; }
            set
            {
                meters = value;
                lblResultMeter.Text = meters.ToString();
            }
        }

        public string Unit
        {
            get { return unit!; }
            set
            {
                unit = value;
                switch (unit)
                {
                    case "мм":
                        Meters = number / 1000;
                        break;
                    case "см":
                        Meters = number / 100;
                        break;
                    case "дм":
                        Meters = number / 10;
                        break;
                    case "м":
                        Meters = number;
                        break;
                    default:
                        Meters = 0;
                        break;
                }
            }
        }

        // Подія введення у TextBox
        private void txtBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Вводіть тількі цілі числа", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.KeyChar = '\0';
            }
        }

        // Подія зміни індекса у ComboBox
        private void cmbBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Unit = cmbBox1.Text;
        }

        // Подія зміни текста в TextBox
        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (txtBoxInput.Text == "")
            {
                lblResultMeter.Text = "0";
            }

            if (!double.TryParse(txtBoxInput.Text, out value))
            {
                return;
            }

            Number = value;

            switch (cmbBox1.SelectedIndex)
            {
                case 0:
                    Meters = number / 1000;
                    break;
                case 1:
                    Meters = number / 100;
                    break;
                case 2:
                    Meters = number / 10;
                    break;
                case 3:
                    Meters = number;
                    break;
                default:
                    Meters = 0;
                    MessageBox.Show("Виберіть одиницю довжини", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            lblResultMeter.Text = meters.ToString();
        }
    }
}

