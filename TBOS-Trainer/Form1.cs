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

        public uint PLAYERBASE_ADDRESS = 0x15271A18;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            APPLICATION_RUNNING = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                while (APPLICATION_RUNNING)
                {
                    int IsaacId = m.getProcIDFromName("isaac-ng");
                    bool IsaacOpen = false;
                    if (IsaacId > 0)
                        IsaacOpen = m.OpenGameProcess(IsaacId);

                    if (IsaacOpen == true)
                    {
                        this.Invoke(new MethodInvoker(() => this.label1.Text = "Found Binding of Isaac: Rebirth"));
                        this.Invoke(new MethodInvoker(() => this.label1.ForeColor = Color.Green));
                        ExecuteHacks();
                    }
                    else
                    {
                        this.Invoke(new MethodInvoker(() => this.label1.Text = "STATUS: Waiting for Binding of Isaac: Rebirth"));
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ExecuteHacks()
        {
            if(chb_godmode.Checked == true)
            {
                m.writeMemory("base+0xB50", "byte", "24");
                m.writeMemory("base+0xB54", "byte", "24");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            APPLICATION_RUNNING = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            long res = m.AoBScan(0x00000000, 0x9999999, "8B 82 68 0B 00 00").ToInt32();
            MessageBox.Show(res.ToString("x8"));
            */

            for(int i=0; i<25500; i++)
                Console.WriteLine(m.readByte(i.ToString()) + "," + Environment.NewLine);
        }
    }
}

