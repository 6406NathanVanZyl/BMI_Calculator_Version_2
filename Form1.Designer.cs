
namespace BMI_Calculator_Version_2
{
    partial class Form1
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
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(75, 49);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(152, 20);
            this.patientIDTextBox.TabIndex = 0;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.patientIDTextBox_TextChanged);
            this.patientIDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iDTextBox_Validate);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(75, 84);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(152, 20);
            this.weightTextBox.TabIndex = 1;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(75, 118);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(152, 20);
            this.heightTextBox.TabIndex = 2;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(75, 151);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(152, 20);
            this.statusTextBox.TabIndex = 3;
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(15, 200);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 4;
            this.calBtn.Text = "Calculate";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(96, 200);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "ClearData";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(177, 200);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "EXIT!";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(71, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(127, 20);
            this.title.TabIndex = 7;
            this.title.Text = "BMI Calculator";
            // 
            // patientID
            // 
            this.patientID.AutoSize = true;
            this.patientID.Location = new System.Drawing.Point(12, 52);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(57, 13);
            this.patientID.TabIndex = 8;
            this.patientID.Text = "Patient ID:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(12, 87);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(44, 13);
            this.weight.TabIndex = 9;
            this.weight.Text = "Weight:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(12, 121);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(41, 13);
            this.height.TabIndex = 10;
            this.height.Text = "Height:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 154);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 11;
            this.status.Text = "Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(15, 229);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(237, 44);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.patientIDTextBox);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label patientID;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button searchBtn;
    }
}

