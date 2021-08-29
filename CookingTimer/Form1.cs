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

        public Form1()
        {
            InitializeComponent();

            // 最大化無効化
            this.MaximizeBox = false;

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
            iCounter = Convert.ToInt32(counter.Text);
            sPath = Convert.ToString(path.Text);

            if (iCounter <= 0 || sPath == "")
            {
                MessageBox.Show("1以上の値を設定してください、またはパスを設定してください",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


        }

        private void stop_Click(object sender, EventArgs e)
        {

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
        }

    }
}
