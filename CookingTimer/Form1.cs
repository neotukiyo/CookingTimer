using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingTimer
{
    public partial class Form1 : Form
    {
        private int iCounter = 0;
        private string sPath = "";
        private Control control = new Control("");
        private bool first = true;
        private int time = 0;
        private DateTime datetime_now;
        private DateTime datetime_set;

        public Form1()
        {
            InitializeComponent();

            // 設定ファイルの読み込み
            Properties.Settings.Default.Reload();
            path.Text = Properties.Settings.Default.Path;
        }

        private void path_TextChanged(object sender, EventArgs e) { /*使わない*/ }
        private void counter_TextChanged(object sender, EventArgs e) { /*使わない*/ }

        private void selectPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (first)
            {
                iCounter = Convert.ToInt32(counter.Text);
                sPath = Convert.ToString(path.Text);
                control = new Control(sPath);
                first = false;
            }

            if (iCounter <= 0 || sPath == "")
            {
                MessageBox.Show("1以上の値を設定してください、またはパスを設定してください",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                // ボタン非活性化
                selectPath.Enabled = false;
                counter.Enabled = false;
                path.Enabled = false;
                start.Enabled = false;

                time = 0;
                datetime_now = DateTime.Now;
                datetime_set = datetime_now.AddMinutes(30);
                timer1.Start();

                // 音楽再生後、ウィンドウをアクティブにする。
                this.Activate();

            }

        }

        /// <summary>
        /// リピート
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            // タイマーを30に戻す
            CountDown.Text = "30:00";

            // 音楽停止
            control.StopMusic();


            if (--iCounter == 0)
            {
                // 終了
                reset.PerformClick();
            }
            else
            {
                // 再度カウントダウン開始
                start.Enabled = true;
                start.PerformClick();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // ボタン活性化
            selectPath.Enabled = true;
            counter.Enabled = true;
            path.Enabled = true;
            start.Enabled = true;

            CountDown.Text = "30:00";

            timer1.Stop();

            control.StopMusic();
            control = null;
            first = true;
        }

        /// <summary>
        /// 設定ファイルの保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //アプリケーションの設定を保存する
            Properties.Settings.Default.Path = sPath;
            Properties.Settings.Default.Save();

            control = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime_now = DateTime.Now;
            time = (((datetime_set.Hour - datetime_now.Hour) * 3600) + ((datetime_set.Minute - datetime_now.Minute) * 60) + (datetime_set.Second - datetime_now.Second));

            CountDown.Text = (time % 3600) / 60 + ":" + (time % 3600) % 60;

            if (time == 0)
            {
                control.StartMusic();

                MessageBox.Show("ストレッチしろ",
                "ストレッチしろ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                stop.PerformClick();
            }
        }
    }
}
