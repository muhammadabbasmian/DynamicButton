using System.Drawing.Drawing2D;

namespace DynamicButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int count1 = 1;
        int top = 83;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            for (int i = 0; i < count; i++)
            {
                count1 += 1;
                Button dynamicButton = new Button();
                this.Controls.Add(dynamicButton);

                dynamicButton.FlatStyle = FlatStyle.Flat;
                dynamicButton.FlatAppearance.BorderSize = 0;
                dynamicButton.Height = 40;

                dynamicButton.Width = 300;

                dynamicButton.BackColor = Color.MediumSlateBlue;

                dynamicButton.ForeColor = Color.White;



                dynamicButton.Location = new Point(20, top);

                dynamicButton.Text = "I am Dynamic Button" + count1;

                

                dynamicButton.Font = new Font("Georgia", 16);
                flowLayoutPanel1.Controls.Add(dynamicButton);
                dynamicButton.Click += new System.EventHandler(dynamicButton_Click);
                top += 50;
                count--;

            }
            


        }

        private void dynamicButton_Click(object? sender, EventArgs e)
        {
            Button dynamicButton =(Button)sender;
            MessageBox.Show(dynamicButton.Text.ToString());
        }
    }
}