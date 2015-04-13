namespace CalculatorAssignment
{
    partial class TappinCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.MSButton = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.plusOrMinus = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.ReciprocalsButton = new System.Windows.Forms.Button();
            this.ClearEverythingButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitGroupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParenthButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearMemory);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(56, 221);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(38, 34);
            this.number0.TabIndex = 1;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number_Click);
            this.number0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(56, 181);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(38, 34);
            this.number1.TabIndex = 2;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number_Click);
            this.number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // MPlusButton
            // 
            this.MPlusButton.Location = new System.Drawing.Point(3, 221);
            this.MPlusButton.Name = "MPlusButton";
            this.MPlusButton.Size = new System.Drawing.Size(38, 34);
            this.MPlusButton.TabIndex = 3;
            this.MPlusButton.Text = "M+";
            this.MPlusButton.UseVisualStyleBackColor = true;
            this.MPlusButton.Click += new System.EventHandler(this.memoryPlus);
            // 
            // MSButton
            // 
            this.MSButton.Location = new System.Drawing.Point(3, 181);
            this.MSButton.Name = "MSButton";
            this.MSButton.Size = new System.Drawing.Size(38, 34);
            this.MSButton.TabIndex = 4;
            this.MSButton.Text = "MS";
            this.MSButton.UseVisualStyleBackColor = true;
            this.MSButton.Click += new System.EventHandler(this.storeExpression);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(100, 141);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(38, 34);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number_Click);
            this.number5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(56, 141);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(38, 34);
            this.number4.TabIndex = 6;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number_Click);
            this.number4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // MRButton
            // 
            this.MRButton.Location = new System.Drawing.Point(3, 141);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(38, 34);
            this.MRButton.TabIndex = 7;
            this.MRButton.Text = "MR";
            this.MRButton.UseVisualStyleBackColor = true;
            this.MRButton.Click += new System.EventHandler(this.retrieveMemory);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(144, 141);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(38, 34);
            this.number6.TabIndex = 8;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number_Click);
            this.number6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(144, 101);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(38, 34);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number_Click);
            this.number9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(100, 101);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(38, 34);
            this.number8.TabIndex = 10;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number_Click);
            this.number8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(56, 101);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(38, 34);
            this.number7.TabIndex = 11;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number_Click);
            this.number7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(100, 181);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(38, 34);
            this.number2.TabIndex = 12;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number_Click);
            this.number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(144, 181);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(38, 34);
            this.number3.TabIndex = 13;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number_Click);
            this.number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.number3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.Location = new System.Drawing.Point(100, 221);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(38, 34);
            this.plusOrMinus.TabIndex = 14;
            this.plusOrMinus.Text = "+/-";
            this.plusOrMinus.UseVisualStyleBackColor = true;
            this.plusOrMinus.Click += new System.EventHandler(this.plusOrMinus_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Location = new System.Drawing.Point(144, 221);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(38, 34);
            this.decimalButton.TabIndex = 15;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.number_Click);
            this.decimalButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.decimalButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(234, 221);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(38, 34);
            this.EqualsButton.TabIndex = 16;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.equalClick);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(190, 221);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(38, 34);
            this.PlusButton.TabIndex = 17;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.number_Click);
            this.PlusButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.PlusButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(190, 181);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(38, 34);
            this.MinusButton.TabIndex = 18;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.number_Click);
            this.MinusButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.MinusButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(190, 141);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(38, 34);
            this.MultiplyButton.TabIndex = 19;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.number_Click);
            this.MultiplyButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.MultiplyButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(190, 101);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(38, 34);
            this.divideButton.TabIndex = 20;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.number_Click);
            this.divideButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboardPressText);
            this.divideButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardPressNum);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Location = new System.Drawing.Point(234, 101);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(38, 34);
            this.SquareRootButton.TabIndex = 21;
            this.SquareRootButton.Text = "sqrt";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.sqrtButton);
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.Location = new System.Drawing.Point(207, 61);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(65, 34);
            this.ClearScreenButton.TabIndex = 22;
            this.ClearScreenButton.Text = "C";
            this.ClearScreenButton.UseVisualStyleBackColor = true;
            this.ClearScreenButton.Click += new System.EventHandler(this.clearClick);
            // 
            // ReciprocalsButton
            // 
            this.ReciprocalsButton.Location = new System.Drawing.Point(234, 181);
            this.ReciprocalsButton.Name = "ReciprocalsButton";
            this.ReciprocalsButton.Size = new System.Drawing.Size(38, 34);
            this.ReciprocalsButton.TabIndex = 24;
            this.ReciprocalsButton.Text = "1/x";
            this.ReciprocalsButton.UseVisualStyleBackColor = true;
            this.ReciprocalsButton.Click += new System.EventHandler(this.inverseClick);
            // 
            // ClearEverythingButton
            // 
            this.ClearEverythingButton.Location = new System.Drawing.Point(135, 61);
            this.ClearEverythingButton.Name = "ClearEverythingButton";
            this.ClearEverythingButton.Size = new System.Drawing.Size(66, 34);
            this.ClearEverythingButton.TabIndex = 26;
            this.ClearEverythingButton.Text = "CE";
            this.ClearEverythingButton.UseVisualStyleBackColor = true;
            this.ClearEverythingButton.Click += new System.EventHandler(this.clearEverythingClick);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Location = new System.Drawing.Point(56, 61);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(73, 34);
            this.BackspaceButton.TabIndex = 27;
            this.BackspaceButton.Text = "Backspace";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.backspaceClick);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(3, 35);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(269, 20);
            this.textResult.TabIndex = 28;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.digitGroupingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // digitGroupingToolStripMenuItem
            // 
            this.digitGroupingToolStripMenuItem.Name = "digitGroupingToolStripMenuItem";
            this.digitGroupingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.digitGroupingToolStripMenuItem.Text = "DigitGrouping";
            this.digitGroupingToolStripMenuItem.Click += new System.EventHandler(this.digitGroupingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ParenthButton
            // 
            this.ParenthButton.Location = new System.Drawing.Point(234, 141);
            this.ParenthButton.Name = "ParenthButton";
            this.ParenthButton.Size = new System.Drawing.Size(16, 34);
            this.ParenthButton.TabIndex = 30;
            this.ParenthButton.Text = "(";
            this.ParenthButton.UseVisualStyleBackColor = true;
            this.ParenthButton.Click += new System.EventHandler(this.number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 34);
            this.button3.TabIndex = 31;
            this.button3.Text = ")";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.number_Click);
            // 
            // TappinCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ParenthButton);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ClearEverythingButton);
            this.Controls.Add(this.ReciprocalsButton);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.plusOrMinus);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.MRButton);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.MSButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TappinCalculator";
            this.Text = "TappinCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button MSButton;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button plusOrMinus;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.Windows.Forms.Button ReciprocalsButton;
        private System.Windows.Forms.Button ClearEverythingButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitGroupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ParenthButton;
        private System.Windows.Forms.Button button3;
    }
}

