namespace Billiones_CabalhaoJFINAL
{
    partial class Grades
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grades));
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.txtPrelim = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.dgvGradesInfo = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.lblMname = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblPrelim = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(163, 59);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(191, 26);
            this.txtFirstname.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(163, 91);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(191, 26);
            this.txtLastname.TabIndex = 1;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(163, 123);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(191, 26);
            this.txtMiddlename.TabIndex = 2;
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(163, 155);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(191, 26);
            this.txtProgram.TabIndex = 3;
            this.txtProgram.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Items.AddRange(new object[] {
            "Computer Programming 2",
            "Animation & Multimedia",
            "Discrete Structure",
            "Mathematics in the Modern World",
            "Purposive Communication",
            "Art Appreciation",
            "NSTP2",
            "PAFIT2"});
            this.cmbSubjects.Location = new System.Drawing.Point(454, 57);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 28);
            this.cmbSubjects.TabIndex = 4;
            // 
            // txtPrelim
            // 
            this.txtPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelim.Location = new System.Drawing.Point(511, 100);
            this.txtPrelim.Name = "txtPrelim";
            this.txtPrelim.Size = new System.Drawing.Size(64, 26);
            this.txtPrelim.TabIndex = 5;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.Location = new System.Drawing.Point(511, 127);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(64, 26);
            this.txtMidterm.TabIndex = 6;
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(511, 154);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(64, 26);
            this.txtFinal.TabIndex = 7;
            // 
            // dgvGradesInfo
            // 
            this.dgvGradesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradesInfo.Location = new System.Drawing.Point(62, 250);
            this.dgvGradesInfo.Name = "dgvGradesInfo";
            this.dgvGradesInfo.Size = new System.Drawing.Size(513, 272);
            this.dgvGradesInfo.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(62, 204);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 40);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(257, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteAll.Location = new System.Drawing.Point(435, 204);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "DELETE ALL";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(58, 62);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(88, 20);
            this.lblFname.TabIndex = 12;
            this.lblFname.Text = "Firstname :";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Transparent;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(58, 91);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(88, 20);
            this.lblLname.TabIndex = 13;
            this.lblLname.Text = "Lastname :";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.BackColor = System.Drawing.Color.Transparent;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.Location = new System.Drawing.Point(58, 153);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(77, 20);
            this.lblProg.TabIndex = 15;
            this.lblProg.Text = "Program :";
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.BackColor = System.Drawing.Color.Transparent;
            this.lblMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMname.Location = new System.Drawing.Point(58, 124);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(103, 20);
            this.lblMname.TabIndex = 14;
            this.lblMname.Text = "Middlename :";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(377, 162);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(83, 20);
            this.lblFinal.TabIndex = 18;
            this.lblFinal.Text = "Final  50%";
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.BackColor = System.Drawing.Color.Transparent;
            this.lblMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(377, 129);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(106, 20);
            this.lblMidterm.TabIndex = 17;
            this.lblMidterm.Text = "Midterm  30%";
            // 
            // lblPrelim
            // 
            this.lblPrelim.AutoSize = true;
            this.lblPrelim.BackColor = System.Drawing.Color.Transparent;
            this.lblPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrelim.Location = new System.Drawing.Point(377, 100);
            this.lblPrelim.Name = "lblPrelim";
            this.lblPrelim.Size = new System.Drawing.Size(92, 20);
            this.lblPrelim.TabIndex = 16;
            this.lblPrelim.Text = "Prelim  20%";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(377, 62);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(71, 20);
            this.lblSub.TabIndex = 19;
            this.lblSub.Text = "Subject :";
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.lblPrelim);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblMname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvGradesInfo);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.txtPrelim);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "Grades";
            this.Size = new System.Drawing.Size(665, 561);
            this.Load += new System.EventHandler(this.Grades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradesInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.TextBox txtPrelim;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.DataGridView dgvGradesInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblPrelim;
        private System.Windows.Forms.Label lblSub;
    }
}
