namespace MonsterBattle
{
    partial class BattleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.attackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemyHealthPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.friendlyPictureBox = new System.Windows.Forms.PictureBox();
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.screenShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(12, 230);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(190, 61);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Lightningstrike";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemyPictureBox);
            this.panel1.Controls.Add(this.friendlyPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 224);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(255, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 53);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.enemyLevel);
            this.panel2.Controls.Add(this.enemyHealthPictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 49);
            this.panel2.TabIndex = 2;
            // 
            // enemyHealthPictureBox
            // 
            this.enemyHealthPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyHealthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyHealthPictureBox.Image")));
            this.enemyHealthPictureBox.Location = new System.Drawing.Point(74, 28);
            this.enemyHealthPictureBox.Name = "enemyHealthPictureBox";
            this.enemyHealthPictureBox.Size = new System.Drawing.Size(90, 5);
            this.enemyHealthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyHealthPictureBox.TabIndex = 4;
            this.enemyHealthPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.Image")));
            this.enemyPictureBox.Location = new System.Drawing.Point(289, 12);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(128, 124);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            // 
            // friendlyPictureBox
            // 
            this.friendlyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.friendlyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendlyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendlyPictureBox.Image")));
            this.friendlyPictureBox.Location = new System.Drawing.Point(59, 142);
            this.friendlyPictureBox.Name = "friendlyPictureBox";
            this.friendlyPictureBox.Size = new System.Drawing.Size(112, 82);
            this.friendlyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendlyPictureBox.TabIndex = 0;
            this.friendlyPictureBox.TabStop = false;
            // 
            // attackTimer
            // 
            this.attackTimer.Interval = 1000;
            this.attackTimer.Tick += new System.EventHandler(this.attackTimer_Tick);
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLevel.Location = new System.Drawing.Point(153, 9);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(14, 13);
            this.enemyLevel.TabIndex = 4;
            this.enemyLevel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // screenShakeTimer
            // 
            this.screenShakeTimer.Interval = 50;
            this.screenShakeTimer.Tick += new System.EventHandler(this.screenShakeTimer_Tick);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.panel1);
            this.Name = "BattleForm";
            this.Text = "Pokemon Battle";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox friendlyPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox enemyHealthPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Timer screenShakeTimer;
    }
}

