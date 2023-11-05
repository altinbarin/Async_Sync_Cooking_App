namespace CookingApp_Await_async
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAsync = new Button();
            btnStartCookingSync = new Button();
            lbLogs = new ListBox();
            pnlButtons = new Panel();
            lblTime = new Label();
            btnStep9 = new Button();
            btnStep8 = new Button();
            btnStep7 = new Button();
            btnStep6 = new Button();
            btnStep5 = new Button();
            btnStep4 = new Button();
            btnStep3 = new Button();
            btnStep2 = new Button();
            btnStep1 = new Button();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(80, 116);
            btnAsync.Margin = new Padding(3, 2, 3, 2);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(374, 59);
            btnAsync.TabIndex = 5;
            btnAsync.Text = "Start Cooking Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // btnStartCookingSync
            // 
            btnStartCookingSync.Location = new Point(80, 33);
            btnStartCookingSync.Margin = new Padding(3, 2, 3, 2);
            btnStartCookingSync.Name = "btnStartCookingSync";
            btnStartCookingSync.Size = new Size(374, 59);
            btnStartCookingSync.TabIndex = 6;
            btnStartCookingSync.Text = "Start Cooking Sync";
            btnStartCookingSync.UseVisualStyleBackColor = true;
            btnStartCookingSync.Click += btnStartCookingSync_Click;
            // 
            // lbLogs
            // 
            lbLogs.Dock = DockStyle.Bottom;
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new Point(0, 281);
            lbLogs.Margin = new Padding(3, 2, 3, 2);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(581, 169);
            lbLogs.TabIndex = 4;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(lblTime);
            pnlButtons.Controls.Add(btnStep9);
            pnlButtons.Controls.Add(btnStep8);
            pnlButtons.Controls.Add(btnStep7);
            pnlButtons.Controls.Add(btnStep6);
            pnlButtons.Controls.Add(btnStep5);
            pnlButtons.Controls.Add(btnStep4);
            pnlButtons.Controls.Add(btnStep3);
            pnlButtons.Controls.Add(btnStep2);
            pnlButtons.Controls.Add(btnStep1);
            pnlButtons.Dock = DockStyle.Right;
            pnlButtons.Location = new Point(581, 0);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(219, 450);
            pnlButtons.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Bottom;
            lblTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(0, 424);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(219, 26);
            lblTime.TabIndex = 4;
            lblTime.Text = "Timer";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStep9
            // 
            btnStep9.Dock = DockStyle.Top;
            btnStep9.FlatStyle = FlatStyle.Flat;
            btnStep9.Location = new Point(0, 280);
            btnStep9.Margin = new Padding(3, 2, 3, 2);
            btnStep9.Name = "btnStep9";
            btnStep9.Size = new Size(219, 35);
            btnStep9.TabIndex = 1;
            btnStep9.Text = "Servis Et";
            btnStep9.UseVisualStyleBackColor = true;
            // 
            // btnStep8
            // 
            btnStep8.Dock = DockStyle.Top;
            btnStep8.FlatStyle = FlatStyle.Flat;
            btnStep8.Location = new Point(0, 245);
            btnStep8.Margin = new Padding(3, 2, 3, 2);
            btnStep8.Name = "btnStep8";
            btnStep8.Size = new Size(219, 35);
            btnStep8.TabIndex = 2;
            btnStep8.Text = "Pişir";
            btnStep8.UseVisualStyleBackColor = true;
            // 
            // btnStep7
            // 
            btnStep7.Dock = DockStyle.Top;
            btnStep7.FlatStyle = FlatStyle.Flat;
            btnStep7.Location = new Point(0, 210);
            btnStep7.Margin = new Padding(3, 2, 3, 2);
            btnStep7.Name = "btnStep7";
            btnStep7.Size = new Size(219, 35);
            btnStep7.TabIndex = 3;
            btnStep7.Text = "Yumurtayı Ekle";
            btnStep7.UseVisualStyleBackColor = true;
            // 
            // btnStep6
            // 
            btnStep6.Dock = DockStyle.Top;
            btnStep6.FlatStyle = FlatStyle.Flat;
            btnStep6.Location = new Point(0, 175);
            btnStep6.Margin = new Padding(3, 2, 3, 2);
            btnStep6.Name = "btnStep6";
            btnStep6.Size = new Size(219, 35);
            btnStep6.TabIndex = 0;
            btnStep6.Text = "Yağı Dök";
            btnStep6.UseVisualStyleBackColor = true;
            // 
            // btnStep5
            // 
            btnStep5.Dock = DockStyle.Top;
            btnStep5.FlatStyle = FlatStyle.Flat;
            btnStep5.Location = new Point(0, 140);
            btnStep5.Margin = new Padding(3, 2, 3, 2);
            btnStep5.Name = "btnStep5";
            btnStep5.Size = new Size(219, 35);
            btnStep5.TabIndex = 0;
            btnStep5.Text = "Tavayı Isıt";
            btnStep5.UseVisualStyleBackColor = true;
            // 
            // btnStep4
            // 
            btnStep4.Dock = DockStyle.Top;
            btnStep4.FlatStyle = FlatStyle.Flat;
            btnStep4.Location = new Point(0, 105);
            btnStep4.Margin = new Padding(3, 2, 3, 2);
            btnStep4.Name = "btnStep4";
            btnStep4.Size = new Size(219, 35);
            btnStep4.TabIndex = 0;
            btnStep4.Text = "Ocağı Aç";
            btnStep4.UseVisualStyleBackColor = true;
            // 
            // btnStep3
            // 
            btnStep3.Dock = DockStyle.Top;
            btnStep3.FlatStyle = FlatStyle.Flat;
            btnStep3.Location = new Point(0, 70);
            btnStep3.Margin = new Padding(3, 2, 3, 2);
            btnStep3.Name = "btnStep3";
            btnStep3.Size = new Size(219, 35);
            btnStep3.TabIndex = 0;
            btnStep3.Text = "Tuz Ekle";
            btnStep3.UseVisualStyleBackColor = true;
            // 
            // btnStep2
            // 
            btnStep2.Dock = DockStyle.Top;
            btnStep2.FlatStyle = FlatStyle.Flat;
            btnStep2.Location = new Point(0, 35);
            btnStep2.Margin = new Padding(3, 2, 3, 2);
            btnStep2.Name = "btnStep2";
            btnStep2.Size = new Size(219, 35);
            btnStep2.TabIndex = 0;
            btnStep2.Text = "Yumurtaları Çırp";
            btnStep2.UseVisualStyleBackColor = true;
            // 
            // btnStep1
            // 
            btnStep1.BackColor = SystemColors.Control;
            btnStep1.Dock = DockStyle.Top;
            btnStep1.FlatStyle = FlatStyle.Flat;
            btnStep1.Location = new Point(0, 0);
            btnStep1.Margin = new Padding(3, 2, 3, 2);
            btnStep1.Name = "btnStep1";
            btnStep1.Size = new Size(219, 35);
            btnStep1.TabIndex = 0;
            btnStep1.Text = "Yumurtaları Kır";
            btnStep1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAsync);
            Controls.Add(btnStartCookingSync);
            Controls.Add(lbLogs);
            Controls.Add(pnlButtons);
            Name = "Form1";
            Text = "Form1";
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAsync;
        private Button btnStartCookingSync;
        private ListBox lbLogs;
        private Panel pnlButtons;
        private Label lblTime;
        private Button btnStep9;
        private Button btnStep8;
        private Button btnStep7;
        private Button btnStep6;
        private Button btnStep5;
        private Button btnStep4;
        private Button btnStep3;
        private Button btnStep2;
        private Button btnStep1;
    }
}