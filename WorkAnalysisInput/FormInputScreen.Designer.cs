namespace WorkAnalysisInput
{
    partial class FormInputScreen
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.dataGridViewInputWorkingTime = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.始業時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終業時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.労働時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.残業時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableWorkTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetWorkTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetWorkTime = new WorkAnalysisInput.DataSetWorkTime();
            this.textBoxFixedWorkingTime = new System.Windows.Forms.TextBox();
            this.labelFixedWorkingTime = new System.Windows.Forms.Label();
            this.buttonWorkingTimeRegister = new System.Windows.Forms.Button();
            this.dateTimePickerSelect = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputWorkingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorkTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorkTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInputWorkingTime
            // 
            this.dataGridViewInputWorkingTime.AutoGenerateColumns = false;
            this.dataGridViewInputWorkingTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputWorkingTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.始業時間DataGridViewTextBoxColumn,
            this.終業時間DataGridViewTextBoxColumn,
            this.労働時間DataGridViewTextBoxColumn,
            this.残業時間DataGridViewTextBoxColumn});
            this.dataGridViewInputWorkingTime.DataSource = this.dataTableWorkTimeBindingSource;
            this.dataGridViewInputWorkingTime.Enabled = false;
            this.dataGridViewInputWorkingTime.Location = new System.Drawing.Point(18, 121);
            this.dataGridViewInputWorkingTime.Name = "dataGridViewInputWorkingTime";
            this.dataGridViewInputWorkingTime.RowTemplate.Height = 21;
            this.dataGridViewInputWorkingTime.Size = new System.Drawing.Size(807, 361);
            this.dataGridViewInputWorkingTime.TabIndex = 0;
            this.dataGridViewInputWorkingTime.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInputWorkingTime_CellFormatting);
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // 始業時間DataGridViewTextBoxColumn
            // 
            this.始業時間DataGridViewTextBoxColumn.DataPropertyName = "始業時間";
            this.始業時間DataGridViewTextBoxColumn.HeaderText = "始業時間";
            this.始業時間DataGridViewTextBoxColumn.Name = "始業時間DataGridViewTextBoxColumn";
            // 
            // 終業時間DataGridViewTextBoxColumn
            // 
            this.終業時間DataGridViewTextBoxColumn.DataPropertyName = "終業時間";
            this.終業時間DataGridViewTextBoxColumn.HeaderText = "終業時間";
            this.終業時間DataGridViewTextBoxColumn.Name = "終業時間DataGridViewTextBoxColumn";
            // 
            // 労働時間DataGridViewTextBoxColumn
            // 
            this.労働時間DataGridViewTextBoxColumn.DataPropertyName = "労働時間";
            this.労働時間DataGridViewTextBoxColumn.HeaderText = "労働時間";
            this.労働時間DataGridViewTextBoxColumn.Name = "労働時間DataGridViewTextBoxColumn";
            // 
            // 残業時間DataGridViewTextBoxColumn
            // 
            this.残業時間DataGridViewTextBoxColumn.DataPropertyName = "残業時間";
            this.残業時間DataGridViewTextBoxColumn.HeaderText = "残業時間";
            this.残業時間DataGridViewTextBoxColumn.Name = "残業時間DataGridViewTextBoxColumn";
            // 
            // dataTableWorkTimeBindingSource
            // 
            this.dataTableWorkTimeBindingSource.DataMember = "DataTableWorkTime";
            this.dataTableWorkTimeBindingSource.DataSource = this.dataSetWorkTimeBindingSource;
            // 
            // dataSetWorkTimeBindingSource
            // 
            this.dataSetWorkTimeBindingSource.DataSource = this.dataSetWorkTime;
            this.dataSetWorkTimeBindingSource.Position = 0;
            // 
            // dataSetWorkTime
            // 
            this.dataSetWorkTime.DataSetName = "DataSetWorkTime";
            this.dataSetWorkTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxFixedWorkingTime
            // 
            this.textBoxFixedWorkingTime.Location = new System.Drawing.Point(97, 71);
            this.textBoxFixedWorkingTime.Name = "textBoxFixedWorkingTime";
            this.textBoxFixedWorkingTime.Size = new System.Drawing.Size(100, 19);
            this.textBoxFixedWorkingTime.TabIndex = 2;
            // 
            // labelFixedWorkingTime
            // 
            this.labelFixedWorkingTime.AutoSize = true;
            this.labelFixedWorkingTime.Location = new System.Drawing.Point(16, 76);
            this.labelFixedWorkingTime.Name = "labelFixedWorkingTime";
            this.labelFixedWorkingTime.Size = new System.Drawing.Size(77, 12);
            this.labelFixedWorkingTime.TabIndex = 3;
            this.labelFixedWorkingTime.Text = "所定労働時間";
            // 
            // buttonWorkingTimeRegister
            // 
            this.buttonWorkingTimeRegister.Location = new System.Drawing.Point(203, 69);
            this.buttonWorkingTimeRegister.Name = "buttonWorkingTimeRegister";
            this.buttonWorkingTimeRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonWorkingTimeRegister.TabIndex = 4;
            this.buttonWorkingTimeRegister.Text = "登録";
            this.buttonWorkingTimeRegister.UseVisualStyleBackColor = true;
            this.buttonWorkingTimeRegister.Click += new System.EventHandler(this.buttonWorkingTimeRegister_Click);
            // 
            // dateTimePickerSelect
            // 
            this.dateTimePickerSelect.CustomFormat = "yyyy/MM";
            this.dateTimePickerSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSelect.Location = new System.Drawing.Point(18, 12);
            this.dateTimePickerSelect.Name = "dateTimePickerSelect";
            this.dateTimePickerSelect.ShowUpDown = true;
            this.dateTimePickerSelect.Size = new System.Drawing.Size(156, 19);
            this.dateTimePickerSelect.TabIndex = 5;
            // 
            // FormInputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 526);
            this.Controls.Add(this.dateTimePickerSelect);
            this.Controls.Add(this.buttonWorkingTimeRegister);
            this.Controls.Add(this.labelFixedWorkingTime);
            this.Controls.Add(this.textBoxFixedWorkingTime);
            this.Controls.Add(this.dataGridViewInputWorkingTime);
            this.Name = "FormInputScreen";
            this.Text = "出退勤時刻入力画面";
            this.Load += new System.EventHandler(this.FormInputScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputWorkingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWorkTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorkTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWorkTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInputWorkingTime;
        private System.Windows.Forms.TextBox textBoxFixedWorkingTime;
        private System.Windows.Forms.Label labelFixedWorkingTime;
        private System.Windows.Forms.Button buttonWorkingTimeRegister;
        private System.Windows.Forms.DateTimePicker dateTimePickerSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 始業時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終業時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 労働時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 残業時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableWorkTimeBindingSource;
        private System.Windows.Forms.BindingSource dataSetWorkTimeBindingSource;
        private DataSetWorkTime dataSetWorkTime;
    }
}

