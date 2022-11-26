namespace Sportclub
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewGroepen = new System.Windows.Forms.DataGridView();
            this.groepIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewLeden = new System.Windows.Forms.DataGridView();
            this.lidIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroepen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroepen
            // 
            this.dataGridViewGroepen.AutoGenerateColumns = false;
            this.dataGridViewGroepen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroepen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groepIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewGroepen.DataSource = this.groepBindingSource;
            this.dataGridViewGroepen.Location = new System.Drawing.Point(50, 56);
            this.dataGridViewGroepen.Name = "dataGridViewGroepen";
            this.dataGridViewGroepen.RowHeadersWidth = 51;
            this.dataGridViewGroepen.RowTemplate.Height = 29;
            this.dataGridViewGroepen.Size = new System.Drawing.Size(303, 330);
            this.dataGridViewGroepen.TabIndex = 0;
            this.dataGridViewGroepen.SelectionChanged += new System.EventHandler(this.dataGridViewGroepen_SelectionChanged);
            // 
            // groepIdDataGridViewTextBoxColumn
            // 
            this.groepIdDataGridViewTextBoxColumn.DataPropertyName = "GroepId";
            this.groepIdDataGridViewTextBoxColumn.HeaderText = "GroepId";
            this.groepIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groepIdDataGridViewTextBoxColumn.Name = "groepIdDataGridViewTextBoxColumn";
            this.groepIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.groepIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // groepBindingSource
            // 
            this.groepBindingSource.DataSource = typeof(Sportclub.Groep);
            // 
            // dataGridViewLeden
            // 
            this.dataGridViewLeden.AutoGenerateColumns = false;
            this.dataGridViewLeden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lidIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridViewLeden.DataSource = this.ledenBindingSource;
            this.dataGridViewLeden.Location = new System.Drawing.Point(439, 56);
            this.dataGridViewLeden.Name = "dataGridViewLeden";
            this.dataGridViewLeden.RowHeadersWidth = 51;
            this.dataGridViewLeden.RowTemplate.Height = 29;
            this.dataGridViewLeden.Size = new System.Drawing.Size(303, 330);
            this.dataGridViewLeden.TabIndex = 1;
            // 
            // lidIdDataGridViewTextBoxColumn
            // 
            this.lidIdDataGridViewTextBoxColumn.DataPropertyName = "LidId";
            this.lidIdDataGridViewTextBoxColumn.HeaderText = "LidId";
            this.lidIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lidIdDataGridViewTextBoxColumn.Name = "lidIdDataGridViewTextBoxColumn";
            this.lidIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lidIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ledenBindingSource
            // 
            this.ledenBindingSource.DataMember = "Leden";
            this.ledenBindingSource.DataSource = this.groepBindingSource;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(648, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewLeden);
            this.Controls.Add(this.dataGridViewGroepen);
            this.Name = "MainForm";
            this.Text = "Leden en Groepen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroepen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewGroepen;
        private DataGridView dataGridViewLeden;
        private Button buttonSave;
        private DataGridViewTextBoxColumn groepIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource groepBindingSource;
        private DataGridViewTextBoxColumn lidIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource ledenBindingSource;
    }
}