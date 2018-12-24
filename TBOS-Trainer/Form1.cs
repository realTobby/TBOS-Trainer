using System;
using System.Drawing;
using System.Windows.Forms;
using Memory;

namespace TBOS_Trainer
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();

        public bool APPLICATION_RUNNING = false;

        public bool PLAYERBASE_FOUND = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            APPLICATION_RUNNING = true;
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while(APPLICATION_RUNNING)
            {
                int IsaacId = m.getProcIDFromName("isaac-ng");
                bool IsaacOpen = false;
                if (IsaacId > 0)
                    IsaacOpen = m.OpenGameProcess(IsaacId);

                if (IsaacOpen == true)
                {
                    this.Invoke(new MethodInvoker(() => this.label1.Text = "Found Binding of Isaac: Rebirth"));
                    this.Invoke(new MethodInvoker(() => this.label1.ForeColor = Color.Green));
                    if (PLAYERBASE_FOUND == false)
                        FindPlayerBase();
                }
                else
                {
                    this.Invoke(new MethodInvoker(() => this.label1.Text = "STATUS: Waiting for Binding of Isaac: Rebirth"));
                }
            }
            

        }

        private void FindPlayerBase()
        {
            var res = m.AoBScan(0x00DA0000, 0x00000B68, "8B 82 68 0B 00 00");
            this.Invoke(new MethodInvoker(() => this.label2.Text = "Player base Address: " + res));
            PLAYERBASE_FOUND = true;
        }
    }
}

