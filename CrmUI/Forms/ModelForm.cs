using CrmBL.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrmUI.Forms
{
    public partial class ModelForm : Form
    {
        private readonly ShopModel model = new ShopModel();

        public ModelForm() => InitializeComponent();

        private void ButtonStart_Click
            (object sender, System.EventArgs e)
        {
            var CashDesks = new List<CashBoxView>();

            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var box = new CashBoxView(model.CashDesks[i], i, 10, 30 * i + 10);
                
                CashDesks.Add(box);
                AddToControls(box);
            }
            model.Start();
        }

        private void AddToControls(CashBoxView box)
        {
            Controls.Add(box.CashDeskName);
            Controls.Add(box.FullPrice);
            Controls.Add(box.QueueLength);
            Controls.Add(box.LeaveCustomersCount);
        }

        private void ModelForm_FormClosing
            (object sender, FormClosingEventArgs e) => model.Stop();

        private void ModelForm_Load
            (object sender, System.EventArgs e)
        {
            CustomerSpeed.Value = model.CustomerSpeed;
            CashDeskSpeed.Value = model.CashDeskSpeed;
        }

        private void NumericUpDown1_ValueChanged
            (object sender, System.EventArgs e)
        {
            model.CustomerSpeed = (int)CustomerSpeed.Value;
        }

        private void NumericUpDown2_ValueChanged
            (object sender, System.EventArgs e)
        {
            model.CashDeskSpeed = (int)CashDeskSpeed.Value;
        }
    }
}