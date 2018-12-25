using System;
using System.Drawing;
using System.Windows.Forms;
using Memory;

namespace TBOS_Trainer
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();

        public long PLAYER_BASE_ADDRESS = 0;

        public bool APPLICATION_RUNNING = false;

        public bool PLAYERBASE_FOUND = false;

        bool IsaacOpen = false;

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
            try
            {
                while (APPLICATION_RUNNING)
                {
                    int IsaacId = m.getProcIDFromName("isaac-ng");
                    if (IsaacId > 0)
                        IsaacOpen = m.OpenProcess(IsaacId);

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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ExecuteHacks()
        {
            while (true)
            {
                if (PLAYERBASE_FOUND == false)
                {
                    FindPlayerBase();
                    PLAYERBASE_FOUND = true;
                }

                // GOD MODE
                if (chb_GodMode.Checked)
                {
                    long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                    m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(24).ToString("X"));
                    tmpPlayerBase += 4;
                    m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(24).ToString("X"));
                }

                if (chb_energy.Checked)
                {
                    long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                    tmpPlayerBase += 380;
                    Console.WriteLine(tmpPlayerBase.ToString());
                    m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(6).ToString("X"));
                }


                // 154


            }        
        }

        public void FindPlayerBase()
        {
            var playerScan = m.AoBScan("0", 0xffffffff, "?? ?? ?? ?? ?? 00 00 00 ?? 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 03 00 00 00 ?? ?? ?? ?? 00 00 00 00 ?? 00 00 00 ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF ?? 00 00 00");
            PLAYER_BASE_ADDRESS = playerScan.Result;
            PLAYER_BASE_ADDRESS -= 36;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindPlayerBase();
            label2.Text = "Player address: " + PLAYER_BASE_ADDRESS;
            EnableHacks();
        }

        private void DisableHacks()
        {
            chb_energy.Enabled = false;
            chb_GodMode.Enabled = false;
        }

        private void EnableHacks()
        {
            chb_energy.Enabled = true;
            chb_GodMode.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long tmpPlayerBase = PLAYER_BASE_ADDRESS;
            tmpPlayerBase += 376;
            Console.WriteLine(tmpPlayerBase.ToString());
            m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_itemid.Text).ToString("X"));
        }
    }
}

