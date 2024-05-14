using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace 日曆
{
    public partial class Form2 : Form
    {
        private DateTime _selectedDate;
        private List<Expense> expenses = new List<Expense>();

        public Form2(DateTime selectedDate)
        {
            InitializeComponent();
            _selectedDate = selectedDate;
            dateTimePicker1.Value = _selectedDate; // 設置日期選擇器的值為選擇的日期
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            string expenseName = accountNameTextBox.Text;
            decimal amount;
            bool isAmountValid = decimal.TryParse(initialBalanceTextBox.Text, out amount);

            if (isAmountValid)
            {
                Expense newExpense = new Expense(expenseName, amount, _selectedDate);
                expenses.Add(newExpense);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。");
            }
        }

        private void balanceQueryButton_Click(object sender, EventArgs e)
        {
            decimal dailyTotal = expenses
                .Where(expense => expense.Date.Date == _selectedDate.Date)
                .Sum(expense => expense.Amount);

            MessageBox.Show($"當日總開銷: {dailyTotal:C}");
        }

        private void UpdateDataGridView()
        {
            accountsDataGridView.Rows.Clear();
            foreach (var expense in expenses)
            {
                accountsDataGridView.Rows.Add(expense.Name, expense.Amount);
            }
        }
    }
}