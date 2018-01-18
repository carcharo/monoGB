using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libGBSYS;

namespace MyFirstGBEmu
{
    public partial class MainScreen : Form
    {

        Gameboy gameboy;

        public MainScreen() {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e) {
            cpuInstrucList.Items.Clear();
        }

        private void stepOneBtn_Click(object sender, EventArgs e) {

        }

        private void loadGameROM_Click(object sender, EventArgs e) {
            gameboy = new Gameboy("C:\\Users\\barry\\OneDrive\\Emulator Stuff\\Gameboy\\ROMS\\tetris.gb");
            zeroFlagBox.Checked = gameboy.GBCPU.ZeroFlag;
            underFlowBox.Checked = gameboy.GBCPU.UnderflowFlag;
            nibbleOverBox.Checked = gameboy.GBCPU.NibbleCarryFlag;
            fullOverBox.Checked = gameboy.GBCPU.FullCarryFlag;
            AFRegText.Text = gameboy.GBCPU.A.ToString() + ":" + gameboy.GBCPU.F.ToString();
            BCRegText.Text = gameboy.GBCPU.B.ToString() + ":" + gameboy.GBCPU.C.ToString();
            DERegText.Text = gameboy.GBCPU.D.ToString() + ":" + gameboy.GBCPU.E.ToString();
            HLRegText.Text = gameboy.GBCPU.H.ToString() + ":" + gameboy.GBCPU.L.ToString();
            pcBox.Text = gameboy.GBCPU.PC.ToString();
            spBox.Text = gameboy.GBCPU.SP.ToString();
        }

        private void dumpRAM_Click(object sender, EventArgs e) {
            messagesText.Text = HelperFunc.ToHex(gameboy.GBMemory.RAM);
        }

    }
}
