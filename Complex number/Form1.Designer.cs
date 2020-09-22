namespace Complex_number
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.imegineryField2 = new System.Windows.Forms.TextBox();
            this.realField2 = new System.Windows.Forms.TextBox();
            this.imegineryField1 = new System.Windows.Forms.TextBox();
            this.realField1 = new System.Windows.Forms.TextBox();
            this.pictureSN = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.labelAnswer);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.imegineryField2);
            this.panel1.Controls.Add(this.realField2);
            this.panel1.Controls.Add(this.imegineryField1);
            this.panel1.Controls.Add(this.realField1);
            this.panel1.Controls.Add(this.pictureSN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelOut);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 215);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelAnswer
            // 
            this.labelAnswer.Font = new System.Drawing.Font("Georgia", 18F);
            this.labelAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.labelAnswer.Location = new System.Drawing.Point(277, 167);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(160, 37);
            this.labelAnswer.TabIndex = 61;
            this.labelAnswer.Text = "Answer";
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.CloseButton.Location = new System.Drawing.Point(404, 1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 24);
            this.CloseButton.TabIndex = 60;
            this.CloseButton.Text = "Exit";
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown_1);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // imegineryField2
            // 
            this.imegineryField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.imegineryField2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imegineryField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imegineryField2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imegineryField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.imegineryField2.Location = new System.Drawing.Point(277, 117);
            this.imegineryField2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imegineryField2.Multiline = true;
            this.imegineryField2.Name = "imegineryField2";
            this.imegineryField2.Size = new System.Drawing.Size(161, 44);
            this.imegineryField2.TabIndex = 59;
            this.imegineryField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imegineryField2.Enter += new System.EventHandler(this.imegineryField2_Enter);
            this.imegineryField2.Leave += new System.EventHandler(this.imegineryField2_Leave);
            // 
            // realField2
            // 
            this.realField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.realField2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.realField2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.realField2.Location = new System.Drawing.Point(103, 117);
            this.realField2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realField2.Multiline = true;
            this.realField2.Name = "realField2";
            this.realField2.Size = new System.Drawing.Size(161, 44);
            this.realField2.TabIndex = 58;
            this.realField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.realField2.Enter += new System.EventHandler(this.realField2_Enter);
            this.realField2.Leave += new System.EventHandler(this.realField2_Leave);
            // 
            // imegineryField1
            // 
            this.imegineryField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.imegineryField1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imegineryField1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imegineryField1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imegineryField1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.imegineryField1.Location = new System.Drawing.Point(277, 26);
            this.imegineryField1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imegineryField1.Multiline = true;
            this.imegineryField1.Name = "imegineryField1";
            this.imegineryField1.Size = new System.Drawing.Size(161, 44);
            this.imegineryField1.TabIndex = 57;
            this.imegineryField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imegineryField1.Enter += new System.EventHandler(this.imegineryField1_Enter);
            this.imegineryField1.Leave += new System.EventHandler(this.imegineryField1_Leave);
            // 
            // realField1
            // 
            this.realField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.realField1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realField1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.realField1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realField1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.realField1.Location = new System.Drawing.Point(103, 26);
            this.realField1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realField1.Multiline = true;
            this.realField1.Name = "realField1";
            this.realField1.Size = new System.Drawing.Size(161, 44);
            this.realField1.TabIndex = 56;
            this.realField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.realField1.Enter += new System.EventHandler(this.realField1_Enter);
            this.realField1.Leave += new System.EventHandler(this.realField1_Leave);
            // 
            // pictureSN
            // 
            this.pictureSN.Image = global::Complex_number.Properties.Resources.Second_number;
            this.pictureSN.Location = new System.Drawing.Point(12, 97);
            this.pictureSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSN.Name = "pictureSN";
            this.pictureSN.Size = new System.Drawing.Size(85, 79);
            this.pictureSN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSN.TabIndex = 55;
            this.pictureSN.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Complex_number.Properties.Resources.First_number;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // labelOut
            // 
            this.labelOut.AutoEllipsis = true;
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut.Location = new System.Drawing.Point(341, 126);
            this.labelOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 25);
            this.labelOut.TabIndex = 53;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.buttonStart.Location = new System.Drawing.Point(103, 167);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(161, 39);
            this.buttonStart.TabIndex = 52;
            this.buttonStart.Text = "Посчитать";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(227)))));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "            +",
            "            -",
            "            *",
            "          abs",
            "          arg"});
            this.comboBox.Location = new System.Drawing.Point(213, 82);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(113, 26);
            this.comboBox.TabIndex = 51;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imegineryField2;
        private System.Windows.Forms.TextBox realField2;
        private System.Windows.Forms.TextBox imegineryField1;
        private System.Windows.Forms.TextBox realField1;
        private System.Windows.Forms.PictureBox pictureSN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label labelAnswer;
    }
}

