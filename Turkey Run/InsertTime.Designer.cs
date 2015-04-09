namespace Turkey_Run
{
    partial class InsertTime
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
            this.turkeyDBDataSet = new Turkey_Run.TurkeyDBDataSet();
            this.athDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athDataTableAdapter = new Turkey_Run.TurkeyDBDataSetTableAdapters.athDataTableAdapter();
            this.tableAdapterManager = new Turkey_Run.TurkeyDBDataSetTableAdapters.TableAdapterManager();
            this.openTimes = new System.Windows.Forms.OpenFileDialog();
            this.startDialog = new System.Windows.Forms.Button();
            this.nameList = new System.Windows.Forms.ListBox();
            this.timeList = new System.Windows.Forms.ListBox();
            this.nameDrop = new System.Windows.Forms.ComboBox();
            this.doneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turkeyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // turkeyDBDataSet
            // 
            this.turkeyDBDataSet.DataSetName = "TurkeyDBDataSet";
            this.turkeyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athDataBindingSource
            // 
            this.athDataBindingSource.DataMember = "athData";
            this.athDataBindingSource.DataSource = this.turkeyDBDataSet;
            // 
            // athDataTableAdapter
            // 
            this.athDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.athDataTableAdapter = this.athDataTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Turkey_Run.TurkeyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openTimes
            // 
            this.openTimes.FileName = "time.csv";
            // 
            // startDialog
            // 
            this.startDialog.Location = new System.Drawing.Point(328, 30);
            this.startDialog.Name = "startDialog";
            this.startDialog.Size = new System.Drawing.Size(111, 23);
            this.startDialog.TabIndex = 0;
            this.startDialog.Text = "Open TimeSheet";
            this.startDialog.UseVisualStyleBackColor = true;
            this.startDialog.Click += new System.EventHandler(this.startDialog_Click);
            // 
            // nameList
            // 
            this.nameList.FormattingEnabled = true;
            this.nameList.Location = new System.Drawing.Point(39, 54);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(205, 368);
            this.nameList.TabIndex = 1;
            this.nameList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameList_KeyPresed);
            // 
            // timeList
            // 
            this.timeList.FormattingEnabled = true;
            this.timeList.Location = new System.Drawing.Point(295, 54);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(168, 342);
            this.timeList.TabIndex = 2;
            // 
            // nameDrop
            // 
            this.nameDrop.FormattingEnabled = true;
            this.nameDrop.Location = new System.Drawing.Point(76, 30);
            this.nameDrop.Name = "nameDrop";
            this.nameDrop.Size = new System.Drawing.Size(121, 21);
            this.nameDrop.TabIndex = 3;
            this.nameDrop.Text = "Select Name";
            this.nameDrop.SelectionChangeCommitted += new System.EventHandler(this.nameDrop_Clicked);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(346, 399);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // InsertTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 435);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.nameDrop);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.startDialog);
            this.Name = "InsertTime";
            this.Text = "Import Times";
            this.Load += new System.EventHandler(this.InsertTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turkeyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TurkeyDBDataSet turkeyDBDataSet;
        private System.Windows.Forms.BindingSource athDataBindingSource;
        private TurkeyDBDataSetTableAdapters.athDataTableAdapter athDataTableAdapter;
        private TurkeyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openTimes;
        private System.Windows.Forms.Button startDialog;
        private System.Windows.Forms.ListBox nameList;
        private System.Windows.Forms.ListBox timeList;
        private System.Windows.Forms.ComboBox nameDrop;
        private System.Windows.Forms.Button doneButton;

    }
}