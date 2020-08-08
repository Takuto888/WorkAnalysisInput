using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkAnalysisInput
{
    public partial class FormInputScreen : Form
    {
        #region 列挙型

        enum EHeader
        {
            Date,               //日付
            OpeningTime,        //始業時間
            ClosingTime,        //終業時間
            WorkingTime,        //労働時間
            OverTime            //残業時間
        }

        #endregion


        #region フィールド


        private int daysInMonth;                                    //最終日
        private TimeSpan fixWorkingTime;                            //所定労働時間
        private TimeSpan breakTime = new TimeSpan(1, 0, 0);         //休憩時間

        #endregion


        #region コンストラクタ
        public FormInputScreen()
        {
            InitializeComponent();
        }
        #endregion

        #region ロードイベント
        private void FormInputScreen_Load(object sender, EventArgs e)
        {
            //現在の日付を取得
            DateTime now = DateTime.Now;
  

            //月の最終日を取得
            this.daysInMonth = DateTime.DaysInMonth(now.Year,now.Month);

            //データグリッドビューに追加
            for(int day = 1; day <= daysInMonth; day++)
            {
                this.dataSetWorkTime.DataTableWorkTime.Rows.Add(new DateTime(now.Year, now.Month, day));
            }


        }
        #endregion


        #region 入力ボタン
        private void buttonWorkingTimeRegister_Click(object sender, EventArgs e)
        {

            try
            {
                //入力チェック
                if(this.textBoxFixedWorkingTime.Text == string.Empty)
                {
                    MessageBox.Show("所定労働時間を入力してください。");
                    return;
                }

                //TimeSpan型の確認
                if(TimeSpan.TryParse(this.textBoxFixedWorkingTime.Text, out this.fixWorkingTime) != true)
                {
                    MessageBox.Show("数値を入力してください。");
                }

                MessageBox.Show("登録完了");


                //データグリッドビューの許可
                this.dataGridViewInputWorkingTime.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show("エラー：" + ex.ToString());
            }

        }
        #endregion


        #region 残業時間の計算
        private void dataGridViewInputWorkingTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((this.dataGridViewInputWorkingTime[(int)EHeader.OpeningTime, e.RowIndex].Value != null) && (this.dataGridViewInputWorkingTime[(int)EHeader.ClosingTime, e.RowIndex].Value != null))
            {
                ////セル内に入力された、時刻を変数に格納
                //DateTime dateOpening = DateTime.Parse((string)this.dataGridViewInputWorkingTime[(int)EHeader.OpeningTime, e.RowIndex].Value);
                //DateTime dateClosingTime = DateTime.Parse((string)this.dataGridViewInputWorkingTime[(int)EHeader.ClosingTime, e.RowIndex].Value);

                


                ////労働時間の計算
                //TimeSpan workingTime = dateClosingTime - dateOpening;
                //this.dataGridViewInputWorkingTime[(int)EHeader.WorkingTime, e.RowIndex].Value = workingTime.ToString();

                ////労働時間と所定労働時間を比較
                //if(workingTime > fixWorkingTime)
                //{
                //    this.dataGridViewInputWorkingTime[(int)EHeader.OverTime, e.RowIndex].Value = (workingTime - fixWorkingTime - breakTime).ToString();
                //}
                //else
                //{
                //    //残業時間を0に設定
                //    this.dataGridViewInputWorkingTime[(int)EHeader.OverTime, e.RowIndex].Value = new TimeSpan(0,0,0);
                //}



            }
        }
        #endregion
    }
}
