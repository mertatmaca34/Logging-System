using System;
using Business.Interfaces;
using System.Windows.Forms;
using System.Collections.Generic;
using Business.Services;
using System.ComponentModel.DataAnnotations;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly ILoggerService loggerService = new LoggerService();
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonAddLog_Click(object sender, EventArgs e)
        {
            var log = new Log
            {
                TimeStamp = DateTime.Now,
                EventType = "Info",
                Source = "PC",
                User = "Mert",
                Message = "Örnek log"
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
