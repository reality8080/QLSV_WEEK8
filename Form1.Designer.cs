namespace QLSV
{
    partial class Form1
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
            panelLayout = new Panel();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            viewBtn = new Button();
            AVGTxb = new TextBox();
            AVGLb = new Label();
            mssvTxb = new TextBox();
            idLb = new Label();
            facultytxB = new TextBox();
            facultyLb = new Label();
            nametXb = new TextBox();
            nameLb = new Label();
            infoDGV = new DataGridView();
            panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoDGV).BeginInit();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Controls.Add(DeleteBtn);
            panelLayout.Controls.Add(UpdateBtn);
            panelLayout.Controls.Add(AddBtn);
            panelLayout.Controls.Add(viewBtn);
            panelLayout.Controls.Add(AVGTxb);
            panelLayout.Controls.Add(AVGLb);
            panelLayout.Controls.Add(mssvTxb);
            panelLayout.Controls.Add(idLb);
            panelLayout.Controls.Add(facultytxB);
            panelLayout.Controls.Add(facultyLb);
            panelLayout.Controls.Add(nametXb);
            panelLayout.Controls.Add(nameLb);
            panelLayout.Controls.Add(infoDGV);
            panelLayout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelLayout.Location = new Point(12, 12);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(776, 426);
            panelLayout.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(163, 361);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(19, 361);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Sửa";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(163, 309);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(19, 309);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(94, 29);
            viewBtn.TabIndex = 9;
            viewBtn.Text = "Xem";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // AVGTxb
            // 
            AVGTxb.Location = new Point(107, 228);
            AVGTxb.Name = "AVGTxb";
            AVGTxb.Size = new Size(171, 30);
            AVGTxb.TabIndex = 8;
            AVGTxb.KeyPress += AVGTxb_KeyPress;
            // 
            // AVGLb
            // 
            AVGLb.AutoSize = true;
            AVGLb.Location = new Point(19, 235);
            AVGLb.Name = "AVGLb";
            AVGLb.Size = new Size(74, 23);
            AVGLb.TabIndex = 7;
            AVGLb.Text = "Điểm Tb";
            // 
            // mssvTxb
            // 
            mssvTxb.Location = new Point(107, 166);
            mssvTxb.Name = "mssvTxb";
            mssvTxb.Size = new Size(171, 30);
            mssvTxb.TabIndex = 6;
            mssvTxb.KeyPress += mssvTxb_KeyPress;
            // 
            // idLb
            // 
            idLb.AutoSize = true;
            idLb.Location = new Point(19, 173);
            idLb.Name = "idLb";
            idLb.Size = new Size(49, 23);
            idLb.TabIndex = 5;
            idLb.Text = "Mssv";
            // 
            // facultytxB
            // 
            facultytxB.Location = new Point(107, 110);
            facultytxB.Name = "facultytxB";
            facultytxB.Size = new Size(171, 30);
            facultytxB.TabIndex = 4;
            facultytxB.KeyPress += facultytxB_KeyPress;
            // 
            // facultyLb
            // 
            facultyLb.AutoSize = true;
            facultyLb.Location = new Point(19, 117);
            facultyLb.Name = "facultyLb";
            facultyLb.Size = new Size(62, 23);
            facultyLb.TabIndex = 3;
            facultyLb.Text = "Ngành";
            // 
            // nametXb
            // 
            nametXb.Location = new Point(107, 48);
            nametXb.Name = "nametXb";
            nametXb.Size = new Size(171, 30);
            nametXb.TabIndex = 2;
            nametXb.KeyPress += nametXb_KeyPress;
            // 
            // nameLb
            // 
            nameLb.AutoSize = true;
            nameLb.Location = new Point(19, 55);
            nameLb.Name = "nameLb";
            nameLb.Size = new Size(36, 23);
            nameLb.TabIndex = 1;
            nameLb.Text = "Tên";
            // 
            // infoDGV
            // 
            infoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoDGV.Location = new Point(338, 3);
            infoDGV.Name = "infoDGV";
            infoDGV.RowHeadersWidth = 51;
            infoDGV.Size = new Size(435, 420);
            infoDGV.TabIndex = 0;
            infoDGV.CellClick += infoDGV_CellClick;
            infoDGV.SelectionChanged += infoDGV_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLayout);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelLayout.ResumeLayout(false);
            panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayout;
        private TextBox facultytxB;
        private Label facultyLb;
        private TextBox nametXb;
        private Label nameLb;
        private DataGridView infoDGV;
        private TextBox AVGTxb;
        private Label AVGLb;
        private TextBox mssvTxb;
        private Label idLb;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button AddBtn;
        private Button viewBtn;
    }
}
