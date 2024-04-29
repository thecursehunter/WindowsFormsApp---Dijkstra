namespace Dijkstra
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
            this.AddLocationButton_Click = new System.Windows.Forms.Button();
            this.AddEdgeButton_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindShortestPathButton_Click = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLocationButton_Click
            // 
            this.AddLocationButton_Click.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddLocationButton_Click.Location = new System.Drawing.Point(3, 102);
            this.AddLocationButton_Click.Margin = new System.Windows.Forms.Padding(2);
            this.AddLocationButton_Click.Name = "AddLocationButton_Click";
            this.AddLocationButton_Click.Size = new System.Drawing.Size(187, 34);
            this.AddLocationButton_Click.TabIndex = 0;
            this.AddLocationButton_Click.Text = "Add Location";
            this.AddLocationButton_Click.UseVisualStyleBackColor = true;
            this.AddLocationButton_Click.Click += new System.EventHandler(this.AddLocationButton_Click_Click);
            // 
            // AddEdgeButton_Click
            // 
            this.AddEdgeButton_Click.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddEdgeButton_Click.Location = new System.Drawing.Point(3, 109);
            this.AddEdgeButton_Click.Margin = new System.Windows.Forms.Padding(2);
            this.AddEdgeButton_Click.Name = "AddEdgeButton_Click";
            this.AddEdgeButton_Click.Size = new System.Drawing.Size(187, 32);
            this.AddEdgeButton_Click.TabIndex = 1;
            this.AddEdgeButton_Click.Text = "Add Edge";
            this.AddEdgeButton_Click.UseVisualStyleBackColor = true;
            this.AddEdgeButton_Click.Click += new System.EventHandler(this.AddEdgeButton_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationTextBox.Location = new System.Drawing.Point(72, 20);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(116, 20);
            this.locationTextBox.TabIndex = 5;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.xTextBox.Location = new System.Drawing.Point(72, 44);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(116, 20);
            this.xTextBox.TabIndex = 6;
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.yTextBox.Location = new System.Drawing.Point(72, 68);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(116, 20);
            this.yTextBox.TabIndex = 7;
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapPictureBox.Location = new System.Drawing.Point(243, 80);
            this.mapPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(345, 345);
            this.mapPictureBox.TabIndex = 8;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            // 
            // startComboBox
            // 
            this.startComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(60, 28);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(116, 21);
            this.startComboBox.TabIndex = 9;
            this.startComboBox.SelectedIndexChanged += new System.EventHandler(this.startComboBox_SelectedIndexChanged);
            // 
            // endComboBox
            // 
            this.endComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Location = new System.Drawing.Point(60, 72);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(116, 21);
            this.endComboBox.TabIndex = 10;
            this.endComboBox.SelectedIndexChanged += new System.EventHandler(this.endComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "End:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.AddLocationButton_Click);
            this.groupBox1.Controls.Add(this.yTextBox);
            this.groupBox1.Controls.Add(this.xTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startComboBox);
            this.groupBox2.Controls.Add(this.AddEdgeButton_Click);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.endComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edges";
            // 
            // FindShortestPathButton_Click
            // 
            this.FindShortestPathButton_Click.AutoSize = true;
            this.FindShortestPathButton_Click.Location = new System.Drawing.Point(243, 430);
            this.FindShortestPathButton_Click.Name = "FindShortestPathButton_Click";
            this.FindShortestPathButton_Click.Size = new System.Drawing.Size(345, 54);
            this.FindShortestPathButton_Click.TabIndex = 0;
            this.FindShortestPathButton_Click.Text = "Find Shortest Path";
            this.FindShortestPathButton_Click.UseVisualStyleBackColor = true;
            this.FindShortestPathButton_Click.Click += new System.EventHandler(this.FindShortestPathButton_Click_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(573, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm đường đi ngắn nhất giữa các địa điểm trong thành phố";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(594, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lưu Ý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "X < 330";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y < 330";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FindShortestPathButton_Click);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mapPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLocationButton_Click;
        private System.Windows.Forms.Button AddEdgeButton_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FindShortestPathButton_Click;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

