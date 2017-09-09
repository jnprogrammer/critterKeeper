namespace Quest6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFeed = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnListen = new System.Windows.Forms.Button();
            this.btnTrick = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barHunger = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutPut = new System.Windows.Forms.RichTextBox();
            this.barBoardem = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(14, 56);
            this.btnFeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(108, 55);
            this.btnFeed.TabIndex = 0;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(7, 11);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(132, 38);
            this.lblOut.TabIndex = 1;
            this.lblOut.Text = "Actions";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(14, 119);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(108, 55);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnTrick
            // 
            this.btnTrick.Location = new System.Drawing.Point(14, 246);
            this.btnTrick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrick.Name = "btnTrick";
            this.btnTrick.Size = new System.Drawing.Size(108, 55);
            this.btnTrick.TabIndex = 3;
            this.btnTrick.Text = "Do a Trick";
            this.btnTrick.UseVisualStyleBackColor = true;
            this.btnTrick.Click += new System.EventHandler(this.btnTrick_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(14, 182);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 55);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(542, 8);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 41);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // barHunger
            // 
            this.barHunger.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.barHunger.Location = new System.Drawing.Point(244, 56);
            this.barHunger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barHunger.Maximum = 200;
            this.barHunger.Name = "barHunger";
            this.barHunger.Size = new System.Drawing.Size(144, 55);
            this.barHunger.Step = 1;
            this.barHunger.TabIndex = 7;
            this.barHunger.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fullness ";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(158, 182);
            this.txtOutPut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.ReadOnly = true;
            this.txtOutPut.Size = new System.Drawing.Size(232, 119);
            this.txtOutPut.TabIndex = 9;
            this.txtOutPut.Text = "";
            // 
            // barBoardem
            // 
            this.barBoardem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.barBoardem.Location = new System.Drawing.Point(246, 119);
            this.barBoardem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barBoardem.Maximum = 200;
            this.barBoardem.Name = "barBoardem";
            this.barBoardem.Size = new System.Drawing.Size(144, 55);
            this.barBoardem.Step = 1;
            this.barBoardem.TabIndex = 10;
            this.barBoardem.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Boardom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barBoardem);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barHunger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnTrick);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnFeed);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "crazy Critter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnTrick;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar barHunger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtOutPut;
        private System.Windows.Forms.ProgressBar barBoardem;
        private System.Windows.Forms.Label label2;
    }
}

