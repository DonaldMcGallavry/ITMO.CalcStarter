using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem EngineerModeMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem StandardModeMenuItem;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//

			//VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
            Application.Exit();
        }

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineerModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandardModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(200, 120);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(8, 168);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(104, 120);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(56, 120);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(200, 216);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(56, 168);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(8, 216);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(104, 168);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(152, 216);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(200, 168);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(104, 216);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(8, 72);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(56, 216);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(104, 72);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(8, 40);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(248, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutputDisplay.TextChanged += new System.EventHandler(this.OutputDisplay_TextChanged);
            this.OutputDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputDisplay_KeyPress);
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(152, 168);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(56, 72);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(152, 120);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(8, 120);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(200, 72);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(152, 72);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem,
            this.EngineerModeMenuItem,
            this.StandardModeMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // EngineerModeMenuItem
            // 
            this.EngineerModeMenuItem.Name = "EngineerModeMenuItem";
            this.EngineerModeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EngineerModeMenuItem.Text = "Engineer";
            this.EngineerModeMenuItem.Click += new System.EventHandler(this.EngineerModeMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click_1);
            // 
            // StandardModeMenuItem
            // 
            this.StandardModeMenuItem.Name = "StandardModeMenuItem";
            this.StandardModeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StandardModeMenuItem.Text = "Standard";
            this.StandardModeMenuItem.Click += new System.EventHandler(this.StandardModeMenuItem_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(264, 262);
            this.MaximizeBox = false;
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CalcUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSqrt);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eInverse);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSquare);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        private void CalcUI_Load(object sender, EventArgs e)
        {

        }

        private void OutputDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      

       

        private void ExitMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EngineerModeMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EngeneerForm engineerForm = new EngeneerForm();
            engineerForm.Show();
            
             
        }


private void StandardModeMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
