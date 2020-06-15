using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyBum_for_PC
{
    public partial class LazyWindow : Form
    {
        CmdHandler cmdHdler;
        private bool AVRec_On, SkyRec_On, Beamer_On, lDesk_On, lFloor_On;
        private int avVol;

        public LazyWindow()
        {
            InitializeComponent();
                        
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect();
            setNewStates(states);     
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            cmdHdler = new CmdHandler();

            string btn = b.Name;

            string states = cmdHdler.connect(btn);
            setNewStates(states);
        }

        private void setNewStates(string input)
        {            
            char[] delimiterChars = { '\r', '\n' };
            string[] states = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            bool[] statesBool = new bool[states.Length];

            for (int i = 0; i < 5; i++)
            {
                if (states[i].Contains("false")) statesBool[i] = false;
                else statesBool[i] = true;
            }
            try
            {
                avVol = Int32.Parse(states[6]);
                volBar.Value = avVol;
                volText.Text = Convert.ToString((avVol / 2) - 80.5) + " dB";
            }
            catch (Exception e)
            {
            }            

            AVRec_On = statesBool[0];
            SkyRec_On = statesBool[1];
            Beamer_On = statesBool[2];
            lDesk_On = statesBool[3];
            lFloor_On = statesBool[4];

            toolStrip_lDesk.Checked = lDesk_On;
            toolStrip_lFloor.Checked = lFloor_On;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void toolStrip_lDesk_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("lDesk");
            setNewStates(states);
            toolStrip_lDesk.Checked = lDesk_On;
        }

        private void toolStrip_lFloor_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("lFloor");
            setNewStates(states);
            toolStrip_lFloor.Checked = lFloor_On;
        }

        private void toolStrip_lRoom_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("lRoom");
            setNewStates(states);
        }

        private void toolStrip_lDarts_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("lDarts");
            setNewStates(states);
        }

        private void toolStrip_lAll_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string btn = "";

            if (lDesk_On && lFloor_On)
            {
                btn = "lAllOff";
                toolStrip_lDesk.Checked = false;
                toolStrip_lFloor.Checked = false;
            }
            else
            {
                btn = "lAllOn";
                toolStrip_lDesk.Checked = true;
                toolStrip_lFloor.Checked = true;
            }

            string states = cmdHdler.connect(btn);
            setNewStates(states);
        }

        private void toolStrip_Close_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void LazyWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LazyWindow_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
        }        

        private void volBar_MouseUp(object sender, MouseEventArgs e)
        {
            cmdHdler = new CmdHandler();
            TrackBar tb = (TrackBar)sender;
            string volTxt = String.Format("{0:D3}VL", tb.Value);
            
            string states = cmdHdler.connect(volTxt);
            setNewStates(states);
        }

        private void volBar_MouseMove(object sender, MouseEventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            volText.Text = Convert.ToString((tb.Value / 2) - 80.5) + " dB";
        }

        private void memory1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("MC1");
            setNewStates(states);
            memory1ToolStripMenuItem.Checked = true;
            memory2ToolStripMenuItem.Checked = false;
        }

        private void memory2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmdHdler = new CmdHandler();
            string states = cmdHdler.connect("MC2");
            setNewStates(states);
            memory1ToolStripMenuItem.Checked = false;
            memory2ToolStripMenuItem.Checked = true;
        }
    }   
}
