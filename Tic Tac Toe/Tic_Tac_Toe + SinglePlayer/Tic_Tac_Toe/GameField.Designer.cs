namespace Tic_Tac_Toe
{
    partial class GameField
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.Button();
            this.Y2 = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.Button();
            this.Z1 = new System.Windows.Forms.Button();
            this.Z2 = new System.Windows.Forms.Button();
            this.Z3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePlayerToolStripMenuItem,
            this.multiplayerGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "New Game";
            // 
            // singlePlayerToolStripMenuItem
            // 
            this.singlePlayerToolStripMenuItem.Name = "singlePlayerToolStripMenuItem";
            this.singlePlayerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.singlePlayerToolStripMenuItem.Text = "Singleplayer Game";
            this.singlePlayerToolStripMenuItem.Click += new System.EventHandler(this.singlePlayerToolStripMenuItem_Click);
            // 
            // multiplayerGameToolStripMenuItem
            // 
            this.multiplayerGameToolStripMenuItem.Name = "multiplayerGameToolStripMenuItem";
            this.multiplayerGameToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.multiplayerGameToolStripMenuItem.Text = "Multiplayer Game";
            this.multiplayerGameToolStripMenuItem.Click += new System.EventHandler(this.multiplayerGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(150, 150);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(324, 27);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(150, 150);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(12, 183);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(150, 150);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(168, 183);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(150, 150);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(324, 183);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(150, 150);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(12, 339);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(150, 150);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(168, 339);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(150, 150);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(324, 339);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(150, 150);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(168, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(150, 150);
            this.A2.TabIndex = 11;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // X1
            // 
            this.X1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1.Location = new System.Drawing.Point(610, 27);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(150, 150);
            this.X1.TabIndex = 12;
            this.X1.UseVisualStyleBackColor = true;
            this.X1.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // X2
            // 
            this.X2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2.Location = new System.Drawing.Point(766, 27);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(150, 150);
            this.X2.TabIndex = 13;
            this.X2.UseVisualStyleBackColor = true;
            this.X2.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // X3
            // 
            this.X3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X3.Location = new System.Drawing.Point(922, 27);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(150, 150);
            this.X3.TabIndex = 14;
            this.X3.UseVisualStyleBackColor = true;
            this.X3.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Y1
            // 
            this.Y1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y1.Location = new System.Drawing.Point(610, 183);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(150, 150);
            this.Y1.TabIndex = 15;
            this.Y1.UseVisualStyleBackColor = true;
            this.Y1.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Y2
            // 
            this.Y2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y2.Location = new System.Drawing.Point(766, 183);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(150, 150);
            this.Y2.TabIndex = 16;
            this.Y2.UseVisualStyleBackColor = true;
            this.Y2.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Y3
            // 
            this.Y3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y3.Location = new System.Drawing.Point(922, 183);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(150, 150);
            this.Y3.TabIndex = 17;
            this.Y3.UseVisualStyleBackColor = true;
            this.Y3.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Z1
            // 
            this.Z1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z1.Location = new System.Drawing.Point(610, 339);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(150, 150);
            this.Z1.TabIndex = 18;
            this.Z1.UseVisualStyleBackColor = true;
            this.Z1.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Z2
            // 
            this.Z2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z2.Location = new System.Drawing.Point(766, 339);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(150, 150);
            this.Z2.TabIndex = 19;
            this.Z2.UseVisualStyleBackColor = true;
            this.Z2.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // Z3
            // 
            this.Z3.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z3.Location = new System.Drawing.Point(922, 339);
            this.Z3.Name = "Z3";
            this.Z3.Size = new System.Drawing.Size(150, 150);
            this.Z3.TabIndex = 20;
            this.Z3.UseVisualStyleBackColor = true;
            this.Z3.Click += new System.EventHandler(this.SingleButtonClick);
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 499);
            this.Controls.Add(this.Z3);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.Z1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameField";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerGameToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button X1;
        private System.Windows.Forms.Button X2;
        private System.Windows.Forms.Button X3;
        private System.Windows.Forms.Button Y1;
        private System.Windows.Forms.Button Y2;
        private System.Windows.Forms.Button Y3;
        private System.Windows.Forms.Button Z1;
        private System.Windows.Forms.Button Z2;
        private System.Windows.Forms.Button Z3;
    }
}

