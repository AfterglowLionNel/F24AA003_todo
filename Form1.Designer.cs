namespace F24AA003_todo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.todo_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.check,
        this.todo_info,
        this.priority,
        this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 648);
            this.dataGridView1.TabIndex = 0;

            // 🔽 各列の幅や自動サイズを設定（←このブロックが追加点）
            this.check.Width = 50; // チェック列は最小限に
            this.todo_info.Width = 535;
            this.priority.Width = 60; // 他の列があれば必要
            this.delete.Width = 80;    // 他の列があれば必要

            // 
            // check
            // 
            this.check.HeaderText = "確認";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            // Width設定は上に移動
            // 
            // todo_info
            // 
            this.todo_info.HeaderText = "やること";
            this.todo_info.MinimumWidth = 6;
            this.todo_info.Name = "todo_info";
            // AutoSizeMode設定は上に移動
            // 
            // priority
            // 
            this.priority.HeaderText = "優先順位";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            // Width設定は上に移動
            // 
            // delete
            // 
            this.delete.HeaderText = "削除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            // Width設定は上に移動
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo_info;
        private System.Windows.Forms.DataGridViewComboBoxColumn priority;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

