namespace SQLBuilder
{
    partial class SQLMainWindow
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
            this.button2 = new System.Windows.Forms.Button();
            this.QueryBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._ConnectionError = new System.Windows.Forms.TextBox();
            this._ConnectionVar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this._UseMD5 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(396, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate SQL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(10, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clear SQL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QueryBox
            // 
            this.QueryBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.QueryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryBox.Font = new System.Drawing.Font("Arial", 10F);
            this.QueryBox.ForeColor = System.Drawing.Color.Tan;
            this.QueryBox.Location = new System.Drawing.Point(14, 201);
            this.QueryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(745, 260);
            this.QueryBox.TabIndex = 1;
            this.QueryBox.Text = "Generate Your DB Connection.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SQL Host";
            // 
            // hostTextBox
            // 
            this.hostTextBox.BackColor = System.Drawing.Color.Black;
            this.hostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hostTextBox.Location = new System.Drawing.Point(104, 23);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(138, 20);
            this.hostTextBox.TabIndex = 3;
            this.hostTextBox.Text = "e.g. example.com";
            this.hostTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._UseMD5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.passTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.userTextbox);
            this.groupBox1.Controls.Add(this.dbTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._ConnectionError);
            this.groupBox1.Controls.Add(this._ConnectionVar);
            this.groupBox1.Controls.Add(this.hostTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(636, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Parameters";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(223, 133);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "App Info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passTextbox
            // 
            this.passTextbox.BackColor = System.Drawing.Color.Black;
            this.passTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passTextbox.Location = new System.Drawing.Point(367, 90);
            this.passTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '*';
            this.passTextbox.Size = new System.Drawing.Size(159, 20);
            this.passTextbox.TabIndex = 3;
            this.passTextbox.Text = "e.g. dbpass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL Password";
            // 
            // dbTextbox
            // 
            this.dbTextbox.BackColor = System.Drawing.Color.Black;
            this.dbTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbTextbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dbTextbox.Location = new System.Drawing.Point(104, 55);
            this.dbTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbTextbox.Name = "dbTextbox";
            this.dbTextbox.Size = new System.Drawing.Size(138, 20);
            this.dbTextbox.TabIndex = 3;
            this.dbTextbox.Text = "e.g. db";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SQL Database";
            // 
            // _ConnectionError
            // 
            this._ConnectionError.BackColor = System.Drawing.Color.Black;
            this._ConnectionError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ConnectionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ConnectionError.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._ConnectionError.Location = new System.Drawing.Point(367, 57);
            this._ConnectionError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._ConnectionError.Name = "_ConnectionError";
            this._ConnectionError.Size = new System.Drawing.Size(159, 20);
            this._ConnectionError.TabIndex = 3;
            this._ConnectionError.Text = "Connection Failed:";
            // 
            // _ConnectionVar
            // 
            this._ConnectionVar.BackColor = System.Drawing.Color.Black;
            this._ConnectionVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ConnectionVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ConnectionVar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._ConnectionVar.Location = new System.Drawing.Point(367, 23);
            this._ConnectionVar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._ConnectionVar.Name = "_ConnectionVar";
            this._ConnectionVar.Size = new System.Drawing.Size(159, 20);
            this._ConnectionVar.TabIndex = 3;
            this._ConnectionVar.Text = "ConnectionVariable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Error Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Connection Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLBuilder.Properties.Resources.icon_sql_48;
            this.pictureBox1.Location = new System.Drawing.Point(661, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "SQL User";
            // 
            // userTextbox
            // 
            this.userTextbox.BackColor = System.Drawing.Color.Black;
            this.userTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userTextbox.Location = new System.Drawing.Point(104, 89);
            this.userTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(138, 20);
            this.userTextbox.TabIndex = 3;
            this.userTextbox.Text = "e.g. dbuser";
            // 
            // _UseMD5
            // 
            this._UseMD5.AutoSize = true;
            this._UseMD5.Location = new System.Drawing.Point(533, 92);
            this._UseMD5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._UseMD5.Name = "_UseMD5";
            this._UseMD5.Size = new System.Drawing.Size(92, 20);
            this._UseMD5.TabIndex = 7;
            this._UseMD5.Text = "Use MD5?";
            this._UseMD5.UseVisualStyleBackColor = true;
            // 
            // SQLMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QueryBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SQLMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Connection Generator | Droitech Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox QueryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox _ConnectionError;
        private System.Windows.Forms.TextBox _ConnectionVar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox _UseMD5;
    }
}

