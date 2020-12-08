namespace Bykov
{
    partial class Bykov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bykov));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.textGame15 = new System.Windows.Forms.TextBox();
            this.tabSoft = new System.Windows.Forms.TabPage();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.pictureGame15 = new System.Windows.Forms.PictureBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureAbout = new System.Windows.Forms.PictureBox();
            this.tabOneProgram = new System.Windows.Forms.TabPage();
            this.textBox12Mouth = new System.Windows.Forms.TextBox();
            this.picture12Mouth = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabGames.SuspendLayout();
            this.tabSoft.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbout)).BeginInit();
            this.tabOneProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture12Mouth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOneProgram);
            this.tabControl.Controls.Add(this.tabGames);
            this.tabControl.Controls.Add(this.tabSoft);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(691, 503);
            this.tabControl.TabIndex = 0;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.textGame15);
            this.tabGames.Controls.Add(this.pictureGame15);
            this.tabGames.Location = new System.Drawing.Point(4, 25);
            this.tabGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGames.Size = new System.Drawing.Size(683, 474);
            this.tabGames.TabIndex = 0;
            this.tabGames.Text = "Игровые программы";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // textGame15
            // 
            this.textGame15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGame15.Location = new System.Drawing.Point(256, 9);
            this.textGame15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textGame15.Multiline = true;
            this.textGame15.Name = "textGame15";
            this.textGame15.ReadOnly = true;
            this.textGame15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGame15.Size = new System.Drawing.Size(408, 125);
            this.textGame15.TabIndex = 1;
            this.textGame15.Text = "Игра пятнашки очень популярная игра, в которой надо собрть цифры по порядку в вид" +
    "е пазла\r\n";
            // 
            // tabSoft
            // 
            this.tabSoft.Controls.Add(this.textPassword);
            this.tabSoft.Controls.Add(this.picturePassword);
            this.tabSoft.Location = new System.Drawing.Point(4, 25);
            this.tabSoft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSoft.Name = "tabSoft";
            this.tabSoft.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSoft.Size = new System.Drawing.Size(683, 474);
            this.tabSoft.TabIndex = 1;
            this.tabSoft.Text = "Прикладные программы";
            this.tabSoft.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPassword.Location = new System.Drawing.Point(253, 9);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPassword.Size = new System.Drawing.Size(408, 125);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "Программа Менеджер паролей, предназначен для хранения логинов и паролей в буфере " +
    "обмена";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.textAbout);
            this.tabAbout.Controls.Add(this.pictureAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 25);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Size = new System.Drawing.Size(683, 474);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "Об авторе";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // textAbout
            // 
            this.textAbout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAbout.Location = new System.Drawing.Point(203, 6);
            this.textAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.ReadOnly = true;
            this.textAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAbout.Size = new System.Drawing.Size(465, 363);
            this.textAbout.TabIndex = 5;
            this.textAbout.Text = resources.GetString("textAbout.Text");
            // 
            // pictureGame15
            // 
            this.pictureGame15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGame15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureGame15.Image = global::Bykov.Properties.Resources.Game15;
            this.pictureGame15.Location = new System.Drawing.Point(11, 7);
            this.pictureGame15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureGame15.Name = "pictureGame15";
            this.pictureGame15.Size = new System.Drawing.Size(229, 128);
            this.pictureGame15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGame15.TabIndex = 0;
            this.pictureGame15.TabStop = false;
            this.pictureGame15.Click += new System.EventHandler(this.pictureGame15_Click);
            // 
            // picturePassword
            // 
            this.picturePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePassword.Image = global::Bykov.Properties.Resources._2017_09_13_13_58_35;
            this.picturePassword.Location = new System.Drawing.Point(8, 7);
            this.picturePassword.Margin = new System.Windows.Forms.Padding(4);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(229, 128);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePassword.TabIndex = 2;
            this.picturePassword.TabStop = false;
            this.picturePassword.Click += new System.EventHandler(this.picturePassword_Click);
            // 
            // pictureAbout
            // 
            this.pictureAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAbout.Image = global::Bykov.Properties.Resources.IMAG0287;
            this.pictureAbout.Location = new System.Drawing.Point(15, 6);
            this.pictureAbout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureAbout.Name = "pictureAbout";
            this.pictureAbout.Size = new System.Drawing.Size(179, 272);
            this.pictureAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAbout.TabIndex = 4;
            this.pictureAbout.TabStop = false;
            this.pictureAbout.Click += new System.EventHandler(this.pictureAbout_Click);
            // 
            // tabOneProgram
            // 
            this.tabOneProgram.Controls.Add(this.textBox12Mouth);
            this.tabOneProgram.Controls.Add(this.picture12Mouth);
            this.tabOneProgram.Location = new System.Drawing.Point(4, 25);
            this.tabOneProgram.Name = "tabOneProgram";
            this.tabOneProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabOneProgram.Size = new System.Drawing.Size(683, 474);
            this.tabOneProgram.TabIndex = 3;
            this.tabOneProgram.Text = "Первые программы";
            this.tabOneProgram.UseVisualStyleBackColor = true;
            // 
            // textBox12Mouth
            // 
            this.textBox12Mouth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12Mouth.Location = new System.Drawing.Point(249, 10);
            this.textBox12Mouth.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12Mouth.Multiline = true;
            this.textBox12Mouth.Name = "textBox12Mouth";
            this.textBox12Mouth.ReadOnly = true;
            this.textBox12Mouth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox12Mouth.Size = new System.Drawing.Size(408, 125);
            this.textBox12Mouth.TabIndex = 5;
            this.textBox12Mouth.Text = "Программа 12 месяцев показывает календарь с месяцами. При переключении меняются и" +
    " картинки данной программы";
            // 
            // picture12Mouth
            // 
            this.picture12Mouth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture12Mouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture12Mouth.Image = global::Bykov.Properties.Resources._12_месяцев;
            this.picture12Mouth.Location = new System.Drawing.Point(4, 7);
            this.picture12Mouth.Margin = new System.Windows.Forms.Padding(4);
            this.picture12Mouth.Name = "picture12Mouth";
            this.picture12Mouth.Size = new System.Drawing.Size(229, 128);
            this.picture12Mouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture12Mouth.TabIndex = 4;
            this.picture12Mouth.TabStop = false;
            this.picture12Mouth.Click += new System.EventHandler(this.picture12Mouth_Click);
            // 
            // Bykov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 503);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bykov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Владимир Быков - Мои программы";
            this.tabControl.ResumeLayout(false);
            this.tabGames.ResumeLayout(false);
            this.tabGames.PerformLayout();
            this.tabSoft.ResumeLayout(false);
            this.tabSoft.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAbout)).EndInit();
            this.tabOneProgram.ResumeLayout(false);
            this.tabOneProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture12Mouth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.TabPage tabSoft;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TextBox textGame15;
        private System.Windows.Forms.PictureBox pictureGame15;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.TextBox textAbout;
        private System.Windows.Forms.PictureBox pictureAbout;
        private System.Windows.Forms.TabPage tabOneProgram;
        private System.Windows.Forms.TextBox textBox12Mouth;
        private System.Windows.Forms.PictureBox picture12Mouth;
    }
}

