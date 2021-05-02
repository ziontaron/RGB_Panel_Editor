using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Panel_Editor_Framework
{
  public partial class Form1 : Form
  {

    static bool _continue;
    static SerialPort _serialPort;
    public Form1()
    {
      InitializeComponent();
    }

    private void _b_Check_Ports_Click(object sender, EventArgs e)
    {
      _cb_OpenSerialPorts.Items.Clear();
      foreach (string s in SerialPort.GetPortNames())
      {
        _cb_OpenSerialPorts.Items.Add(s);
        _rtb_Serial_Log.AppendText(s);
      }
      _rtb_Serial_Log.ScrollToCaret();
    }
  }
}
