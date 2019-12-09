namespace TicTacToe
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.TicTacToeTitle = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.ChkBox_X = new System.Windows.Forms.CheckBox();
            this.ChkBox_O = new System.Windows.Forms.CheckBox();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicTacToeTitle
            // 
            this.TicTacToeTitle.AutoSize = true;
            this.TicTacToeTitle.BackColor = System.Drawing.Color.Transparent;
            this.TicTacToeTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToeTitle.ForeColor = System.Drawing.Color.Red;
            this.TicTacToeTitle.Location = new System.Drawing.Point(61, 9);
            this.TicTacToeTitle.Name = "TicTacToeTitle";
            this.TicTacToeTitle.Size = new System.Drawing.Size(322, 80);
            this.TicTacToeTitle.TabIndex = 0;
            this.TicTacToeTitle.Text = "Tic Tac Toe\r\n";
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(64, 102);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 100);
            this.btn_1.TabIndex = 1;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ChkBox_X
            // 
            this.ChkBox_X.AutoCheck = false;
            this.ChkBox_X.AutoSize = true;
            this.ChkBox_X.BackColor = System.Drawing.Color.Transparent;
            this.ChkBox_X.ForeColor = System.Drawing.Color.Red;
            this.ChkBox_X.Location = new System.Drawing.Point(75, 426);
            this.ChkBox_X.Name = "ChkBox_X";
            this.ChkBox_X.Size = new System.Drawing.Size(33, 17);
            this.ChkBox_X.TabIndex = 10;
            this.ChkBox_X.Text = "X";
            this.ChkBox_X.UseVisualStyleBackColor = false;
            // 
            // ChkBox_O
            // 
            this.ChkBox_O.AutoCheck = false;
            this.ChkBox_O.AutoSize = true;
            this.ChkBox_O.BackColor = System.Drawing.Color.Transparent;
            this.ChkBox_O.ForeColor = System.Drawing.Color.Red;
            this.ChkBox_O.Location = new System.Drawing.Point(114, 426);
            this.ChkBox_O.Name = "ChkBox_O";
            this.ChkBox_O.Size = new System.Drawing.Size(34, 17);
            this.ChkBox_O.TabIndex = 11;
            this.ChkBox_O.Text = "O";
            this.ChkBox_O.UseVisualStyleBackColor = false;
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.BackColor = System.Drawing.Color.Transparent;
            this.lbl_winner.ForeColor = System.Drawing.Color.Red;
            this.lbl_winner.Location = new System.Drawing.Point(25, 426);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(44, 13);
            this.lbl_winner.TabIndex = 12;
            this.lbl_winner.Text = "Winner:";
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(170, 102);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 100);
            this.btn_2.TabIndex = 13;
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(276, 102);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 100);
            this.btn_3.TabIndex = 14;
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(64, 208);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 100);
            this.btn_4.TabIndex = 15;
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(170, 208);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 100);
            this.btn_5.TabIndex = 16;
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(276, 208);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 100);
            this.btn_6.TabIndex = 17;
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(64, 314);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 100);
            this.btn_7.TabIndex = 18;
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(276, 314);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 100);
            this.btn_9.TabIndex = 19;
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(170, 314);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 100);
            this.btn_8.TabIndex = 20;
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.ForeColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(181, 420);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(70, 21);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::TicTacToe.Properties.Resources.Lightning_Theme;
            this.ClientSize = new System.Drawing.Size(444, 455);
            this.Controls.Add(this.TicTacToeTitle);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.ChkBox_O);
            this.Controls.Add(this.ChkBox_X);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 494);
            this.MinimumSize = new System.Drawing.Size(460, 494);
            this.Name = "TicTacToeForm";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicTacToeTitle;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.CheckBox ChkBox_X;
        private System.Windows.Forms.CheckBox ChkBox_O;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_Reset;
    }
}

