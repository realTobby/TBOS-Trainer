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

            GetPlayerAddress();

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
        // Shot height => 168




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
                        if(tbx_maxEnergy.Text != string.Empty)
                        {
                            long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                            tmpPlayerBase += 380;
                            Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_maxEnergy.Text).ToString("X"));
                        }
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

                    if (chb_keys.Checked)
                    {
                        long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
                        tmpPlayerBase += 24;
                        Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(99).ToString("X"));
                    }

                    if (chb_randTele.Checked)
                    {
                        long xCoord = Addresses.PLAYER_BASE_ADDRESS - 1852;
                        long yCoord = Addresses.PLAYER_BASE_ADDRESS - 1848;
                        Program.Memory.writeMemory(xCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                        Program.Memory.writeMemory(yCoord.ToString("x8"), "float", GetRandomNumber(0, 500).ToString());
                    }
                }

                Thread.Sleep(SLEEP_DELAY);
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long tmpPlayerBase = Addresses.PLAYER_BASE_ADDRESS;
            tmpPlayerBase += 376;
            Program.Memory.writeMemory(tmpPlayerBase.ToString("x8"), "byte", "0x" + Convert.ToInt64(tbx_itemid.Text).ToString("X"));
        }

        public float PLAYER_CURRENT_X = 0;
        public float PLAYER_CURRENT_Y = 0;

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

                    PLAYER_CURRENT_X = x;
                    PLAYER_CURRENT_Y = y;

                    coord = x + "/" + y;
                    try
                    {
                        Invoke(new Action(() => this.lbl_coord.Text = coord));
                    }
                    catch (Exception idc)
                    {
                        Console.WriteLine("idc: " + idc.Message);
                    }

                    
                }

                Thread.Sleep(SLEEP_DELAY);
            }
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPlayerAddress();
        }

        private void GetPlayerAddress()
        {
            label2.Text = "Player Address: " + Addresses.PLAYER_BASE_ADDRESS;
        }

        private void btn_writeStats_Click(object sender, EventArgs e)
        {
            Program.Memory.writeMemory(Addresses.PLAYER_STAT_FIRERATE.ToString("x8"), "int", nmb_firerate.Value.ToString());
            Program.Memory.writeMemory(Addresses.PLAYER_STAT_MOVEMENTSPEED.ToString("x8"), "float", nmb_movementspeed.Value.ToString());

            Program.Memory.writeMemory(Addresses.PLAYER_STAT_RANGEMULTIPLIER.ToString("x8"), "float", nmb_rangemultiplier.Value.ToString());
            Program.Memory.writeMemory(Addresses.PLAYER_STAT_RANGE.ToString("x8"), "float", nmb_range.Value.ToString());
            Program.Memory.writeMemory(Addresses.PLAYER_STAT_LUCK.ToString("x8"), "float", nmb_luck.Value.ToString());
            Program.Memory.writeMemory(Addresses.PLAYER_STAT_DAMAGE.ToString("x8"), "float", nmb_damage.Value.ToString());
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            nmb_firerate.Value = Program.Memory.readInt(Addresses.PLAYER_STAT_FIRERATE.ToString("x8"));
            nmb_movementspeed.Value = Convert.ToDecimal(Program.Memory.readFloat(Addresses.PLAYER_STAT_MOVEMENTSPEED.ToString("x8")));
            nmb_luck.Value = Convert.ToDecimal(Program.Memory.readFloat(Addresses.PLAYER_STAT_LUCK.ToString("x8")));
            nmb_rangemultiplier.Value = Convert.ToDecimal(Program.Memory.readFloat(Addresses.PLAYER_STAT_RANGEMULTIPLIER.ToString("x8")));
            nmb_range.Value = Convert.ToDecimal(Program.Memory.readFloat(Addresses.PLAYER_STAT_RANGE.ToString("x8")));
            nmb_damage.Value = Convert.ToDecimal(Program.Memory.readFloat(Addresses.PLAYER_STAT_DAMAGE.ToString("x8")));

            //var res = Program.Memory.readByte(Addresses.PLAYER_STAT_TEAR_COLOR_BORDER.ToString("x8"));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tear_color.ShowDialog() == DialogResult.OK)
            {
                var test = tear_color.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tear_color_border.ShowDialog() == DialogResult.OK)
            {
                var test = tear_color_border.Color;
            }
        }
    }
}
