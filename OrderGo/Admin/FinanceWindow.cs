using OrderGo.Samples;
using System;
using OrderGo.Database;


namespace OrderGo.Admin
{
    public partial class FinanceWindow : Sample2
    {
        public FinanceWindow()
        {
            InitializeComponent();
        }

        double sum = 0.0;

        private void FinanceWindow_Load(object sender, System.EventArgs e)
        {
            addButton.Visible = false;
            editButton.Visible = false;
            saveButton.Visible = false;
            deleteButton.Visible = false;
            groupBoxSearch.Visible = false;
            searchTextBox.Visible = false;
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
        }
        public override void viewButton_Click(object sender, EventArgs e)
        {
            Retreival.getFinance(financeDataGridView, dateGV, typeGV, totalGV, labelCount, dateTimePickerFrom.Text, dateTimePickerTo.Text);
            for (int i = 0; i < financeDataGridView.Rows.Count; i++)
                sum += Convert.ToDouble(financeDataGridView.Rows[i].Cells[3].Value);
            labelTotal.Text = sum.ToString();
        }
    }
}
