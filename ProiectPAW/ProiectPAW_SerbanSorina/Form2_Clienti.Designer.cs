namespace ProiectPAW_SerbanSorina
{
    partial class Form2_Clienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Clienti));
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.veziComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVeziUtilizatori = new System.Windows.Forms.Button();
            this.btnAdaugaUtilizator = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informatiiContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setariContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new SearchUserControl.SearchUserControl();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClienti
            // 
            this.listViewClienti.AllowColumnReorder = true;
            this.listViewClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClienti.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.GridLines = true;
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(20, 85);
            this.listViewClienti.MultiSelect = false;
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.ShowGroups = false;
            this.listViewClienti.Size = new System.Drawing.Size(978, 492);
            this.listViewClienti.TabIndex = 0;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            this.listViewClienti.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewClienti_ItemDrag);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziComenziToolStripMenuItem,
            this.adaugaComandaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 52);
            // 
            // veziComenziToolStripMenuItem
            // 
            this.veziComenziToolStripMenuItem.Name = "veziComenziToolStripMenuItem";
            this.veziComenziToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.veziComenziToolStripMenuItem.Text = "Vezi comenzi";
            this.veziComenziToolStripMenuItem.Click += new System.EventHandler(this.veziComenziToolStripMenuItem_Click);
            // 
            // adaugaComandaToolStripMenuItem
            // 
            this.adaugaComandaToolStripMenuItem.Name = "adaugaComandaToolStripMenuItem";
            this.adaugaComandaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.adaugaComandaToolStripMenuItem.Text = "Adauga comanda";
            this.adaugaComandaToolStripMenuItem.Click += new System.EventHandler(this.adaugaComandaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1004, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga &client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVeziUtilizatori
            // 
            this.btnVeziUtilizatori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeziUtilizatori.BackColor = System.Drawing.Color.Transparent;
            this.btnVeziUtilizatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeziUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeziUtilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeziUtilizatori.Location = new System.Drawing.Point(1004, 258);
            this.btnVeziUtilizatori.Name = "btnVeziUtilizatori";
            this.btnVeziUtilizatori.Size = new System.Drawing.Size(271, 40);
            this.btnVeziUtilizatori.TabIndex = 3;
            this.btnVeziUtilizatori.Text = "Vezi &utilizatori";
            this.btnVeziUtilizatori.UseVisualStyleBackColor = false;
            this.btnVeziUtilizatori.Visible = false;
            this.btnVeziUtilizatori.Click += new System.EventHandler(this.btnVeziUtilizatori_Click);
            // 
            // btnAdaugaUtilizator
            // 
            this.btnAdaugaUtilizator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugaUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.btnAdaugaUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugaUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaUtilizator.Location = new System.Drawing.Point(1004, 314);
            this.btnAdaugaUtilizator.Name = "btnAdaugaUtilizator";
            this.btnAdaugaUtilizator.Size = new System.Drawing.Size(271, 40);
            this.btnAdaugaUtilizator.TabIndex = 4;
            this.btnAdaugaUtilizator.Text = "&Adauga utilizator";
            this.btnAdaugaUtilizator.UseVisualStyleBackColor = false;
            this.btnAdaugaUtilizator.Visible = false;
            this.btnAdaugaUtilizator.Click += new System.EventHandler(this.btnAdaugaUtilizator_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(1004, 151);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(271, 40);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "&Refresh list";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1118, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deconectare";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1062, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 153);
            this.panel1.TabIndex = 14;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista clienti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informatiiContToolStripMenuItem,
            this.setariContToolStripMenuItem,
            this.exportClientiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informatiiContToolStripMenuItem
            // 
            this.informatiiContToolStripMenuItem.Name = "informatiiContToolStripMenuItem";
            this.informatiiContToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.informatiiContToolStripMenuItem.Text = "&Informatii cont";
            this.informatiiContToolStripMenuItem.Click += new System.EventHandler(this.informatiiContToolStripMenuItem_Click);
            // 
            // setariContToolStripMenuItem
            // 
            this.setariContToolStripMenuItem.Name = "setariContToolStripMenuItem";
            this.setariContToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.setariContToolStripMenuItem.Text = "&Setari cont";
            this.setariContToolStripMenuItem.Click += new System.EventHandler(this.setariContToolStripMenuItem_Click);
            // 
            // exportClientiToolStripMenuItem
            // 
            this.exportClientiToolStripMenuItem.Name = "exportClientiToolStripMenuItem";
            this.exportClientiToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.exportClientiToolStripMenuItem.Text = "Export clienti";
            this.exportClientiToolStripMenuItem.Click += new System.EventHandler(this.exportClientiToolStripMenuItem_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Coloana = "adregcycgycgysa";
            this.search.Conn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
            this.search.JoinCol = null;
            this.search.Location = new System.Drawing.Point(613, 599);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(377, 34);
            this.search.Tabela1 = "clienti";
            this.search.Tabela2 = null;
            this.search.TabIndex = 18;
            // 
            // Form2_Clienti
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 645);
            this.Controls.Add(this.search);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.btnAdaugaUtilizator);
            this.Controls.Add(this.btnVeziUtilizatori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewClienti);
            this.DoubleBuffered = true;
            this.Name = "Form2_Clienti";
            this.Text = "Clienti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_Clienti_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVeziUtilizatori;
        private System.Windows.Forms.Button btnAdaugaUtilizator;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veziComenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaComandaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informatiiContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setariContToolStripMenuItem;
        private SearchUserControl.SearchUserControl search;
        private System.Windows.Forms.ToolStripMenuItem exportClientiToolStripMenuItem;
    }
}