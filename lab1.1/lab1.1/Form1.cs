namespace lab1._1
{
    public partial class Form1 : Form
    {
        MyTime t = new MyTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            try
            {
                int h = int.Parse(textBoxH.Text);
                int m = int.Parse(textBoxM.Text);
                int s = int.Parse(textBoxS.Text);

                t = new MyTime(h, m, s);

                labelTime.Text = t.GetTime();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Неправильні дані");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int h = int.Parse(textBoxH.Text);
                int m = int.Parse(textBoxM.Text);
                int s = int.Parse(textBoxS.Text);

                t.ChangeTime(h, m, s);

                labelTime.Text = t.GetTime();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Неправильні дані");
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
           
            try
            {
                int h = int.Parse(textBoxH.Text);
                int m = int.Parse(textBoxM.Text);
                int s = int.Parse(textBoxS.Text);

                t.SubtractTime(h, m, s);

                labelTime.Text = t.GetTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}