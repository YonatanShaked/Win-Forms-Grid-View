using System;
using System.Windows.Forms;

namespace SquareGridOfButtons
{
    public partial class GridViewForm : Form
    {
        private string[] names = { "Alice", "Bob", "Charlie", "David", "Eyal" };

        public GridViewForm()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.ColumnCount = 8;

            Random random = new Random();

            for (int row = 0; row < tableLayoutPanel.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
                {
                    Button button = new Button();
                    button.BackColor = System.Drawing.Color.Green;
                    button.Text = names[random.Next(names.Length)];
                    button.Dock = DockStyle.Fill;

                    button.Size = new System.Drawing.Size(100, 100);
                    button.Font = new System.Drawing.Font("Arial", 10);

                    button.Click += Button_Click;
                    tableLayoutPanel.Controls.Add(button, col, row);
                }
            }

            Controls.Add(tableLayoutPanel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            MessageBox.Show($"Button {clickedButton.Text} clicked!");

            if (clickedButton.BackColor == System.Drawing.Color.Green)
            {
                clickedButton.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                clickedButton.BackColor = System.Drawing.Color.Green;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GridViewForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(865, 570);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GridViewForm";
            this.Text = "Toleducko";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
