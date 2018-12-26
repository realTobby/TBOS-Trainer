using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TBOS_Trainer.Trainer;

namespace TBOS_Trainer
{
    public partial class Form1 : Form
    {
        const int SLEEP_DELAY = 250;

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.ApplicationRunning = true;

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
            while (Program.ApplicationRunning)
            {
                if (Context.Attached)
                {
                    Invoke(new MethodInvoker(() => label1.Text = "Found Binding of Isaac: Rebirth"));
                    Invoke(new MethodInvoker(() => label1.ForeColor = Color.Green));

                    ExecuteHacks();
                }
                else
                {
                    Invoke(new MethodInvoker(() => label1.Text = "STATUS: Waiting for Binding of Isaac: Rebirth"));

                    Context.Attach();
                }

                Thread.Sleep(SLEEP_DELAY);
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
                if (Addresses.PlayerBaseAddressFound)
                {
                    if (chb_GodMode.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 4;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(24).ToString("X"));
                    }

                    if (chb_energy.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 380;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_maxEnergy.Text).ToString("X"));
                    }

                    if (chb_coins.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 36;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }

                    if (chb_bombs.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 32;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }

                    if (chb_bombs.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 24;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }
                }

                Thread.Sleep(SLEEP_DELAY);
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Player address: " + Addresses.PLAYER_BASE_ADDRESS;
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
            long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
            tmpPlayerBase += 376;
            Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_itemid.Text).ToString("X"));
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if(Addresses.PlayerBaseAddressFound)
                {
                    string coord = "";

                    long xCoord = Addresses.PLAYER_BASE_ADDRESS - 1852;
                    long yCoord = Addresses.PLAYER_BASE_ADDRESS - 1848;

                    // PULL X Y COORDINATES
                    float x = Program.Memory.readFloat((xCoord.ToString("x8")).ToString());
                    float y = Program.Memory.readFloat((yCoord.ToString("x8")).ToString());
                    coord = x + "/" + y;
                    try
                    {
                        Invoke(new Action(() => this.lbl_coord.Text = coord));
                    }
                    catch (Exception idc)
                    {
                        Console.WriteLine("idc: " + idc.Message);
                    }

                    if (toggledTP)
                    {
                        Program.Memory.writeMemory(xCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                        Program.Memory.writeMemory(yCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                    }
                }

                Thread.Sleep(SLEEP_DELAY);
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
