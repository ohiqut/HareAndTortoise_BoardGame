namespace GuiGame {
    partial class HareAndTortoiseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.boardTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSingleStep = new System.Windows.Forms.Button();
            this.gbSingleStep = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Colour = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Player = new System.Windows.Forms.Label();
            this.HareAndTortoise = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbSingleStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.boardTableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnSingleStep);
            this.splitContainer.Panel2.Controls.Add(this.gbSingleStep);
            this.splitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer.Panel2.Controls.Add(this.Player);
            this.splitContainer.Panel2.Controls.Add(this.HareAndTortoise);
            this.splitContainer.Panel2.Controls.Add(this.resetButton);
            this.splitContainer.Panel2.Controls.Add(this.rollDiceButton);
            this.splitContainer.Panel2.Controls.Add(this.exitButton);
            this.splitContainer.Size = new System.Drawing.Size(884, 664);
            this.splitContainer.SplitterDistance = 650;
            this.splitContainer.TabIndex = 3;
            // 
            // boardTableLayoutPanel
            // 
            this.boardTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.boardTableLayoutPanel.ColumnCount = 6;
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.boardTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.boardTableLayoutPanel.Name = "boardTableLayoutPanel";
            this.boardTableLayoutPanel.RowCount = 7;
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.boardTableLayoutPanel.Size = new System.Drawing.Size(677, 666);
            this.boardTableLayoutPanel.TabIndex = 0;
            // 
            // btnSingleStep
            // 
            this.btnSingleStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleStep.Location = new System.Drawing.Point(29, 467);
            this.btnSingleStep.Name = "btnSingleStep";
            this.btnSingleStep.Size = new System.Drawing.Size(138, 59);
            this.btnSingleStep.TabIndex = 11;
            this.btnSingleStep.Text = "Click Next Players Roll";
            this.btnSingleStep.UseVisualStyleBackColor = true;
            this.btnSingleStep.Visible = false;
            this.btnSingleStep.Click += new System.EventHandler(this.btnSingleStep_Click);
            // 
            // gbSingleStep
            // 
            this.gbSingleStep.Controls.Add(this.rbtNo);
            this.gbSingleStep.Controls.Add(this.rbtYes);
            this.gbSingleStep.Location = new System.Drawing.Point(9, 351);
            this.gbSingleStep.Name = "gbSingleStep";
            this.gbSingleStep.Size = new System.Drawing.Size(200, 100);
            this.gbSingleStep.TabIndex = 10;
            this.gbSingleStep.TabStop = false;
            this.gbSingleStep.Text = "Single Step";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(20, 67);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            this.rbtNo.CheckedChanged += new System.EventHandler(this.rbtNo_CheckedChanged);
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(20, 33);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            this.rbtYes.CheckedChanged += new System.EventHandler(this.rbtYes_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colour,
            this.nameDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.winnerDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(210, 155);
            this.dataGridView1.TabIndex = 9;
            // 
            // Colour
            // 
            this.Colour.DataPropertyName = "PlayerTokenImage";
            this.Colour.HeaderText = "PlayerTokenImage";
            this.Colour.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            this.Colour.Width = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(110, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.ForeColor = System.Drawing.Color.Black;
            this.Player.Location = new System.Drawing.Point(11, 43);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(93, 13);
            this.Player.TabIndex = 6;
            this.Player.Text = "Number of Players";
            // 
            // HareAndTortoise
            // 
            this.HareAndTortoise.AutoSize = true;
            this.HareAndTortoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HareAndTortoise.ForeColor = System.Drawing.Color.Red;
            this.HareAndTortoise.Location = new System.Drawing.Point(25, 13);
            this.HareAndTortoise.Name = "HareAndTortoise";
            this.HareAndTortoise.Size = new System.Drawing.Size(164, 24);
            this.HareAndTortoise.TabIndex = 5;
            this.HareAndTortoise.Text = "Hare And Tortoise";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(40, 629);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(69, 554);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(75, 23);
            this.rollDiceButton.TabIndex = 3;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Visible = false;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(128, 629);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "$";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 30;
            // 
            // winnerDataGridViewCheckBoxColumn
            // 
            this.winnerDataGridViewCheckBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewCheckBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewCheckBoxColumn.Name = "winnerDataGridViewCheckBoxColumn";
            this.winnerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.winnerDataGridViewCheckBoxColumn.Width = 50;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(SharedGameClasses.Player);
            // 
            // HareAndTortoiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.splitContainer);
            this.Name = "HareAndTortoiseForm";
            this.Text = "Hare and Tortoise";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbSingleStep.ResumeLayout(false);
            this.gbSingleStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel boardTableLayoutPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Label HareAndTortoise;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn winnerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox gbSingleStep;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.Button btnSingleStep;
    }
}

