namespace symulacja_RFID
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lblpos1 = new System.Windows.Forms.Label();
            this.textnoise = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbroken = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRealpos1 = new System.Windows.Forms.Label();
            this.SaveValues = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblrealang = new System.Windows.Forms.Label();
            this.lblsysorient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_vlin = new System.Windows.Forms.TextBox();
            this.text_vrot = new System.Windows.Forms.TextBox();
            this.combo_ster = new System.Windows.Forms.ComboBox();
            this.Button_apply = new System.Windows.Forms.Button();
            this.lblvlin = new System.Windows.Forms.Label();
            this.lblvrot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1000, 1000);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(611, 55);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.Location = new System.Drawing.Point(35, 27);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1024, 226);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 40);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start Sim";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1023, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1019, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of sensors";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1022, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1019, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sensor rage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1021, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "System\r\nposition";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPosition.Location = new System.Drawing.Point(587, 248);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 33);
            this.lblPosition.TabIndex = 11;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Random sensor",
            "The closest sensor"});
            this.comboBox.Location = new System.Drawing.Point(1024, 199);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(140, 21);
            this.comboBox.TabIndex = 12;
            // 
            // lblpos1
            // 
            this.lblpos1.AutoSize = true;
            this.lblpos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpos1.Location = new System.Drawing.Point(1019, 319);
            this.lblpos1.Name = "lblpos1";
            this.lblpos1.Size = new System.Drawing.Size(17, 25);
            this.lblpos1.TabIndex = 13;
            this.lblpos1.Text = "l";
            // 
            // textnoise
            // 
            this.textnoise.Location = new System.Drawing.Point(1022, 121);
            this.textnoise.Name = "textnoise";
            this.textnoise.Size = new System.Drawing.Size(142, 20);
            this.textnoise.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1021, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Noise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1021, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Which passive sensor should be activated";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textbroken
            // 
            this.textbroken.Location = new System.Drawing.Point(1022, 160);
            this.textbroken.Name = "textbroken";
            this.textbroken.Size = new System.Drawing.Size(140, 20);
            this.textbroken.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1023, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "% of broken passive sensors";
            // 
            // lblRealpos1
            // 
            this.lblRealpos1.AutoSize = true;
            this.lblRealpos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRealpos1.Location = new System.Drawing.Point(1147, 319);
            this.lblRealpos1.Name = "lblRealpos1";
            this.lblRealpos1.Size = new System.Drawing.Size(17, 25);
            this.lblRealpos1.TabIndex = 19;
            this.lblRealpos1.Text = "l";
            // 
            // SaveValues
            // 
            this.SaveValues.Location = new System.Drawing.Point(1026, 686);
            this.SaveValues.Name = "SaveValues";
            this.SaveValues.Size = new System.Drawing.Size(139, 23);
            this.SaveValues.TabIndex = 20;
            this.SaveValues.Text = "Save possition";
            this.SaveValues.UseVisualStyleBackColor = true;
            this.SaveValues.Click += new System.EventHandler(this.SaveValues_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1141, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 50);
            this.label7.TabIndex = 21;
            this.label7.Text = "Real\r\nposition";
            // 
            // lblrealang
            // 
            this.lblrealang.AutoSize = true;
            this.lblrealang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblrealang.Location = new System.Drawing.Point(1148, 519);
            this.lblrealang.Name = "lblrealang";
            this.lblrealang.Size = new System.Drawing.Size(17, 25);
            this.lblrealang.TabIndex = 22;
            this.lblrealang.Text = "l";
            // 
            // lblsysorient
            // 
            this.lblsysorient.AutoSize = true;
            this.lblsysorient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblsysorient.Location = new System.Drawing.Point(1152, 574);
            this.lblsysorient.Name = "lblsysorient";
            this.lblsysorient.Size = new System.Drawing.Size(17, 25);
            this.lblsysorient.TabIndex = 23;
            this.lblsysorient.Text = "l";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1021, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Real orientation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1021, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "System orientation";
            // 
            // text_vlin
            // 
            this.text_vlin.Enabled = false;
            this.text_vlin.Location = new System.Drawing.Point(1251, 82);
            this.text_vlin.Name = "text_vlin";
            this.text_vlin.Size = new System.Drawing.Size(140, 20);
            this.text_vlin.TabIndex = 26;
            // 
            // text_vrot
            // 
            this.text_vrot.Enabled = false;
            this.text_vrot.Location = new System.Drawing.Point(1251, 108);
            this.text_vrot.Name = "text_vrot";
            this.text_vrot.Size = new System.Drawing.Size(140, 20);
            this.text_vrot.TabIndex = 27;
            // 
            // combo_ster
            // 
            this.combo_ster.FormattingEnabled = true;
            this.combo_ster.Items.AddRange(new object[] {
            "Keyboard",
            "Speeds"});
            this.combo_ster.Location = new System.Drawing.Point(1251, 52);
            this.combo_ster.Name = "combo_ster";
            this.combo_ster.Size = new System.Drawing.Size(140, 21);
            this.combo_ster.TabIndex = 28;
            // 
            // Button_apply
            // 
            this.Button_apply.Enabled = false;
            this.Button_apply.Location = new System.Drawing.Point(1251, 134);
            this.Button_apply.Name = "Button_apply";
            this.Button_apply.Size = new System.Drawing.Size(140, 40);
            this.Button_apply.TabIndex = 29;
            this.Button_apply.Text = "Apply";
            this.Button_apply.UseVisualStyleBackColor = true;
            this.Button_apply.Click += new System.EventHandler(this.Button_apply_Click);
            // 
            // lblvlin
            // 
            this.lblvlin.AutoSize = true;
            this.lblvlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblvlin.Location = new System.Drawing.Point(1374, 185);
            this.lblvlin.Name = "lblvlin";
            this.lblvlin.Size = new System.Drawing.Size(17, 25);
            this.lblvlin.TabIndex = 30;
            this.lblvlin.Text = "l";
            // 
            // lblvrot
            // 
            this.lblvrot.AutoSize = true;
            this.lblvrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblvrot.Location = new System.Drawing.Point(1374, 210);
            this.lblvrot.Name = "lblvrot";
            this.lblvrot.Size = new System.Drawing.Size(17, 25);
            this.lblvrot.TabIndex = 31;
            this.lblvrot.Text = "l";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1248, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Linear speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1248, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ratation speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(1248, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Control type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 1061);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvrot);
            this.Controls.Add(this.lblvlin);
            this.Controls.Add(this.Button_apply);
            this.Controls.Add(this.combo_ster);
            this.Controls.Add(this.text_vrot);
            this.Controls.Add(this.text_vlin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblsysorient);
            this.Controls.Add(this.lblrealang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveValues);
            this.Controls.Add(this.lblRealpos1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbroken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnoise);
            this.Controls.Add(this.lblpos1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lblpos1;
        private System.Windows.Forms.TextBox textnoise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbroken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRealpos1;
        private System.Windows.Forms.Button SaveValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblrealang;
        private System.Windows.Forms.Label lblsysorient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_vlin;
        private System.Windows.Forms.TextBox text_vrot;
        private System.Windows.Forms.ComboBox combo_ster;
        private System.Windows.Forms.Button Button_apply;
        private System.Windows.Forms.Label lblvlin;
        private System.Windows.Forms.Label lblvrot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

