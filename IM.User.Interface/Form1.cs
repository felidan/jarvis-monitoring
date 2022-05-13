using IM.Domain.Model;
using IM.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM.User.Interface
{
    public partial class Form1 : Form
    {
        private DateTime NextUpdate = DateTime.MinValue;
        private readonly IntegrationsProcessService _IPService;
        List<Label> LabelsProcess = new List<Label>();

        public Form1()
        {
            _IPService = new IntegrationsProcessService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbl_hello.Text = "Hello!";
            this.lbl_next_update.Text = "";
            GetLastProcess();
            UpdateServices();
        }

        private void UpdateMessageHello()
        {
            string message = "";
            var currentDate = DateTime.Now;
            if (currentDate.Hour >= 5 && currentDate.Hour < 12)
                message = "Good morning!";
            else if (currentDate.Hour >= 12 && currentDate.Hour < 19)
                message = "Good afternoon!";
            else if (currentDate.Hour >= 19)
                message = "Good evening!";

            this.lbl_hello.Invoke((MethodInvoker)delegate
            {
                this.lbl_hello.Text = message;
            });
        }

        private void GetLastProcess()
        {
            var process = _IPService.GetLastProcess();
            if(process != null)
                PrintAndOrganizeProcess(process);
        }

        private void PrintAndOrganizeProcess(Process process)
        {
            this.panelIntegration.Invoke((MethodInvoker)delegate {
                this.panelIntegration.Controls.Clear();
            });

            LabelsProcess = new List<Label>();
            var positionX = this.panelIntegration.Location.X;
            var positionY = this.panelIntegration.Location.Y;

            int index = 0;
            bool swap = false;
            process.UrlsServices
                .OrderBy(x => x.System)
                .ToList()
                .ForEach(item =>
            {
                LabelsProcess.AddRange(CreateNewLabal(item, positionX, positionY));

                if (index > (process.UrlsServices.Count / 2) && !swap)
                {
                    positionX = this.panelIntegration.Size.Width / 2;
                    positionY = this.panelIntegration.Location.Y;
                    swap = true;
                }
                else
                    positionY += 30;
                
                index++;
            });
            
            this.panelIntegration.Invoke((MethodInvoker)delegate {
                this.panelIntegration.Controls.AddRange(LabelsProcess.ToArray());
            });
        }

        private List<Label> CreateNewLabal(ServiceItem item, int positionX, int positionY)
        {
            List<Label> labels = new List<Label>();
            string imgType = "";

            var labelMsg = new Label()
            {
                Text = $" {item.Type} - {item.Description}",
                Location = new Point(positionX + 20, positionY),
                Height = 20,
                Width = (this.panelIntegration.Size.Width / 2) - 40,
                TextAlign = ContentAlignment.MiddleLeft,
            };

            GetToolTip(item, labelMsg);
            
            var labelImg = new Label()
            {
                Location = new Point(positionX, positionY),
                Height = 20,
                Width = 20,
            };

            if (item.Status == "OK")
                imgType = "green.jpg";
            else if (item.Status == "ERR")
                imgType = "red.jpg";
            else if (item.Status == "WRN")
                imgType = "orange.jpg";

            Image img = Image.FromFile($"{Directory.GetCurrentDirectory()}\\assets\\{imgType}");
            labelImg.Image = img;

            labels.Add(labelMsg);
            labels.Add(labelImg);
            return labels;

        }

        private void GetToolTip(ServiceItem item, Label labelMsg)
        {
            ToolTip toolTip = new ToolTip();
            StringBuilder msg = new StringBuilder();
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
            
            msg.AppendLine($"System: {item.System}");
            msg.AppendLine($"Type: {item.Type}");
            msg.AppendLine($"Description: {item.Description}");
            msg.AppendLine($"Url: {item.Url}");
            msg.AppendLine($"Status: {item.Status}");
            msg.AppendLine($"HttpVerb: {item.HttpVerb}");
            msg.AppendLine($"SeekToOk: {item.SeekToOk}");
            msg.AppendLine($"Error: {item.Error}");

            toolTip.SetToolTip(labelMsg, msg.ToString());

        }

        private void UpdateServices()
        {
            Task.Factory.StartNew(() => 
            {
                while (true)
                {
                    if(NextUpdate <= DateTime.Now)
                    {
                        UpdateMessageHello();
                        SetNextUpdate(true);
                        _IPService.UpdateProcess();
                        GetLastProcess();
                        SetNextUpdate();
                    }
                }
            });
        }
        
        private void SetNextUpdate(bool updating = false)
        {
            if (updating)
            {
                this.lbl_next_update.ForeColor = Color.Orange;
                this.lbl_next_update.Invoke((MethodInvoker)delegate {
                    this.lbl_next_update.Text = "Updating...";
                });
            }
            else
            {
                this.lbl_last_update.Invoke((MethodInvoker)delegate {
                    this.lbl_last_update.Text = "Last Update: " + DateTime.Now.ToString();
                });

                var interval = ConfigurationManager.AppSettings.Get("Interval");
                NextUpdate = DateTime.Now.AddMinutes(int.Parse(interval));
                
                this.lbl_next_update.Invoke((MethodInvoker)delegate {
                    this.lbl_next_update.ForeColor = Color.Green;
                    this.lbl_next_update.Text = "Next Update: " + NextUpdate.ToString();
                });
            }
        }
    }
}
