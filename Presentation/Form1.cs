using Business.Interfaces;
using Business.Services;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private readonly ILoggerService loggerService = new LoggerService();
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
            var TimeStamp = DateTime.Now;
            var EventType = "Error";
            var Source = "Presentation";
            var User = "User123";
            var Message = "An error has occurred.";

            loggerService.Add(TimeStamp, EventType, Source, User, Message);

            LoadLogs();
        }

        private void LoadLogs()
        {
            DataGridViewLogs.DataSource = loggerService.GetAll();
        }

    }
}
