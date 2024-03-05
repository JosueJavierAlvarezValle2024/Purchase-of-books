namespace Purchase_of_books
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttitle = new TextBox();
            txtauthor = new TextBox();
            txtcopies = new TextBox();
            txtcost = new TextBox();
            lbltitle = new Label();
            lblauthor = new Label();
            lblcopies = new Label();
            lblcost = new Label();
            lbltotalcost = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 87);
            label1.Name = "label1";
            label1.Size = new Size(92, 48);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 206);
            label2.Name = "label2";
            label2.Size = new Size(128, 48);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 330);
            label3.Name = "label3";
            label3.Size = new Size(133, 48);
            label3.TabIndex = 2;
            label3.Text = "Copies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 431);
            label4.Name = "label4";
            label4.Size = new Size(93, 48);
            label4.TabIndex = 3;
            label4.Text = "Cost";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(360, 87);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(232, 27);
            txttitle.TabIndex = 4;
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(360, 227);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(232, 27);
            txtauthor.TabIndex = 5;
            // 
            // txtcopies
            // 
            txtcopies.Location = new Point(360, 347);
            txtcopies.Name = "txtcopies";
            txtcopies.Size = new Size(232, 27);
            txtcopies.TabIndex = 6;
            // 
            // txtcost
            // 
            txtcost.Location = new Point(360, 452);
            txtcost.Name = "txtcost";
            txtcost.Size = new Size(232, 27);
            txtcost.TabIndex = 7;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(628, 70);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(41, 46);
            lbltitle.TabIndex = 8;
            lbltitle.Text = "...";
            // 
            // lblauthor
            // 
            lblauthor.AutoSize = true;
            lblauthor.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblauthor.Location = new Point(628, 210);
            lblauthor.Name = "lblauthor";
            lblauthor.Size = new Size(41, 46);
            lblauthor.TabIndex = 9;
            lblauthor.Text = "...";
            // 
            // lblcopies
            // 
            lblcopies.AutoSize = true;
            lblcopies.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcopies.Location = new Point(628, 347);
            lblcopies.Name = "lblcopies";
            lblcopies.Size = new Size(41, 46);
            lblcopies.TabIndex = 10;
            lblcopies.Text = "...";
            // 
            // lblcost
            // 
            lblcost.AutoSize = true;
            lblcost.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcost.Location = new Point(628, 435);
            lblcost.Name = "lblcost";
            lblcost.Size = new Size(41, 46);
            lblcost.TabIndex = 11;
            lblcost.Text = "...";
            // 
            // lbltotalcost
            // 
            lbltotalcost.AutoSize = true;
            lbltotalcost.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalcost.Location = new Point(628, 571);
            lbltotalcost.Name = "lbltotalcost";
            lbltotalcost.Size = new Size(41, 46);
            lbltotalcost.TabIndex = 12;
            lbltotalcost.Text = "...";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(106, 534);
            button1.Name = "button1";
            button1.Size = new Size(346, 97);
            button1.TabIndex = 13;
            button1.Text = "Buy's";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1061, 656);
            Controls.Add(button1);
            Controls.Add(lbltotalcost);
            Controls.Add(lblcost);
            Controls.Add(lblcopies);
            Controls.Add(lblauthor);
            Controls.Add(lbltitle);
            Controls.Add(txtcost);
            Controls.Add(txtcopies);
            Controls.Add(txtauthor);
            Controls.Add(txttitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttitle;
        private TextBox txtauthor;
        private TextBox txtcopies;
        private TextBox txtcost;
        private Label lbltitle;
        private Label lblauthor;
        private Label lblcopies;
        private Label lblcost;
        private Label lbltotalcost;
        private Button button1;
    }
}
