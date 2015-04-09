namespace Turkey_Run
{
    partial class AddAth
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
            this.athNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exTimeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // athNameText
            // 
            this.athNameText.AcceptsReturn = true;
            this.athNameText.Location = new System.Drawing.Point(36, 68);
            this.athNameText.Name = "athNameText";
            this.athNameText.Size = new System.Drawing.Size(231, 20);
            this.athNameText.TabIndex = 0;
            this.athNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athlete Name";
            // 
            // exTimeText
            // 
            this.exTimeText.Location = new System.Drawing.Point(39, 149);
            this.exTimeText.Name = "exTimeText";
            this.exTimeText.Size = new System.Drawing.Size(228, 20);
            this.exTimeText.TabIndex = 2;
            this.exTimeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expected Time (mm:ss)";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(114, 247);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Add!";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            this.doneButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // AddAth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 377);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exTimeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.athNameText);
            this.Name = "AddAth";
            this.Text = "Add Athlete";
            this.Load += new System.EventHandler(this.AddAth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turkeyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TurkeyDBDataSet turkeyDBDataSet;
        private System.Windows.Forms.BindingSource athDataBindingSource;
        private TurkeyDBDataSetTableAdapters.athDataTableAdapter athDataTableAdapter;
        private TurkeyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox athNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exTimeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doneButton;
    }
}