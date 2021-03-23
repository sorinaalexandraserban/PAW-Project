namespace ProiectPAW_SerbanSorina
{
    partial class Form7_adauga_comanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_adauga_comanda));
            this.tbSumaCom = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbExceptii = new System.Windows.Forms.TextBox();
            this.labelObservatii = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumaCom
            // 
            this.tbSumaCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSumaCom.Location = new System.Drawing.Point(306, 143);
            this.tbSumaCom.Name = "tbSumaCom";
            this.tbSumaCom.Size = new System.Drawing.Size(202, 22);
            this.tbSumaCom.TabIndex = 0;
            this.tbSumaCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumaCom_KeyPress);
            // 
            // tbDiscount
            // 
            this.tbDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiscount.Location = new System.Drawing.Point(306, 197);
            this.tbDiscount.MaxLength = 2;
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(202, 22);
            this.tbDiscount.TabIndex = 3;
            this.tbDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumaCom_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(153, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma comenzii:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(142, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procent discount:";
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInfo.Location = new System.Drawing.Point(306, 263);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(202, 22);
            this.tbInfo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(171, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tip pizza:";
            // 
            // tbExceptii
            // 
            this.tbExceptii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExceptii.Location = new System.Drawing.Point(306, 333);
            this.tbExceptii.Name = "tbExceptii";
            this.tbExceptii.Size = new System.Drawing.Size(202, 22);
            this.tbExceptii.TabIndex = 19;
            this.tbExceptii.Visible = false;
            // 
            // labelObservatii
            // 
            this.labelObservatii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelObservatii.AutoSize = true;
            this.labelObservatii.BackColor = System.Drawing.Color.Transparent;
            this.labelObservatii.Location = new System.Drawing.Point(168, 333);
            this.labelObservatii.Name = "labelObservatii";
            this.labelObservatii.Size = new System.Drawing.Size(72, 17);
            this.labelObservatii.TabIndex = 21;
            this.labelObservatii.Text = "Observatii";
            this.labelObservatii.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(591, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Adauga comanda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form7_adauga_comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelObservatii);
            this.Controls.Add(this.tbExceptii);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbSumaCom);
            this.DoubleBuffered = true;
            this.Name = "Form7_adauga_comanda";
            this.Text = "Adauga comanda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_adauga_asigurare_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox tbSumaCom;
            private System.Windows.Forms.TextBox tbDiscount;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.TextBox tbInfo;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.TextBox tbExceptii;
            private System.Windows.Forms.Label labelObservatii;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.ErrorProvider errorProvider1;
        
    }
}
