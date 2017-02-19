using System;
using System.Linq;
using System.Windows.Forms;

namespace DataSecurity1.LitteralStatistic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            var result = Analyzer.CountLettersIncomes(InputRichBox.Text ?? string.Empty);

            var resultArray = result.Select(r => new { Letter = r.Key, Count = r.Value });
            resultGridView.DataSource = resultArray.ToArray();
        }
    }
}