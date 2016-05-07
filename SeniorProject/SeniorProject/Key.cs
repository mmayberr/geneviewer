using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class Key : Form
    {
        private TabControl ntTabs;
        private TabPage AdenineTab;
        private Label dotViewA;
        private Label baseViewA;
        private Label molViewA;
        private Label dotViewADot;
        private Label baseViewAChar;
        private PictureBox molViewAImg;
        private TabPage CytosineTab;
        private Label dotViewCDot;
        private Label baseViewCChar;
        private PictureBox molViewCImg;
        private TabPage GuanineTab;
        private Label dotViewGDot;
        private Label baseViewGChar;
        private PictureBox molViewGImg;
        private TabPage ThymineTab;
        private Label dotViewTDot;
        private Label baseViewTChar;
        private PictureBox molViewTImg;
        private TabPage UracilTab;
        private Label dotViewUDot;
        private Label baseViewUChar;
        private PictureBox molViewUImg;
        private TabPage UnknownTab;
        private Label DotViewVarDot;
        private Label baseViewVarChar;
        private Label dotViewC;
        private Label baseViewC;
        private Label molViewC;
        private Label dotViewG;
        private Label baseViewG;
        private Label molViewG;
        private Label dotViewT;
        private Label baseViewT;
        private Label molViewT;
        private Label dotViewU;
        private Label baseViewU;
        private Label molViewU;
        private Label dotViewVar;
        private Label baseViewVar;
        private Label molViewVar;
        private Label baseViewVarOtherLabel;
        private TextBox baseViewVarOthersList;
        private TabPage OverviewTab;
        private TextBox overviewText;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel tablePanelA;
        private Label tableLabelA;
        private Panel tablePanelC;
        private Label tableLabelC;
        private Panel tablePanelG;
        private Label tableLabelG;
        private Panel tablePanelU;
        private Label tableLabelU;
        private Panel tablePanelVar;
        private Label tableLabelVar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox molViewVarImg;

        public Key()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key));
            this.ntTabs = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelA = new System.Windows.Forms.Panel();
            this.tableLabelA = new System.Windows.Forms.Label();
            this.tablePanelC = new System.Windows.Forms.Panel();
            this.tableLabelC = new System.Windows.Forms.Label();
            this.tablePanelG = new System.Windows.Forms.Panel();
            this.tableLabelG = new System.Windows.Forms.Label();
            this.tablePanelU = new System.Windows.Forms.Panel();
            this.tableLabelU = new System.Windows.Forms.Label();
            this.tablePanelVar = new System.Windows.Forms.Panel();
            this.tableLabelVar = new System.Windows.Forms.Label();
            this.overviewText = new System.Windows.Forms.TextBox();
            this.AdenineTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dotViewA = new System.Windows.Forms.Label();
            this.baseViewA = new System.Windows.Forms.Label();
            this.molViewA = new System.Windows.Forms.Label();
            this.dotViewADot = new System.Windows.Forms.Label();
            this.baseViewAChar = new System.Windows.Forms.Label();
            this.molViewAImg = new System.Windows.Forms.PictureBox();
            this.CytosineTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dotViewC = new System.Windows.Forms.Label();
            this.baseViewC = new System.Windows.Forms.Label();
            this.molViewC = new System.Windows.Forms.Label();
            this.dotViewCDot = new System.Windows.Forms.Label();
            this.baseViewCChar = new System.Windows.Forms.Label();
            this.molViewCImg = new System.Windows.Forms.PictureBox();
            this.GuanineTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dotViewG = new System.Windows.Forms.Label();
            this.baseViewG = new System.Windows.Forms.Label();
            this.molViewG = new System.Windows.Forms.Label();
            this.dotViewGDot = new System.Windows.Forms.Label();
            this.baseViewGChar = new System.Windows.Forms.Label();
            this.molViewGImg = new System.Windows.Forms.PictureBox();
            this.ThymineTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dotViewT = new System.Windows.Forms.Label();
            this.baseViewT = new System.Windows.Forms.Label();
            this.molViewT = new System.Windows.Forms.Label();
            this.dotViewTDot = new System.Windows.Forms.Label();
            this.baseViewTChar = new System.Windows.Forms.Label();
            this.molViewTImg = new System.Windows.Forms.PictureBox();
            this.UracilTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dotViewU = new System.Windows.Forms.Label();
            this.baseViewU = new System.Windows.Forms.Label();
            this.molViewU = new System.Windows.Forms.Label();
            this.dotViewUDot = new System.Windows.Forms.Label();
            this.baseViewUChar = new System.Windows.Forms.Label();
            this.molViewUImg = new System.Windows.Forms.PictureBox();
            this.UnknownTab = new System.Windows.Forms.TabPage();
            this.baseViewVarOtherLabel = new System.Windows.Forms.Label();
            this.baseViewVarOthersList = new System.Windows.Forms.TextBox();
            this.dotViewVar = new System.Windows.Forms.Label();
            this.baseViewVar = new System.Windows.Forms.Label();
            this.molViewVar = new System.Windows.Forms.Label();
            this.DotViewVarDot = new System.Windows.Forms.Label();
            this.baseViewVarChar = new System.Windows.Forms.Label();
            this.molViewVarImg = new System.Windows.Forms.PictureBox();
            this.ntTabs.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tablePanelA.SuspendLayout();
            this.tablePanelC.SuspendLayout();
            this.tablePanelG.SuspendLayout();
            this.tablePanelU.SuspendLayout();
            this.tablePanelVar.SuspendLayout();
            this.AdenineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewAImg)).BeginInit();
            this.CytosineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewCImg)).BeginInit();
            this.GuanineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewGImg)).BeginInit();
            this.ThymineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewTImg)).BeginInit();
            this.UracilTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewUImg)).BeginInit();
            this.UnknownTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewVarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ntTabs
            // 
            this.ntTabs.Controls.Add(this.OverviewTab);
            this.ntTabs.Controls.Add(this.AdenineTab);
            this.ntTabs.Controls.Add(this.CytosineTab);
            this.ntTabs.Controls.Add(this.GuanineTab);
            this.ntTabs.Controls.Add(this.ThymineTab);
            this.ntTabs.Controls.Add(this.UracilTab);
            this.ntTabs.Controls.Add(this.UnknownTab);
            this.ntTabs.Location = new System.Drawing.Point(0, 0);
            this.ntTabs.Name = "ntTabs";
            this.ntTabs.SelectedIndex = 0;
            this.ntTabs.Size = new System.Drawing.Size(582, 310);
            this.ntTabs.TabIndex = 28;
            this.ntTabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OverviewTab.Controls.Add(this.tableLayoutPanel1);
            this.OverviewTab.Controls.Add(this.overviewText);
            this.OverviewTab.Location = new System.Drawing.Point(4, 25);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Size = new System.Drawing.Size(574, 281);
            this.OverviewTab.TabIndex = 6;
            this.OverviewTab.Text = "Overview";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tablePanelA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablePanelC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablePanelG, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablePanelU, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablePanelVar, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 68);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // tablePanelA
            // 
            this.tablePanelA.BackColor = System.Drawing.Color.Green;
            this.tablePanelA.Controls.Add(this.tableLabelA);
            this.tablePanelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelA.Location = new System.Drawing.Point(3, 3);
            this.tablePanelA.Name = "tablePanelA";
            this.tablePanelA.Size = new System.Drawing.Size(100, 62);
            this.tablePanelA.TabIndex = 0;
            // 
            // tableLabelA
            // 
            this.tableLabelA.AutoSize = true;
            this.tableLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabelA.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLabelA.Location = new System.Drawing.Point(12, 20);
            this.tableLabelA.Name = "tableLabelA";
            this.tableLabelA.Size = new System.Drawing.Size(76, 20);
            this.tableLabelA.TabIndex = 0;
            this.tableLabelA.Text = "Adenine";
            // 
            // tablePanelC
            // 
            this.tablePanelC.BackColor = System.Drawing.Color.Red;
            this.tablePanelC.Controls.Add(this.tableLabelC);
            this.tablePanelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelC.Location = new System.Drawing.Point(109, 3);
            this.tablePanelC.Name = "tablePanelC";
            this.tablePanelC.Size = new System.Drawing.Size(100, 62);
            this.tablePanelC.TabIndex = 1;
            // 
            // tableLabelC
            // 
            this.tableLabelC.AutoSize = true;
            this.tableLabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabelC.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLabelC.Location = new System.Drawing.Point(9, 20);
            this.tableLabelC.Name = "tableLabelC";
            this.tableLabelC.Size = new System.Drawing.Size(82, 20);
            this.tableLabelC.TabIndex = 1;
            this.tableLabelC.Text = "Cytosine";
            // 
            // tablePanelG
            // 
            this.tablePanelG.BackColor = System.Drawing.Color.Blue;
            this.tablePanelG.Controls.Add(this.tableLabelG);
            this.tablePanelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelG.Location = new System.Drawing.Point(215, 3);
            this.tablePanelG.Name = "tablePanelG";
            this.tablePanelG.Size = new System.Drawing.Size(100, 62);
            this.tablePanelG.TabIndex = 2;
            // 
            // tableLabelG
            // 
            this.tableLabelG.AutoSize = true;
            this.tableLabelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabelG.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLabelG.Location = new System.Drawing.Point(11, 20);
            this.tableLabelG.Name = "tableLabelG";
            this.tableLabelG.Size = new System.Drawing.Size(78, 20);
            this.tableLabelG.TabIndex = 2;
            this.tableLabelG.Text = "Guanine";
            // 
            // tablePanelU
            // 
            this.tablePanelU.BackColor = System.Drawing.Color.Purple;
            this.tablePanelU.Controls.Add(this.tableLabelU);
            this.tablePanelU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelU.Location = new System.Drawing.Point(321, 3);
            this.tablePanelU.Name = "tablePanelU";
            this.tablePanelU.Size = new System.Drawing.Size(100, 62);
            this.tablePanelU.TabIndex = 3;
            // 
            // tableLabelU
            // 
            this.tableLabelU.AutoSize = true;
            this.tableLabelU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabelU.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLabelU.Location = new System.Drawing.Point(21, 20);
            this.tableLabelU.Name = "tableLabelU";
            this.tableLabelU.Size = new System.Drawing.Size(59, 20);
            this.tableLabelU.TabIndex = 3;
            this.tableLabelU.Text = "Uracil";
            this.tableLabelU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablePanelVar
            // 
            this.tablePanelVar.BackColor = System.Drawing.Color.Black;
            this.tablePanelVar.Controls.Add(this.tableLabelVar);
            this.tablePanelVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelVar.Location = new System.Drawing.Point(427, 3);
            this.tablePanelVar.Name = "tablePanelVar";
            this.tablePanelVar.Size = new System.Drawing.Size(103, 62);
            this.tablePanelVar.TabIndex = 4;
            // 
            // tableLabelVar
            // 
            this.tableLabelVar.AutoSize = true;
            this.tableLabelVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabelVar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLabelVar.Location = new System.Drawing.Point(3, 11);
            this.tableLabelVar.Name = "tableLabelVar";
            this.tableLabelVar.Size = new System.Drawing.Size(96, 40);
            this.tableLabelVar.TabIndex = 4;
            this.tableLabelVar.Text = "Variable / \r\nUnknown";
            this.tableLabelVar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // overviewText
            // 
            this.overviewText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.overviewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overviewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewText.Location = new System.Drawing.Point(18, 15);
            this.overviewText.Multiline = true;
            this.overviewText.Name = "overviewText";
            this.overviewText.ReadOnly = true;
            this.overviewText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.overviewText.Size = new System.Drawing.Size(533, 184);
            this.overviewText.TabIndex = 39;
            this.overviewText.Text = resources.GetString("overviewText.Text");
            // 
            // AdenineTab
            // 
            this.AdenineTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AdenineTab.Controls.Add(this.label6);
            this.AdenineTab.Controls.Add(this.dotViewA);
            this.AdenineTab.Controls.Add(this.baseViewA);
            this.AdenineTab.Controls.Add(this.molViewA);
            this.AdenineTab.Controls.Add(this.dotViewADot);
            this.AdenineTab.Controls.Add(this.baseViewAChar);
            this.AdenineTab.Controls.Add(this.molViewAImg);
            this.AdenineTab.Location = new System.Drawing.Point(4, 25);
            this.AdenineTab.Name = "AdenineTab";
            this.AdenineTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdenineTab.Size = new System.Drawing.Size(574, 281);
            this.AdenineTab.TabIndex = 0;
            this.AdenineTab.Text = "Adenine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 190);
            this.label6.MinimumSize = new System.Drawing.Size(250, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 34);
            this.label6.TabIndex = 40;
            this.label6.Text = "Pairs with Thymine (in DNA)\r\nor Uracil (in RNA)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dotViewA
            // 
            this.dotViewA.AutoSize = true;
            this.dotViewA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewA.Location = new System.Drawing.Point(425, 44);
            this.dotViewA.Name = "dotViewA";
            this.dotViewA.Size = new System.Drawing.Size(90, 25);
            this.dotViewA.TabIndex = 28;
            this.dotViewA.Text = "Dot View";
            // 
            // baseViewA
            // 
            this.baseViewA.AutoSize = true;
            this.baseViewA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewA.Location = new System.Drawing.Point(265, 44);
            this.baseViewA.Name = "baseViewA";
            this.baseViewA.Size = new System.Drawing.Size(105, 25);
            this.baseViewA.TabIndex = 27;
            this.baseViewA.Text = "Base View";
            // 
            // molViewA
            // 
            this.molViewA.AutoSize = true;
            this.molViewA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewA.Location = new System.Drawing.Point(51, 44);
            this.molViewA.Name = "molViewA";
            this.molViewA.Size = new System.Drawing.Size(145, 25);
            this.molViewA.TabIndex = 26;
            this.molViewA.Text = "Molecular View";
            // 
            // dotViewADot
            // 
            this.dotViewADot.AutoSize = true;
            this.dotViewADot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewADot.ForeColor = System.Drawing.Color.Green;
            this.dotViewADot.Location = new System.Drawing.Point(450, 110);
            this.dotViewADot.Name = "dotViewADot";
            this.dotViewADot.Size = new System.Drawing.Size(31, 46);
            this.dotViewADot.TabIndex = 20;
            this.dotViewADot.Text = "•";
            // 
            // baseViewAChar
            // 
            this.baseViewAChar.AutoSize = true;
            this.baseViewAChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewAChar.ForeColor = System.Drawing.Color.Green;
            this.baseViewAChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewAChar.Name = "baseViewAChar";
            this.baseViewAChar.Size = new System.Drawing.Size(48, 46);
            this.baseViewAChar.TabIndex = 8;
            this.baseViewAChar.Text = "A";
            // 
            // molViewAImg
            // 
            this.molViewAImg.Image = global::SeniorProject.Properties.Resources.adenine;
            this.molViewAImg.Location = new System.Drawing.Point(25, 90);
            this.molViewAImg.Name = "molViewAImg";
            this.molViewAImg.Size = new System.Drawing.Size(200, 150);
            this.molViewAImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewAImg.TabIndex = 2;
            this.molViewAImg.TabStop = false;
            // 
            // CytosineTab
            // 
            this.CytosineTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CytosineTab.Controls.Add(this.label7);
            this.CytosineTab.Controls.Add(this.dotViewC);
            this.CytosineTab.Controls.Add(this.baseViewC);
            this.CytosineTab.Controls.Add(this.molViewC);
            this.CytosineTab.Controls.Add(this.dotViewCDot);
            this.CytosineTab.Controls.Add(this.baseViewCChar);
            this.CytosineTab.Controls.Add(this.molViewCImg);
            this.CytosineTab.Location = new System.Drawing.Point(4, 25);
            this.CytosineTab.Name = "CytosineTab";
            this.CytosineTab.Padding = new System.Windows.Forms.Padding(3);
            this.CytosineTab.Size = new System.Drawing.Size(574, 281);
            this.CytosineTab.TabIndex = 1;
            this.CytosineTab.Text = "Cytosine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 190);
            this.label7.MinimumSize = new System.Drawing.Size(250, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Pairs with Guanine";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dotViewC
            // 
            this.dotViewC.AutoSize = true;
            this.dotViewC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewC.Location = new System.Drawing.Point(425, 44);
            this.dotViewC.Name = "dotViewC";
            this.dotViewC.Size = new System.Drawing.Size(90, 25);
            this.dotViewC.TabIndex = 31;
            this.dotViewC.Text = "Dot View";
            // 
            // baseViewC
            // 
            this.baseViewC.AutoSize = true;
            this.baseViewC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewC.Location = new System.Drawing.Point(265, 44);
            this.baseViewC.Name = "baseViewC";
            this.baseViewC.Size = new System.Drawing.Size(105, 25);
            this.baseViewC.TabIndex = 30;
            this.baseViewC.Text = "Base View";
            // 
            // molViewC
            // 
            this.molViewC.AutoSize = true;
            this.molViewC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewC.Location = new System.Drawing.Point(51, 44);
            this.molViewC.Name = "molViewC";
            this.molViewC.Size = new System.Drawing.Size(145, 25);
            this.molViewC.TabIndex = 29;
            this.molViewC.Text = "Molecular View";
            // 
            // dotViewCDot
            // 
            this.dotViewCDot.AutoSize = true;
            this.dotViewCDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewCDot.ForeColor = System.Drawing.Color.Red;
            this.dotViewCDot.Location = new System.Drawing.Point(450, 110);
            this.dotViewCDot.Name = "dotViewCDot";
            this.dotViewCDot.Size = new System.Drawing.Size(31, 46);
            this.dotViewCDot.TabIndex = 21;
            this.dotViewCDot.Text = "•";
            // 
            // baseViewCChar
            // 
            this.baseViewCChar.AutoSize = true;
            this.baseViewCChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewCChar.ForeColor = System.Drawing.Color.Red;
            this.baseViewCChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewCChar.Name = "baseViewCChar";
            this.baseViewCChar.Size = new System.Drawing.Size(50, 46);
            this.baseViewCChar.TabIndex = 9;
            this.baseViewCChar.Text = "C";
            // 
            // molViewCImg
            // 
            this.molViewCImg.Image = global::SeniorProject.Properties.Resources.cytosine;
            this.molViewCImg.Location = new System.Drawing.Point(25, 90);
            this.molViewCImg.Name = "molViewCImg";
            this.molViewCImg.Size = new System.Drawing.Size(200, 150);
            this.molViewCImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewCImg.TabIndex = 3;
            this.molViewCImg.TabStop = false;
            // 
            // GuanineTab
            // 
            this.GuanineTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GuanineTab.Controls.Add(this.label8);
            this.GuanineTab.Controls.Add(this.dotViewG);
            this.GuanineTab.Controls.Add(this.baseViewG);
            this.GuanineTab.Controls.Add(this.molViewG);
            this.GuanineTab.Controls.Add(this.dotViewGDot);
            this.GuanineTab.Controls.Add(this.baseViewGChar);
            this.GuanineTab.Controls.Add(this.molViewGImg);
            this.GuanineTab.Location = new System.Drawing.Point(4, 25);
            this.GuanineTab.Name = "GuanineTab";
            this.GuanineTab.Size = new System.Drawing.Size(574, 281);
            this.GuanineTab.TabIndex = 2;
            this.GuanineTab.Text = "Guanine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 190);
            this.label8.MinimumSize = new System.Drawing.Size(250, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Pairs with Cytosine";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dotViewG
            // 
            this.dotViewG.AutoSize = true;
            this.dotViewG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewG.Location = new System.Drawing.Point(425, 44);
            this.dotViewG.Name = "dotViewG";
            this.dotViewG.Size = new System.Drawing.Size(90, 25);
            this.dotViewG.TabIndex = 34;
            this.dotViewG.Text = "Dot View";
            // 
            // baseViewG
            // 
            this.baseViewG.AutoSize = true;
            this.baseViewG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewG.Location = new System.Drawing.Point(265, 44);
            this.baseViewG.Name = "baseViewG";
            this.baseViewG.Size = new System.Drawing.Size(105, 25);
            this.baseViewG.TabIndex = 33;
            this.baseViewG.Text = "Base View";
            // 
            // molViewG
            // 
            this.molViewG.AutoSize = true;
            this.molViewG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewG.Location = new System.Drawing.Point(51, 44);
            this.molViewG.Name = "molViewG";
            this.molViewG.Size = new System.Drawing.Size(145, 25);
            this.molViewG.TabIndex = 32;
            this.molViewG.Text = "Molecular View";
            // 
            // dotViewGDot
            // 
            this.dotViewGDot.AutoSize = true;
            this.dotViewGDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewGDot.ForeColor = System.Drawing.Color.Blue;
            this.dotViewGDot.Location = new System.Drawing.Point(450, 110);
            this.dotViewGDot.Name = "dotViewGDot";
            this.dotViewGDot.Size = new System.Drawing.Size(31, 46);
            this.dotViewGDot.TabIndex = 22;
            this.dotViewGDot.Text = "•";
            // 
            // baseViewGChar
            // 
            this.baseViewGChar.AutoSize = true;
            this.baseViewGChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewGChar.ForeColor = System.Drawing.Color.Blue;
            this.baseViewGChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewGChar.Name = "baseViewGChar";
            this.baseViewGChar.Size = new System.Drawing.Size(52, 46);
            this.baseViewGChar.TabIndex = 10;
            this.baseViewGChar.Text = "G";
            // 
            // molViewGImg
            // 
            this.molViewGImg.Image = global::SeniorProject.Properties.Resources.guanine;
            this.molViewGImg.Location = new System.Drawing.Point(25, 90);
            this.molViewGImg.Name = "molViewGImg";
            this.molViewGImg.Size = new System.Drawing.Size(200, 150);
            this.molViewGImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewGImg.TabIndex = 4;
            this.molViewGImg.TabStop = false;
            // 
            // ThymineTab
            // 
            this.ThymineTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ThymineTab.Controls.Add(this.label9);
            this.ThymineTab.Controls.Add(this.dotViewT);
            this.ThymineTab.Controls.Add(this.baseViewT);
            this.ThymineTab.Controls.Add(this.molViewT);
            this.ThymineTab.Controls.Add(this.dotViewTDot);
            this.ThymineTab.Controls.Add(this.baseViewTChar);
            this.ThymineTab.Controls.Add(this.molViewTImg);
            this.ThymineTab.Location = new System.Drawing.Point(4, 25);
            this.ThymineTab.Name = "ThymineTab";
            this.ThymineTab.Size = new System.Drawing.Size(574, 281);
            this.ThymineTab.TabIndex = 3;
            this.ThymineTab.Text = "Thymine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 190);
            this.label9.MinimumSize = new System.Drawing.Size(250, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Pairs with Adenine (in DNA)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dotViewT
            // 
            this.dotViewT.AutoSize = true;
            this.dotViewT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewT.Location = new System.Drawing.Point(425, 44);
            this.dotViewT.Name = "dotViewT";
            this.dotViewT.Size = new System.Drawing.Size(90, 25);
            this.dotViewT.TabIndex = 37;
            this.dotViewT.Text = "Dot View";
            // 
            // baseViewT
            // 
            this.baseViewT.AutoSize = true;
            this.baseViewT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewT.Location = new System.Drawing.Point(265, 44);
            this.baseViewT.Name = "baseViewT";
            this.baseViewT.Size = new System.Drawing.Size(105, 25);
            this.baseViewT.TabIndex = 36;
            this.baseViewT.Text = "Base View";
            // 
            // molViewT
            // 
            this.molViewT.AutoSize = true;
            this.molViewT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewT.Location = new System.Drawing.Point(51, 44);
            this.molViewT.Name = "molViewT";
            this.molViewT.Size = new System.Drawing.Size(145, 25);
            this.molViewT.TabIndex = 35;
            this.molViewT.Text = "Molecular View";
            // 
            // dotViewTDot
            // 
            this.dotViewTDot.AutoSize = true;
            this.dotViewTDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewTDot.ForeColor = System.Drawing.Color.Purple;
            this.dotViewTDot.Location = new System.Drawing.Point(450, 110);
            this.dotViewTDot.Name = "dotViewTDot";
            this.dotViewTDot.Size = new System.Drawing.Size(31, 46);
            this.dotViewTDot.TabIndex = 23;
            this.dotViewTDot.Text = "•";
            // 
            // baseViewTChar
            // 
            this.baseViewTChar.AutoSize = true;
            this.baseViewTChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewTChar.ForeColor = System.Drawing.Color.Purple;
            this.baseViewTChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewTChar.Name = "baseViewTChar";
            this.baseViewTChar.Size = new System.Drawing.Size(45, 46);
            this.baseViewTChar.TabIndex = 11;
            this.baseViewTChar.Text = "T";
            // 
            // molViewTImg
            // 
            this.molViewTImg.Image = global::SeniorProject.Properties.Resources.thymine;
            this.molViewTImg.Location = new System.Drawing.Point(25, 90);
            this.molViewTImg.Name = "molViewTImg";
            this.molViewTImg.Size = new System.Drawing.Size(200, 150);
            this.molViewTImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewTImg.TabIndex = 5;
            this.molViewTImg.TabStop = false;
            // 
            // UracilTab
            // 
            this.UracilTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UracilTab.Controls.Add(this.label10);
            this.UracilTab.Controls.Add(this.dotViewU);
            this.UracilTab.Controls.Add(this.baseViewU);
            this.UracilTab.Controls.Add(this.molViewU);
            this.UracilTab.Controls.Add(this.dotViewUDot);
            this.UracilTab.Controls.Add(this.baseViewUChar);
            this.UracilTab.Controls.Add(this.molViewUImg);
            this.UracilTab.Location = new System.Drawing.Point(4, 25);
            this.UracilTab.Name = "UracilTab";
            this.UracilTab.Size = new System.Drawing.Size(574, 281);
            this.UracilTab.TabIndex = 4;
            this.UracilTab.Text = "Uracil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 190);
            this.label10.MinimumSize = new System.Drawing.Size(250, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Pairs with Adenine (in RNA)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dotViewU
            // 
            this.dotViewU.AutoSize = true;
            this.dotViewU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewU.Location = new System.Drawing.Point(425, 44);
            this.dotViewU.Name = "dotViewU";
            this.dotViewU.Size = new System.Drawing.Size(90, 25);
            this.dotViewU.TabIndex = 37;
            this.dotViewU.Text = "Dot View";
            // 
            // baseViewU
            // 
            this.baseViewU.AutoSize = true;
            this.baseViewU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewU.Location = new System.Drawing.Point(265, 44);
            this.baseViewU.Name = "baseViewU";
            this.baseViewU.Size = new System.Drawing.Size(105, 25);
            this.baseViewU.TabIndex = 36;
            this.baseViewU.Text = "Base View";
            // 
            // molViewU
            // 
            this.molViewU.AutoSize = true;
            this.molViewU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewU.Location = new System.Drawing.Point(51, 44);
            this.molViewU.Name = "molViewU";
            this.molViewU.Size = new System.Drawing.Size(145, 25);
            this.molViewU.TabIndex = 35;
            this.molViewU.Text = "Molecular View";
            // 
            // dotViewUDot
            // 
            this.dotViewUDot.AutoSize = true;
            this.dotViewUDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewUDot.ForeColor = System.Drawing.Color.Purple;
            this.dotViewUDot.Location = new System.Drawing.Point(450, 110);
            this.dotViewUDot.Name = "dotViewUDot";
            this.dotViewUDot.Size = new System.Drawing.Size(31, 46);
            this.dotViewUDot.TabIndex = 24;
            this.dotViewUDot.Text = "•";
            // 
            // baseViewUChar
            // 
            this.baseViewUChar.AutoSize = true;
            this.baseViewUChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewUChar.ForeColor = System.Drawing.Color.Purple;
            this.baseViewUChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewUChar.Name = "baseViewUChar";
            this.baseViewUChar.Size = new System.Drawing.Size(50, 46);
            this.baseViewUChar.TabIndex = 12;
            this.baseViewUChar.Text = "U";
            // 
            // molViewUImg
            // 
            this.molViewUImg.Image = global::SeniorProject.Properties.Resources.uracil;
            this.molViewUImg.Location = new System.Drawing.Point(25, 90);
            this.molViewUImg.Name = "molViewUImg";
            this.molViewUImg.Size = new System.Drawing.Size(200, 150);
            this.molViewUImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewUImg.TabIndex = 6;
            this.molViewUImg.TabStop = false;
            // 
            // UnknownTab
            // 
            this.UnknownTab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UnknownTab.Controls.Add(this.baseViewVarOtherLabel);
            this.UnknownTab.Controls.Add(this.baseViewVarOthersList);
            this.UnknownTab.Controls.Add(this.dotViewVar);
            this.UnknownTab.Controls.Add(this.baseViewVar);
            this.UnknownTab.Controls.Add(this.molViewVar);
            this.UnknownTab.Controls.Add(this.DotViewVarDot);
            this.UnknownTab.Controls.Add(this.baseViewVarChar);
            this.UnknownTab.Controls.Add(this.molViewVarImg);
            this.UnknownTab.Location = new System.Drawing.Point(4, 25);
            this.UnknownTab.Name = "UnknownTab";
            this.UnknownTab.Size = new System.Drawing.Size(574, 281);
            this.UnknownTab.TabIndex = 5;
            this.UnknownTab.Text = "Unkown or Variable";
            // 
            // baseViewVarOtherLabel
            // 
            this.baseViewVarOtherLabel.AutoSize = true;
            this.baseViewVarOtherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewVarOtherLabel.Location = new System.Drawing.Point(237, 155);
            this.baseViewVarOtherLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.baseViewVarOtherLabel.Name = "baseViewVarOtherLabel";
            this.baseViewVarOtherLabel.Size = new System.Drawing.Size(142, 34);
            this.baseViewVarOtherLabel.TabIndex = 39;
            this.baseViewVarOtherLabel.Text = "Or another IUPAC nucleotide code:";
            // 
            // baseViewVarOthersList
            // 
            this.baseViewVarOthersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baseViewVarOthersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewVarOthersList.Location = new System.Drawing.Point(240, 192);
            this.baseViewVarOthersList.Multiline = true;
            this.baseViewVarOthersList.Name = "baseViewVarOthersList";
            this.baseViewVarOthersList.ReadOnly = true;
            this.baseViewVarOthersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.baseViewVarOthersList.Size = new System.Drawing.Size(164, 66);
            this.baseViewVarOthersList.TabIndex = 38;
            this.baseViewVarOthersList.Text = "R = A or G\r\nY = C or T/U\r\nS = G or C\r\nW = A or T/U\r\nK = G or T/U\r\nM = A or C\r\nB =" +
    " C or G or T/U\r\nD = A or G or T/U\r\nH = A or C or T/U\r\nV = A or C or G\r\nN = any";
            // 
            // dotViewVar
            // 
            this.dotViewVar.AutoSize = true;
            this.dotViewVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotViewVar.Location = new System.Drawing.Point(425, 44);
            this.dotViewVar.Name = "dotViewVar";
            this.dotViewVar.Size = new System.Drawing.Size(90, 25);
            this.dotViewVar.TabIndex = 37;
            this.dotViewVar.Text = "Dot View";
            // 
            // baseViewVar
            // 
            this.baseViewVar.AutoSize = true;
            this.baseViewVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewVar.Location = new System.Drawing.Point(265, 44);
            this.baseViewVar.Name = "baseViewVar";
            this.baseViewVar.Size = new System.Drawing.Size(105, 25);
            this.baseViewVar.TabIndex = 36;
            this.baseViewVar.Text = "Base View";
            // 
            // molViewVar
            // 
            this.molViewVar.AutoSize = true;
            this.molViewVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molViewVar.Location = new System.Drawing.Point(51, 44);
            this.molViewVar.Name = "molViewVar";
            this.molViewVar.Size = new System.Drawing.Size(145, 25);
            this.molViewVar.TabIndex = 35;
            this.molViewVar.Text = "Molecular View";
            // 
            // DotViewVarDot
            // 
            this.DotViewVarDot.AutoSize = true;
            this.DotViewVarDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotViewVarDot.ForeColor = System.Drawing.Color.Black;
            this.DotViewVarDot.Location = new System.Drawing.Point(450, 110);
            this.DotViewVarDot.Name = "DotViewVarDot";
            this.DotViewVarDot.Size = new System.Drawing.Size(31, 46);
            this.DotViewVarDot.TabIndex = 25;
            this.DotViewVarDot.Text = "•";
            // 
            // baseViewVarChar
            // 
            this.baseViewVarChar.AutoSize = true;
            this.baseViewVarChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseViewVarChar.ForeColor = System.Drawing.Color.Black;
            this.baseViewVarChar.Location = new System.Drawing.Point(290, 110);
            this.baseViewVarChar.Name = "baseViewVarChar";
            this.baseViewVarChar.Size = new System.Drawing.Size(50, 46);
            this.baseViewVarChar.TabIndex = 13;
            this.baseViewVarChar.Text = "N";
            // 
            // molViewVarImg
            // 
            this.molViewVarImg.Image = global::SeniorProject.Properties.Resources.unk;
            this.molViewVarImg.Location = new System.Drawing.Point(25, 90);
            this.molViewVarImg.Name = "molViewVarImg";
            this.molViewVarImg.Size = new System.Drawing.Size(200, 150);
            this.molViewVarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.molViewVarImg.TabIndex = 7;
            this.molViewVarImg.TabStop = false;
            // 
            // Key
            // 
            this.ClientSize = new System.Drawing.Size(582, 310);
            this.Controls.Add(this.ntTabs);
            this.MaximumSize = new System.Drawing.Size(600, 355);
            this.MinimumSize = new System.Drawing.Size(600, 355);
            this.Name = "Key";
            this.Text = "RNA Explorer Visual Key";
            this.ntTabs.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.OverviewTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tablePanelA.ResumeLayout(false);
            this.tablePanelA.PerformLayout();
            this.tablePanelC.ResumeLayout(false);
            this.tablePanelC.PerformLayout();
            this.tablePanelG.ResumeLayout(false);
            this.tablePanelG.PerformLayout();
            this.tablePanelU.ResumeLayout(false);
            this.tablePanelU.PerformLayout();
            this.tablePanelVar.ResumeLayout(false);
            this.tablePanelVar.PerformLayout();
            this.AdenineTab.ResumeLayout(false);
            this.AdenineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewAImg)).EndInit();
            this.CytosineTab.ResumeLayout(false);
            this.CytosineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewCImg)).EndInit();
            this.GuanineTab.ResumeLayout(false);
            this.GuanineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewGImg)).EndInit();
            this.ThymineTab.ResumeLayout(false);
            this.ThymineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewTImg)).EndInit();
            this.UracilTab.ResumeLayout(false);
            this.UracilTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewUImg)).EndInit();
            this.UnknownTab.ResumeLayout(false);
            this.UnknownTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.molViewVarImg)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
