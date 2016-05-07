namespace SeniorProject
{
    partial class main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navButton = new System.Windows.Forms.Button();
            this.navInput = new System.Windows.Forms.TextBox();
            this.navLabel = new System.Windows.Forms.Label();
            this.featureListBox = new System.Windows.Forms.ListBox();
            this.get_page = new System.Windows.Forms.Button();
            this.pan_up = new System.Windows.Forms.Button();
            this.pan_down = new System.Windows.Forms.Button();
            this.zoom_out = new System.Windows.Forms.Button();
            this.zoom_in = new System.Windows.Forms.Button();
            this.Accession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Organism = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Feature_key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.All_fields = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.search_help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.end5prime = new System.Windows.Forms.TextBox();
            this.end3prime = new System.Windows.Forms.TextBox();
            this.posStart = new System.Windows.Forms.TextBox();
            this.posEnd = new System.Windows.Forms.TextBox();
            this.searchResultsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.subTitleBot = new System.Windows.Forms.TextBox();
            this.subTitleTop = new System.Windows.Forms.TextBox();
            this.prv_src = new System.Windows.Forms.Button();
            this.prv_rna = new System.Windows.Forms.Button();
            this.abstractButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // navButton
            // 
            this.navButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navButton.BackColor = System.Drawing.SystemColors.Control;
            this.navButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.navButton.Location = new System.Drawing.Point(387, 78);
            this.navButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navButton.Name = "navButton";
            this.navButton.Size = new System.Drawing.Size(108, 28);
            this.navButton.TabIndex = 7;
            this.navButton.Text = "Go!";
            this.navButton.UseVisualStyleBackColor = false;
            this.navButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // navInput
            // 
            this.navInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navInput.Location = new System.Drawing.Point(126, 82);
            this.navInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navInput.MinimumSize = new System.Drawing.Size(200, 22);
            this.navInput.Name = "navInput";
            this.navInput.Size = new System.Drawing.Size(249, 22);
            this.navInput.TabIndex = 6;
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Location = new System.Drawing.Point(26, 84);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(96, 17);
            this.navLabel.TabIndex = 4;
            this.navLabel.Text = "Go to position";
            // 
            // featureListBox
            // 
            this.featureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featureListBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.featureListBox.FormattingEnabled = true;
            this.featureListBox.ItemHeight = 16;
            this.featureListBox.Location = new System.Drawing.Point(502, 76);
            this.featureListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.featureListBox.MinimumSize = new System.Drawing.Size(200, 241);
            this.featureListBox.Name = "featureListBox";
            this.featureListBox.Size = new System.Drawing.Size(200, 388);
            this.featureListBox.TabIndex = 12;
            this.featureListBox.DoubleClick += new System.EventHandler(this.featurelistbox_DoubleClick);
            this.featureListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.featurelistbox_KeyDown);
            // 
            // get_page
            // 
            this.get_page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.get_page.BackColor = System.Drawing.SystemColors.Control;
            this.get_page.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.get_page.Location = new System.Drawing.Point(4, 6);
            this.get_page.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.get_page.Name = "get_page";
            this.get_page.Size = new System.Drawing.Size(101, 40);
            this.get_page.TabIndex = 4;
            this.get_page.Text = "Search";
            this.get_page.UseVisualStyleBackColor = false;
            this.get_page.Click += new System.EventHandler(this.get_page_Click);
            // 
            // pan_up
            // 
            this.pan_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_up.BackColor = System.Drawing.SystemColors.Control;
            this.pan_up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pan_up.Location = new System.Drawing.Point(454, 112);
            this.pan_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_up.Name = "pan_up";
            this.pan_up.Size = new System.Drawing.Size(41, 40);
            this.pan_up.TabIndex = 8;
            this.pan_up.Text = "^";
            this.pan_up.UseVisualStyleBackColor = false;
            this.pan_up.Click += new System.EventHandler(this.pan_up_Click);
            // 
            // pan_down
            // 
            this.pan_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_down.BackColor = System.Drawing.SystemColors.Control;
            this.pan_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pan_down.Location = new System.Drawing.Point(454, 157);
            this.pan_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_down.Name = "pan_down";
            this.pan_down.Size = new System.Drawing.Size(41, 40);
            this.pan_down.TabIndex = 9;
            this.pan_down.Text = "v";
            this.pan_down.UseVisualStyleBackColor = false;
            this.pan_down.Click += new System.EventHandler(this.pan_down_Click);
            // 
            // zoom_out
            // 
            this.zoom_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoom_out.BackColor = System.Drawing.SystemColors.Control;
            this.zoom_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoom_out.Location = new System.Drawing.Point(454, 280);
            this.zoom_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoom_out.Name = "zoom_out";
            this.zoom_out.Size = new System.Drawing.Size(41, 40);
            this.zoom_out.TabIndex = 11;
            this.zoom_out.Text = "-";
            this.zoom_out.UseVisualStyleBackColor = false;
            this.zoom_out.Click += new System.EventHandler(this.zoom_out_Click);
            // 
            // zoom_in
            // 
            this.zoom_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoom_in.BackColor = System.Drawing.SystemColors.Control;
            this.zoom_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoom_in.Location = new System.Drawing.Point(454, 235);
            this.zoom_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoom_in.Name = "zoom_in";
            this.zoom_in.Size = new System.Drawing.Size(41, 40);
            this.zoom_in.TabIndex = 10;
            this.zoom_in.Text = "+";
            this.zoom_in.UseVisualStyleBackColor = false;
            this.zoom_in.Click += new System.EventHandler(this.zoom_in_Click);
            // 
            // Accession
            // 
            this.Accession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accession.Location = new System.Drawing.Point(3, 24);
            this.Accession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accession.Name = "Accession";
            this.Accession.Size = new System.Drawing.Size(90, 22);
            this.Accession.TabIndex = 0;
            this.Accession.Tag = "Accession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Accession";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Organism";
            // 
            // Organism
            // 
            this.Organism.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Organism.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Organism.Location = new System.Drawing.Point(3, 24);
            this.Organism.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Organism.Name = "Organism";
            this.Organism.Size = new System.Drawing.Size(90, 22);
            this.Organism.TabIndex = 1;
            this.Organism.Tag = "Organism";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Feature";
            // 
            // Feature_key
            // 
            this.Feature_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Feature_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Feature_key.Location = new System.Drawing.Point(3, 24);
            this.Feature_key.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Feature_key.Name = "Feature_key";
            this.Feature_key.Size = new System.Drawing.Size(90, 22);
            this.Feature_key.TabIndex = 2;
            this.Feature_key.Tag = "Feature_key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Key Words";
            // 
            // All_fields
            // 
            this.All_fields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.All_fields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.All_fields.Location = new System.Drawing.Point(3, 24);
            this.All_fields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.All_fields.Name = "All_fields";
            this.All_fields.Size = new System.Drawing.Size(90, 22);
            this.All_fields.TabIndex = 3;
            this.All_fields.Tag = "All_fields";
            // 
            // keyButton
            // 
            this.keyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keyButton.FlatAppearance.BorderSize = 0;
            this.keyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.keyButton.Location = new System.Drawing.Point(454, 545);
            this.keyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(43, 31);
            this.keyButton.TabIndex = 19;
            this.keyButton.Text = "key";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.key_button_Click);
            // 
            // search_help
            // 
            this.search_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_help.FlatAppearance.BorderSize = 0;
            this.search_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_help.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.search_help.Location = new System.Drawing.Point(111, 15);
            this.search_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_help.Name = "search_help";
            this.search_help.Size = new System.Drawing.Size(62, 31);
            this.search_help.TabIndex = 20;
            this.search_help.Text = "help?";
            this.search_help.UseVisualStyleBackColor = true;
            this.search_help.Click += new System.EventHandler(this.search_help_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 12);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(682, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 59);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Accession);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 53);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Organism);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(103, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 53);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Feature_key);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 53);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.All_fields);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(403, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 53);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.get_page);
            this.panel5.Controls.Add(this.search_help);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(503, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 53);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dropDown);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(303, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(94, 53);
            this.panel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Type";
            // 
            // dropDown
            // 
            this.dropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "RNA",
            "mRNA",
            "ncRNA",
            "rRNA",
            "scRNA",
            "snoRNA",
            "snRNA",
            "tRNA"});
            this.dropDown.DisplayMember = "RNA";
            this.dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Items.AddRange(new object[] {
            "RNA",
            "cRNA",
            "mRNA",
            "ncRNA",
            "rRNA",
            "scRNA",
            "snoRNA",
            "snRNA",
            "tRNA"});
            this.dropDown.Location = new System.Drawing.Point(4, 24);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(87, 24);
            this.dropDown.TabIndex = 0;
            this.dropDown.Tag = "Biomol";
            this.dropDown.ValueMember = "RNA";
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(29, 125);
            this.titleBox.MinimumSize = new System.Drawing.Size(100, 27);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(419, 27);
            this.titleBox.TabIndex = 23;
            this.titleBox.Text = "Title";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // end5prime
            // 
            this.end5prime.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.end5prime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.end5prime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end5prime.Location = new System.Drawing.Point(29, 213);
            this.end5prime.MinimumSize = new System.Drawing.Size(100, 27);
            this.end5prime.Name = "end5prime";
            this.end5prime.ReadOnly = true;
            this.end5prime.Size = new System.Drawing.Size(100, 27);
            this.end5prime.TabIndex = 24;
            this.end5prime.Text = "5\' end";
            // 
            // end3prime
            // 
            this.end3prime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.end3prime.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.end3prime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.end3prime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end3prime.Location = new System.Drawing.Point(19, 573);
            this.end3prime.MinimumSize = new System.Drawing.Size(100, 27);
            this.end3prime.Name = "end3prime";
            this.end3prime.ReadOnly = true;
            this.end3prime.Size = new System.Drawing.Size(100, 27);
            this.end3prime.TabIndex = 25;
            this.end3prime.Text = "3\' end";
            // 
            // posStart
            // 
            this.posStart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.posStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.posStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart.Location = new System.Drawing.Point(29, 235);
            this.posStart.MinimumSize = new System.Drawing.Size(100, 27);
            this.posStart.Name = "posStart";
            this.posStart.ReadOnly = true;
            this.posStart.Size = new System.Drawing.Size(100, 20);
            this.posStart.TabIndex = 26;
            this.posStart.Text = "start";
            // 
            // posEnd
            // 
            this.posEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.posEnd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.posEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.posEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posEnd.Location = new System.Drawing.Point(19, 549);
            this.posEnd.MinimumSize = new System.Drawing.Size(100, 27);
            this.posEnd.Name = "posEnd";
            this.posEnd.ReadOnly = true;
            this.posEnd.Size = new System.Drawing.Size(100, 20);
            this.posEnd.TabIndex = 27;
            this.posEnd.Text = "end";
            // 
            // searchResultsTable
            // 
            this.searchResultsTable.AllowUserToAddRows = false;
            this.searchResultsTable.AllowUserToDeleteRows = false;
            this.searchResultsTable.AllowUserToResizeColumns = false;
            this.searchResultsTable.AllowUserToResizeRows = false;
            this.searchResultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchResultsTable.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchResultsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsTable.ColumnHeadersVisible = false;
            this.searchResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchResultsTable.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchResultsTable.Location = new System.Drawing.Point(20, 76);
            this.searchResultsTable.MinimumSize = new System.Drawing.Size(682, 150);
            this.searchResultsTable.Name = "searchResultsTable";
            this.searchResultsTable.ReadOnly = true;
            this.searchResultsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResultsTable.RowHeadersVisible = false;
            this.searchResultsTable.RowTemplate.Height = 24;
            this.searchResultsTable.RowTemplate.ReadOnly = true;
            this.searchResultsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchResultsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.searchResultsTable.Size = new System.Drawing.Size(682, 507);
            this.searchResultsTable.TabIndex = 28;
            this.searchResultsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultsTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.TrackVisitedState = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column2.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.TrackVisitedState = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Column3.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.TrackVisitedState = false;
            // 
            // subTitleBot
            // 
            this.subTitleBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTitleBot.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.subTitleBot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subTitleBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleBot.Location = new System.Drawing.Point(29, 155);
            this.subTitleBot.MinimumSize = new System.Drawing.Size(100, 27);
            this.subTitleBot.Multiline = true;
            this.subTitleBot.Name = "subTitleBot";
            this.subTitleBot.ReadOnly = true;
            this.subTitleBot.Size = new System.Drawing.Size(419, 52);
            this.subTitleBot.TabIndex = 29;
            this.subTitleBot.Text = "full name\r\noften very long";
            this.subTitleBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subTitleTop
            // 
            this.subTitleTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTitleTop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.subTitleTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subTitleTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleTop.Location = new System.Drawing.Point(29, 112);
            this.subTitleTop.MinimumSize = new System.Drawing.Size(100, 0);
            this.subTitleTop.Name = "subTitleTop";
            this.subTitleTop.ReadOnly = true;
            this.subTitleTop.Size = new System.Drawing.Size(419, 15);
            this.subTitleTop.TabIndex = 30;
            this.subTitleTop.Text = "strandedness type";
            this.subTitleTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prv_src
            // 
            this.prv_src.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prv_src.BackColor = System.Drawing.SystemColors.Control;
            this.prv_src.FlatAppearance.BorderSize = 0;
            this.prv_src.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prv_src.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prv_src.Location = new System.Drawing.Point(503, 479);
            this.prv_src.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prv_src.Name = "prv_src";
            this.prv_src.Size = new System.Drawing.Size(91, 55);
            this.prv_src.TabIndex = 31;
            this.prv_src.Text = "Previous Search";
            this.prv_src.UseVisualStyleBackColor = false;
            this.prv_src.Click += new System.EventHandler(this.prv_src_Click);
            // 
            // prv_rna
            // 
            this.prv_rna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prv_rna.BackColor = System.Drawing.SystemColors.Control;
            this.prv_rna.FlatAppearance.BorderSize = 0;
            this.prv_rna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prv_rna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prv_rna.Location = new System.Drawing.Point(600, 479);
            this.prv_rna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prv_rna.Name = "prv_rna";
            this.prv_rna.Size = new System.Drawing.Size(96, 55);
            this.prv_rna.TabIndex = 32;
            this.prv_rna.Text = "Previous RNA";
            this.prv_rna.UseVisualStyleBackColor = false;
            this.prv_rna.Click += new System.EventHandler(this.prv_rna_Click);
            // 
            // abstractButton
            // 
            this.abstractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abstractButton.BackColor = System.Drawing.SystemColors.Control;
            this.abstractButton.FlatAppearance.BorderSize = 0;
            this.abstractButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.abstractButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.abstractButton.Location = new System.Drawing.Point(503, 538);
            this.abstractButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abstractButton.Name = "abstractButton";
            this.abstractButton.Size = new System.Drawing.Size(193, 45);
            this.abstractButton.TabIndex = 33;
            this.abstractButton.Text = "Relevant Abstract";
            this.abstractButton.UseVisualStyleBackColor = false;
            this.abstractButton.Click += new System.EventHandler(this.abstractButton_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(732, 612);
            this.Controls.Add(this.abstractButton);
            this.Controls.Add(this.prv_rna);
            this.Controls.Add(this.prv_src);
            this.Controls.Add(this.subTitleTop);
            this.Controls.Add(this.subTitleBot);
            this.Controls.Add(this.posEnd);
            this.Controls.Add(this.posStart);
            this.Controls.Add(this.end3prime);
            this.Controls.Add(this.end5prime);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.zoom_out);
            this.Controls.Add(this.zoom_in);
            this.Controls.Add(this.pan_down);
            this.Controls.Add(this.pan_up);
            this.Controls.Add(this.featureListBox);
            this.Controls.Add(this.navLabel);
            this.Controls.Add(this.navInput);
            this.Controls.Add(this.navButton);
            this.Controls.Add(this.searchResultsTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(750, 460);
            this.Name = "main_form";
            this.Text = "RNA Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button navButton;
        private System.Windows.Forms.TextBox navInput;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.ListBox featureListBox;
        private System.Windows.Forms.Button get_page;
        private System.Windows.Forms.Button pan_up;
        private System.Windows.Forms.Button pan_down;
        private System.Windows.Forms.Button zoom_out;
        private System.Windows.Forms.Button zoom_in;
        private System.Windows.Forms.TextBox Accession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Organism;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Feature_key;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox All_fields;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Button search_help;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox end5prime;
        private System.Windows.Forms.TextBox end3prime;
        private System.Windows.Forms.TextBox posStart;
        private System.Windows.Forms.TextBox posEnd;
        private System.Windows.Forms.DataGridView searchResultsTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.TextBox subTitleBot;
        private System.Windows.Forms.TextBox subTitleTop;
        private System.Windows.Forms.Button prv_src;
        private System.Windows.Forms.Button prv_rna;
        private System.Windows.Forms.Button abstractButton;
    }
}

