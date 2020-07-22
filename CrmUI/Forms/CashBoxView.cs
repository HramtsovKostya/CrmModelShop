using CrmBL.DataBase;
using CrmBL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrmUI.Forms
{
    public class CashBoxView
    {
        public Label CashDeskName { get; set; }
        public NumericUpDown FullPrice { get; set; }
        public ProgressBar QueueLength { get; set; }
        public Label LeaveCustomersCount { get; set; }

        private readonly CashDesk cashDesk;

        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            Label1Create(number, x, y);
            Label2Create(number, x, y);
            NumericUpDownCreate(number, x, y);
            ProgressBarCreate(number, x, y);            

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void Label1Create(int number, int x, int y)
        {
            CashDeskName = new Label
            {
                AutoSize = true,
                Location = new Point(x, y),
                Name = $"CashDeskName{number + 1}",
                Size = new Size(50, 17),
                TabIndex = number + 1,
                Text = cashDesk.ToString()
            };
        }

        private void Label2Create(int number, int x, int y)
        {
            LeaveCustomersCount = new Label
            {
                AutoSize = true, Text = "",
                Location = new Point(x + 480, y),
                Name = $"QueueLength{number + 1}",
                Size = new Size(50, 17),
                TabIndex = number + 4
            };
        }

        private void ProgressBarCreate(int number, int x, int y)
        {
            QueueLength = new ProgressBar()
            {
                Location = new Point(x + 240, y - 2),
                Maximum = cashDesk.MaxQueueLength,
                Name = $"QueueLength{number + 1}",
                Size = new Size(230, 20),
                Step = 1, Value = 0,
                TabIndex = number + 3
            };
        }

        private void NumericUpDownCreate(int number, int x, int y)
        {
            FullPrice = new NumericUpDown
            {
                ReadOnly = true, Increment = 0,
                Location = new Point(x + 65, y - 2),
                Name = $"Price{number + 1}",
                Size = new Size(160, 17),
                Maximum = 1000000000000000,
                TabIndex = number + 2
            };
        }        

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            FullPrice.Invoke((Action)delegate 
            {
                FullPrice.Value += e.Price;
                QueueLength.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}