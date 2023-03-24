using Business.Interfaces;
using Business.Services;
using DataAcces;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly IService<Log> loggerService = new LoggerService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void ButtonAddLog_Click(object sender, EventArgs e)
        {
            var log = new Log
            {
                TimeStamp = DateTime.Now,
                EventType = "Error",
                Source = "Presentation",
                User = "User123",
                Message = TextBoxLog.Text
            };

            loggerService.Add(log);

            LoadLogs();
        }

        private void LoadLogs()
        {
            DataGridViewLogs.DataSource = loggerService.GetAll();
        }
    }
}
