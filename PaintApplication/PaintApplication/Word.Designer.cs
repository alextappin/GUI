namespace PaintApplication
{
    partial class Text_Form
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
            this.textBox_TextWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FontSize = new System.Windows.Forms.TextBox();
            this.button_OkAddText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TextWord
            // 
            this.textBox_TextWord.Location = new System.Drawing.Point(77, 28);
            this.textBox_TextWord.Name = "textBox_TextWord";
            this.textBox_TextWord.Size = new System.Drawing.Size(214, 20);
            this.textBox_TextWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Font Size:";
            // 
            // textBox_FontSize
            // 
            this.textBox_FontSize.Location = new System.Drawing.Point(100, 79);
            this.textBox_FontSize.Name = "textBox_FontSize";
            this.textBox_FontSize.Size = new System.Drawing.Size(61, 20);
            this.textBox_FontSize.TabIndex = 3;
            // 
            // button_OkAddText
            // 
            this.button_OkAddText.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OkAddText.Location = new System.Drawing.Point(111, 124);
            this.button_OkAddText.Name = "button_OkAddText";
            this.button_OkAddText.Size = new System.Drawing.Size(75, 23);
            this.button_OkAddText.TabIndex = 4;
            this.button_OkAddText.Text = "Ok";
            this.button_OkAddText.UseVisualStyleBackColor = true;
            // 
            // Text_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 159);
            this.Controls.Add(this.button_OkAddText);
            this.Controls.Add(this.textBox_FontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TextWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Text_Form";
            this.Text = "Add Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_TextWord;
        public System.Windows.Forms.TextBox textBox_FontSize;
        public System.Windows.Forms.Button button_OkAddText;
    }
}