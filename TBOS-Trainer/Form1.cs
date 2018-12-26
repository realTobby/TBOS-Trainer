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

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            APPLICATION_RUNNING = true;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
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

        // RESEARCH OFFSETS
        // Fire rate => 144
        // DMG => 160
        // Range => 164
        // Range multiplier => 94
        // Shot height => 168
        // tier color1 => 184
        // tier color2 => 188
        // movement speed => 356
        // luck => 360


        // position teleport
        // -1852 x
        // -1848 y

        private void ExecuteHacks()
        {
            while (true)
            {
                if (PLAYERBASE_FOUND)
                {
                    if (chb_GodMode.Checked)
                    {
                        long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 4;
                        m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(24).ToString("X"));
                    }

                    if (chb_energy.Checked)
                    {
                        long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 380;
                        m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_maxEnergy.Text).ToString("X"));
                    }

                    if (chb_coins.Checked)
                    {
                        long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 36;
                        Console.WriteLine(tmpPlayerBase.ToString("x8"));
                        m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }

                    if (chb_bombs.Checked)
                    {
                        long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 32;
                        Console.WriteLine(tmpPlayerBase.ToString("x8"));
                        m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }

                    if (chb_bombs.Checked)
                    {
                        long tmpPlayerBase = PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 24;
                        Console.WriteLine(tmpPlayerBase.ToString("x8"));
                        m.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }
                }
                else
                {
                    FindPlayerBase();
                }
            }        
        }

        public void FindPlayerBase()
        {
            var playerScan = m.AoBScan("0", 0xffffffff, "?? ?? ?? ?? ?? 00 00 00 ?? 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 03 00 00 00 ?? ?? ?? ?? 00 00 00 00 ?? 00 00 00 ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF ?? 00 00 00");
            PLAYER_BASE_ADDRESS = playerScan.Result;
            PLAYER_BASE_ADDRESS -= 36;

            if(PLAYER_BASE_ADDRESS != -36  )
            {
                PLAYERBASE_FOUND = true;
            }

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

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if(PLAYERBASE_FOUND)
                {
                    string coord = "";

                    long xCoord = PLAYER_BASE_ADDRESS - 1852;
                    long yCoord = PLAYER_BASE_ADDRESS - 1848;

                    // PULL X Y COORDINATES
                    float x = m.readFloat((xCoord.ToString("x8")).ToString());
                    float y = m.readFloat((yCoord.ToString("x8")).ToString());
                    coord = x + "/" + y;
                    try
                    {
                        this.Invoke(new Action(() => this.lbl_coord.Text = coord));
                    }
                    catch (Exception idc)
                    {
                        Console.WriteLine("idc: " + idc.Message);
                    }

                    if (toggledTP)
                    {
                        m.writeMemory(xCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                        m.writeMemory(yCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                    }
                }
                
            }
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }


        public bool toggledTP = false;

        private void button3_Click(object sender, EventArgs e)
        {
            toggledTP = !toggledTP;

        }
    }
}

