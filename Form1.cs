using System.Globalization;

namespace 日曆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // 獲取所選日期
            DateTime selectedDate = monthCalendar1.SelectionStart;
            DateTime today = DateTime.Today;

            if (selectedDate.Date == today)
            {
                // 如果是今天，則打開日記視窗
                OpenDiaryForm(selectedDate);
            }
            else
            {
                // 否則檢查是否有日記內容
                string diaryContent = DiaryManager.GetDiaryContent(selectedDate);
                if (string.IsNullOrEmpty(diaryContent))
                {
                    // 如果有日記內容，則打開日記視窗
                    OpenDiaryForm(selectedDate);
                }
                else
                {
                    MessageBox.Show("該日期沒有日記內容。");
                }
            }

        }
        private void OpenDiaryForm(DateTime date)
        {
            diarycs diaryForm = new diarycs(this, date);
            diaryForm.Owner = this;
            // 設置 diaryForm 的 dateTimePicker1 控件的值為所選日期
            diaryForm.SetDateTimePickerValue(date);
            diaryForm.ShowDialog();

        }

        // 假設 DiaryManager 是用於管理日記內容的類別
        public static class DiaryManager
        {
            private static Dictionary<DateTime, string> diaryEntries = new Dictionary<DateTime, string>();

            // 假設 GetDiaryContent 方法用於根據日期獲取日記內容
            public static string GetDiaryContent(DateTime date)
            {
                // 在這裡實現根據日期獲取日記內容的邏輯
                // 假設 diaryEntries 是一個字典，保存了日期與日記內容的對應關係
                if (diaryEntries.ContainsKey(date))
                {
                    return diaryEntries[date];
                }
                else
                {
                    return null;
                }
            }
            // 假設 AddDiaryEntry 方法用於添加新的日記內容
            public static void AddDiaryEntry(DateTime date, string content)
            {
                // 在這裡實現添加日記內容的邏輯
                // 假設 diaryEntries 是一個字典，保存了日期與日記內容的對應關係
                diaryEntries[date] = content;
            }
        }
    }
}