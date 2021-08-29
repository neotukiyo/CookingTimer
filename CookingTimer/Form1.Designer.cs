namespace CookingTimer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.path = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 24);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(478, 19);
            this.path.TabIndex = 0;
            this.path.Text = "C:\\Users\\Tukiyo\\Desktop\\Toby Fox - DELTARUNE Chapter 1 OST_wav\\Toby Fox - DELTARU" +
    "NE Chapter 1 OST - 01 もうひとりの彼.wav";
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.counter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.counter.Location = new System.Drawing.Point(417, 65);
            this.counter.Multiline = true;
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(55, 32);
            this.counter.TabIndex = 1;
            this.counter.Text = "10";
            this.counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.counter.TextChanged += new System.EventHandler(this.counter_TextChanged);
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(496, 22);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(75, 23);
            this.selectPath.TabIndex = 2;
            this.selectPath.Text = "パス";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(496, 71);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "開始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(428, 153);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(143, 36);
            this.stop.TabIndex = 2;
            this.stop.Text = "音楽停止(ループ)";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(315, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "繰り返し数";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CountDown.Location = new System.Drawing.Point(498, 112);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(0, 27);
            this.CountDown.TabIndex = 4;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(12, 206);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(71, 35);
            this.reset.TabIndex = 5;
            this.reset.Text = "リセット";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 253);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CookingTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox counter;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Timer timer1;
    }
}

