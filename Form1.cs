// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.Form1
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Eight_Puzzle
{
  public class Form1 : Form
  {
    private IContainer components;
    private TextBox tb00;
    private TextBox tb10;
    private TextBox tb20;
    private TextBox tb21;
    private TextBox tb11;
    private TextBox tb01;
    private TextBox tb22;
    private TextBox tb12;
    private TextBox tb02;
    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button button2;
    private Label label5;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private RadioButton radioButton5;
    private Label label6;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
    private Label label7;
    private Label label8;
    private Thread myThread;
    private node pathcurrent;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.tb00 = new TextBox();
      this.tb10 = new TextBox();
      this.tb20 = new TextBox();
      this.tb21 = new TextBox();
      this.tb11 = new TextBox();
      this.tb01 = new TextBox();
      this.tb22 = new TextBox();
      this.tb12 = new TextBox();
      this.tb02 = new TextBox();
      this.button1 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.button2 = new Button();
      this.label5 = new Label();
      this.radioButton1 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.radioButton4 = new RadioButton();
      this.radioButton5 = new RadioButton();
      this.label6 = new Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.label7 = new Label();
      this.label8 = new Label();
      this.SuspendLayout();
      this.tb00.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb00.Location = new Point(186, 12);
      this.tb00.Multiline = true;
      this.tb00.Name = "tb00";
      this.tb00.Size = new Size(50, 50);
      this.tb00.TabIndex = 0;
      this.tb00.Text = " ";
      this.tb00.TextAlign = HorizontalAlignment.Center;
      this.tb10.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb10.Location = new Point(236, 12);
      this.tb10.Margin = new Padding(0);
      this.tb10.Multiline = true;
      this.tb10.Name = "tb10";
      this.tb10.Size = new Size(50, 50);
      this.tb10.TabIndex = 1;
      this.tb10.Text = "8";
      this.tb10.TextAlign = HorizontalAlignment.Center;
      this.tb20.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb20.Location = new Point(286, 12);
      this.tb20.Multiline = true;
      this.tb20.Name = "tb20";
      this.tb20.Size = new Size(50, 50);
      this.tb20.TabIndex = 2;
      this.tb20.Text = "7";
      this.tb20.TextAlign = HorizontalAlignment.Center;
      this.tb21.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb21.Location = new Point(286, 62);
      this.tb21.Multiline = true;
      this.tb21.Name = "tb21";
      this.tb21.Size = new Size(50, 50);
      this.tb21.TabIndex = 5;
      this.tb21.Text = "4";
      this.tb21.TextAlign = HorizontalAlignment.Center;
      this.tb11.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb11.Location = new Point(236, 62);
      this.tb11.Margin = new Padding(0);
      this.tb11.Multiline = true;
      this.tb11.Name = "tb11";
      this.tb11.Size = new Size(50, 50);
      this.tb11.TabIndex = 4;
      this.tb11.Text = "5";
      this.tb11.TextAlign = HorizontalAlignment.Center;
      this.tb01.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb01.Location = new Point(186, 62);
      this.tb01.Multiline = true;
      this.tb01.Name = "tb01";
      this.tb01.Size = new Size(50, 50);
      this.tb01.TabIndex = 3;
      this.tb01.Text = "6";
      this.tb01.TextAlign = HorizontalAlignment.Center;
      this.tb22.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb22.Location = new Point(286, 112);
      this.tb22.Multiline = true;
      this.tb22.Name = "tb22";
      this.tb22.Size = new Size(50, 50);
      this.tb22.TabIndex = 8;
      this.tb22.Text = "1";
      this.tb22.TextAlign = HorizontalAlignment.Center;
      this.tb12.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb12.Location = new Point(236, 112);
      this.tb12.Margin = new Padding(0);
      this.tb12.Multiline = true;
      this.tb12.Name = "tb12";
      this.tb12.Size = new Size(50, 50);
      this.tb12.TabIndex = 7;
      this.tb12.Text = "2";
      this.tb12.TextAlign = HorizontalAlignment.Center;
      this.tb02.Font = new Font("Tahoma", 26.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.tb02.Location = new Point(186, 112);
      this.tb02.Multiline = true;
      this.tb02.Name = "tb02";
      this.tb02.Size = new Size(50, 50);
      this.tb02.TabIndex = 6;
      this.tb02.Text = "3";
      this.tb02.TextAlign = HorizontalAlignment.Center;
      this.button1.Location = new Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new Size(150, 37);
      this.button1.TabIndex = 9;
      this.button1.Text = "Calculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.Location = new Point(111, 62);
      this.label1.Name = "label1";
      this.label1.Size = new Size(51, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "0";
      this.label1.TextAlign = ContentAlignment.TopRight;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 62);
      this.label2.Name = "label2";
      this.label2.Size = new Size(92, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Nodes calculated:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 109);
      this.label3.Name = "label3";
      this.label3.Size = new Size(72, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Path Length :";
      this.label4.Location = new Point(89, 109);
      this.label4.Name = "label4";
      this.label4.Size = new Size(73, 18);
      this.label4.TabIndex = 13;
      this.label4.Text = "0";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.button2.Enabled = false;
      this.button2.Location = new Point(12, 130);
      this.button2.Name = "button2";
      this.button2.Size = new Size(150, 32);
      this.button2.TabIndex = 14;
      this.button2.Text = "Show Path";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label5.Location = new Point(51, 96);
      this.label5.Name = "label5";
      this.label5.Size = new Size(111, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "0";
      this.label5.TextAlign = ContentAlignment.TopRight;
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new Point(12, 178);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(196, 17);
      this.radioButton1.TabIndex = 16;
      this.radioButton1.Text = "Breadth first search algorithm (BFS)";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(12, 201);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(259, 17);
      this.radioButton2.TabIndex = 17;
      this.radioButton2.Text = "Bidirectional search algorithm (BDS) -- (both BFS)";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new Point(12, 224);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(198, 17);
      this.radioButton3.TabIndex = 18;
      this.radioButton3.Text = "Uniform cost search algorithm (UCS)";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new Point(12, 247);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(142, 17);
      this.radioButton4.TabIndex = 19;
      this.radioButton4.Text = "Greedy search algorithm";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton5.AutoSize = true;
      this.radioButton5.Checked = true;
      this.radioButton5.Location = new Point(12, 270);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new Size(85, 17);
      this.radioButton5.TabIndex = 20;
      this.radioButton5.TabStop = true;
      this.radioButton5.Text = "A* algorithm";
      this.radioButton5.UseVisualStyleBackColor = true;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(12, 96);
      this.label6.Name = "label6";
      this.label6.Size = new Size(33, 13);
      this.label6.TabIndex = 21;
      this.label6.Text = "Time:";
      this.timer1.Interval = 10;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.timer2.Interval = 200;
      this.timer2.Tick += new EventHandler(this.timer2_Tick);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(12, 75);
      this.label7.Name = "label7";
      this.label7.Size = new Size(53, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Progress:";
      this.label8.Location = new Point(111, 75);
      this.label8.Name = "label8";
      this.label8.Size = new Size(51, 13);
      this.label8.TabIndex = 23;
      this.label8.Text = "0%";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(360, 298);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.radioButton5);
      this.Controls.Add((Control) this.radioButton4);
      this.Controls.Add((Control) this.radioButton3);
      this.Controls.Add((Control) this.radioButton2);
      this.Controls.Add((Control) this.radioButton1);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.tb22);
      this.Controls.Add((Control) this.tb12);
      this.Controls.Add((Control) this.tb02);
      this.Controls.Add((Control) this.tb21);
      this.Controls.Add((Control) this.tb11);
      this.Controls.Add((Control) this.tb01);
      this.Controls.Add((Control) this.tb20);
      this.Controls.Add((Control) this.tb10);
      this.Controls.Add((Control) this.tb00);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 178);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "8 Puzzle - By Matin Lotfali";
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form1()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!Agent.working)
      {
        Agent.firstState = this.GetState();
        this.timer1.Enabled = true;
        Agent.working = true;
        this.button2.Enabled = false;
        this.button1.Text = "Cancel";
        if (this.radioButton1.Checked)
          this.myThread = new Thread(new ThreadStart(Agent.BFS));
        else if (this.radioButton3.Checked)
          this.myThread = new Thread(new ThreadStart(Agent.UCS));
        else if (this.radioButton4.Checked)
          this.myThread = new Thread(new ThreadStart(Agent.Greedy));
        else if (this.radioButton5.Checked)
          this.myThread = new Thread(new ThreadStart(Agent.Astar));
        this.myThread.Start();
      }
      else
      {
        this.myThread.Abort();
        Agent.working = false;
      }
    }

    private State GetState()
    {
      State state = new State();
      state.data = new char[3, 3];
      state.data[0, 0] = this.tb00.Text[0];
      state.data[0, 1] = this.tb01.Text[0];
      state.data[0, 2] = this.tb02.Text[0];
      state.data[1, 0] = this.tb10.Text[0];
      state.data[1, 1] = this.tb11.Text[0];
      state.data[1, 2] = this.tb12.Text[0];
      state.data[2, 0] = this.tb20.Text[0];
      state.data[2, 1] = this.tb21.Text[0];
      state.data[2, 2] = this.tb22.Text[0];
      return state;
    }

    private void ShowState(char[,] state)
    {
      if (state == null)
        return;
      this.tb00.Text = state[0, 0].ToString();
      this.tb01.Text = state[0, 1].ToString();
      this.tb02.Text = state[0, 2].ToString();
      this.tb10.Text = state[1, 0].ToString();
      this.tb11.Text = state[1, 1].ToString();
      this.tb12.Text = state[1, 2].ToString();
      this.tb20.Text = state[2, 0].ToString();
      this.tb21.Text = state[2, 1].ToString();
      this.tb22.Text = state[2, 2].ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.pathcurrent = Agent.path.first;
      this.timer2.Enabled = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.label5.Text = (DateTime.Now - Agent.time).ToString();
      this.label1.Text = Agent.counted.ToString();
      this.label8.Text = (Agent.counted * 100L / 362880L).ToString() + "%";
      this.ShowState(Agent.CReport);
      this.label4.Text = Agent.pathlength.ToString();
      if (Agent.working)
        return;
      this.button1.Text = "Calculate";
      this.timer1.Enabled = false;
      if (Agent.path != null)
        this.button2.Enabled = true;
      this.ShowState(Agent.firstState.data);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      if (this.pathcurrent != null)
      {
        this.ShowState(this.pathcurrent.state.data);
        this.pathcurrent = this.pathcurrent.next;
      }
      else
        this.timer2.Enabled = false;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (this.myThread == null)
        return;
      this.myThread.Abort();
    }
  }
}
