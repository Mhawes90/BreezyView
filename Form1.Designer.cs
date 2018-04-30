namespace BreezyViewApartments
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ViewBox = new System.Windows.Forms.ComboBox();
            this.BedBox = new System.Windows.Forms.TextBox();
            this.BathBox = new System.Windows.Forms.TextBox();
            this.bedLabel = new System.Windows.Forms.Label();
            this.bathLabel = new System.Windows.Forms.Label();
            this.quoteButton = new System.Windows.Forms.Button();
            this.quoteTitle = new System.Windows.Forms.Label();
            this.quoteOutput = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1000, 171);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Breezy View Apartments";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 68);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Placeholder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(645, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Placeholder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ViewBox
            // 
            this.ViewBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBox.FormattingEnabled = true;
            this.ViewBox.Items.AddRange(new object[] {
            "Street View",
            "Lake View"});
            this.ViewBox.Location = new System.Drawing.Point(39, 595);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(224, 45);
            this.ViewBox.TabIndex = 3;
            this.ViewBox.Text = "Select View";
            // 
            // BedBox
            // 
            this.BedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedBox.Location = new System.Drawing.Point(379, 408);
            this.BedBox.Name = "BedBox";
            this.BedBox.Size = new System.Drawing.Size(100, 44);
            this.BedBox.TabIndex = 4;
            this.BedBox.TextChanged += new System.EventHandler(this.BedBox_TextChanged);
            // 
            // BathBox
            // 
            this.BathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BathBox.Location = new System.Drawing.Point(379, 494);
            this.BathBox.Name = "BathBox";
            this.BathBox.Size = new System.Drawing.Size(100, 44);
            this.BathBox.TabIndex = 5;
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedLabel.Location = new System.Drawing.Point(32, 415);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(341, 37);
            this.bedLabel.TabIndex = 6;
            this.bedLabel.Text = "Number of Bedrooms  ";
            this.bedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bathLabel
            // 
            this.bathLabel.AutoSize = true;
            this.bathLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bathLabel.Location = new System.Drawing.Point(32, 501);
            this.bathLabel.Name = "bathLabel";
            this.bathLabel.Size = new System.Drawing.Size(342, 37);
            this.bathLabel.TabIndex = 7;
            this.bathLabel.Text = "Number of Bathrooms ";
            // 
            // quoteButton
            // 
            this.quoteButton.AutoSize = true;
            this.quoteButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.quoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quoteButton.FlatAppearance.BorderSize = 4;
            this.quoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteButton.Location = new System.Drawing.Point(336, 585);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(182, 55);
            this.quoteButton.TabIndex = 8;
            this.quoteButton.Text = "Get Quote";
            this.quoteButton.UseVisualStyleBackColor = false;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // quoteTitle
            // 
            this.quoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTitle.Location = new System.Drawing.Point(179, 258);
            this.quoteTitle.Name = "quoteTitle";
            this.quoteTitle.Size = new System.Drawing.Size(598, 113);
            this.quoteTitle.TabIndex = 9;
            this.quoteTitle.Text = "Enter your desired apartments options to get a quote today!";
            this.quoteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteOutput
            // 
            this.quoteOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.quoteOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteOutput.Location = new System.Drawing.Point(569, 415);
            this.quoteOutput.Name = "quoteOutput";
            this.quoteOutput.Size = new System.Drawing.Size(331, 123);
            this.quoteOutput.TabIndex = 10;
            this.quoteOutput.Text = "Estimated Cost: ";
            this.quoteOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.quoteOutput);
            this.Controls.Add(this.quoteTitle);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.bathLabel);
            this.Controls.Add(this.bedLabel);
            this.Controls.Add(this.BathBox);
            this.Controls.Add(this.BedBox);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ViewBox;
        private System.Windows.Forms.TextBox BedBox;
        private System.Windows.Forms.TextBox BathBox;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.Label bathLabel;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Label quoteTitle;
        private System.Windows.Forms.Label quoteOutput;
    }
}

