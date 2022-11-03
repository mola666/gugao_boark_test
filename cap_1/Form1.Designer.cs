namespace cap_1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_init = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Trap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PrfPos = new System.Windows.Forms.Label();
            this.tb_Pos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Vel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Acc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Dec = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(160, 76);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "初始化";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Trap
            // 
            this.btn_Trap.Location = new System.Drawing.Point(160, 166);
            this.btn_Trap.Name = "btn_Trap";
            this.btn_Trap.Size = new System.Drawing.Size(75, 23);
            this.btn_Trap.TabIndex = 1;
            this.btn_Trap.Text = "点位运动";
            this.btn_Trap.UseVisualStyleBackColor = true;
            this.btn_Trap.Click += new System.EventHandler(this.btn_Trap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "1轴规划位置";
            // 
            // lbl_PrfPos
            // 
            this.lbl_PrfPos.AutoSize = true;
            this.lbl_PrfPos.Location = new System.Drawing.Point(765, 81);
            this.lbl_PrfPos.Name = "lbl_PrfPos";
            this.lbl_PrfPos.Size = new System.Drawing.Size(11, 12);
            this.lbl_PrfPos.TabIndex = 3;
            this.lbl_PrfPos.Text = "0";
            this.lbl_PrfPos.Click += new System.EventHandler(this.lbl_PrfPos_Click);
            // 
            // tb_Pos
            // 
            this.tb_Pos.Location = new System.Drawing.Point(445, 78);
            this.tb_Pos.Name = "tb_Pos";
            this.tb_Pos.Size = new System.Drawing.Size(100, 21);
            this.tb_Pos.TabIndex = 4;
            this.tb_Pos.Text = "1000";
            this.tb_Pos.TextChanged += new System.EventHandler(this.tb_Pos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "目标位置";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "速度";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_Vel
            // 
            this.tb_Vel.Location = new System.Drawing.Point(445, 141);
            this.tb_Vel.Name = "tb_Vel";
            this.tb_Vel.Size = new System.Drawing.Size(100, 21);
            this.tb_Vel.TabIndex = 6;
            this.tb_Vel.Text = "10";
            this.tb_Vel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "加速度";
            // 
            // tb_Acc
            // 
            this.tb_Acc.Location = new System.Drawing.Point(445, 197);
            this.tb_Acc.Name = "tb_Acc";
            this.tb_Acc.Size = new System.Drawing.Size(100, 21);
            this.tb_Acc.TabIndex = 8;
            this.tb_Acc.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "减速度";
            // 
            // tb_Dec
            // 
            this.tb_Dec.Location = new System.Drawing.Point(445, 256);
            this.tb_Dec.Name = "tb_Dec";
            this.tb_Dec.Size = new System.Drawing.Size(100, 21);
            this.tb_Dec.TabIndex = 10;
            this.tb_Dec.Text = "1";
            this.tb_Dec.TextChanged += new System.EventHandler(this.tb_Dec_TextChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(160, 253);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "停止运动";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(892, 362);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Dec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Acc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Vel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Pos);
            this.Controls.Add(this.lbl_PrfPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Trap);
            this.Controls.Add(this.btn_init);
            this.Name = "Form1";
            this.Text = "运动";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Trap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PrfPos;
        private System.Windows.Forms.TextBox tb_Pos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Vel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Acc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Dec;
        private System.Windows.Forms.Button btn_stop;
    }
}

