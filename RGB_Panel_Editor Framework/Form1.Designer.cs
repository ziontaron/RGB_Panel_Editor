
namespace RGB_Panel_Editor_Framework
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this._tc_RGB_Panel_Tabs = new System.Windows.Forms.TabControl();
      this._tp_RGB_Panel_Editor_SerialCom = new System.Windows.Forms.TabPage();
      this._b_Check_Ports = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this._rtb_Serial_Log = new System.Windows.Forms.RichTextBox();
      this._cb_OpenSerialPorts = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this._tc_RGB_Panel_Tabs.SuspendLayout();
      this._tp_RGB_Panel_Editor_SerialCom.SuspendLayout();
      this.SuspendLayout();
      // 
      // _tc_RGB_Panel_Tabs
      // 
      this._tc_RGB_Panel_Tabs.Controls.Add(this._tp_RGB_Panel_Editor_SerialCom);
      this._tc_RGB_Panel_Tabs.Controls.Add(this.tabPage2);
      this._tc_RGB_Panel_Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tc_RGB_Panel_Tabs.Location = new System.Drawing.Point(0, 0);
      this._tc_RGB_Panel_Tabs.Name = "_tc_RGB_Panel_Tabs";
      this._tc_RGB_Panel_Tabs.SelectedIndex = 0;
      this._tc_RGB_Panel_Tabs.Size = new System.Drawing.Size(893, 620);
      this._tc_RGB_Panel_Tabs.TabIndex = 0;
      // 
      // _tp_RGB_Panel_Editor_SerialCom
      // 
      this._tp_RGB_Panel_Editor_SerialCom.Controls.Add(this.label1);
      this._tp_RGB_Panel_Editor_SerialCom.Controls.Add(this._cb_OpenSerialPorts);
      this._tp_RGB_Panel_Editor_SerialCom.Controls.Add(this._rtb_Serial_Log);
      this._tp_RGB_Panel_Editor_SerialCom.Controls.Add(this._b_Check_Ports);
      this._tp_RGB_Panel_Editor_SerialCom.Location = new System.Drawing.Point(4, 25);
      this._tp_RGB_Panel_Editor_SerialCom.Name = "_tp_RGB_Panel_Editor_SerialCom";
      this._tp_RGB_Panel_Editor_SerialCom.Padding = new System.Windows.Forms.Padding(3);
      this._tp_RGB_Panel_Editor_SerialCom.Size = new System.Drawing.Size(885, 591);
      this._tp_RGB_Panel_Editor_SerialCom.TabIndex = 0;
      this._tp_RGB_Panel_Editor_SerialCom.Text = "Serial Com";
      this._tp_RGB_Panel_Editor_SerialCom.UseVisualStyleBackColor = true;
      // 
      // _b_Check_Ports
      // 
      this._b_Check_Ports.Location = new System.Drawing.Point(19, 17);
      this._b_Check_Ports.Name = "_b_Check_Ports";
      this._b_Check_Ports.Size = new System.Drawing.Size(155, 38);
      this._b_Check_Ports.TabIndex = 0;
      this._b_Check_Ports.Text = "Check Open Ports";
      this._b_Check_Ports.UseVisualStyleBackColor = true;
      this._b_Check_Ports.Click += new System.EventHandler(this._b_Check_Ports_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(885, 591);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // _rtb_Serial_Log
      // 
      this._rtb_Serial_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._rtb_Serial_Log.Location = new System.Drawing.Point(8, 327);
      this._rtb_Serial_Log.Name = "_rtb_Serial_Log";
      this._rtb_Serial_Log.Size = new System.Drawing.Size(869, 256);
      this._rtb_Serial_Log.TabIndex = 1;
      this._rtb_Serial_Log.Text = "";
      // 
      // _cb_OpenSerialPorts
      // 
      this._cb_OpenSerialPorts.FormattingEnabled = true;
      this._cb_OpenSerialPorts.Location = new System.Drawing.Point(666, 25);
      this._cb_OpenSerialPorts.Name = "_cb_OpenSerialPorts";
      this._cb_OpenSerialPorts.Size = new System.Drawing.Size(185, 24);
      this._cb_OpenSerialPorts.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(570, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Open Ports";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(893, 620);
      this.Controls.Add(this._tc_RGB_Panel_Tabs);
      this.Name = "Form1";
      this.Text = "RGB Panel Editor";
      this._tc_RGB_Panel_Tabs.ResumeLayout(false);
      this._tp_RGB_Panel_Editor_SerialCom.ResumeLayout(false);
      this._tp_RGB_Panel_Editor_SerialCom.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl _tc_RGB_Panel_Tabs;
    private System.Windows.Forms.TabPage _tp_RGB_Panel_Editor_SerialCom;
    private System.Windows.Forms.Button _b_Check_Ports;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.RichTextBox _rtb_Serial_Log;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox _cb_OpenSerialPorts;
  }
}

