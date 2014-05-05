namespace CurriculumPowerRanger
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.mainWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBar.SuspendLayout();
            this.actionsMenuPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 24);
            this.menuBar.TabIndex = 0;
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = global::CurriculumPowerRanger.Properties.Resources.add;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarCurriculumEvent);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::CurriculumPowerRanger.Properties.Resources.export;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Exportar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Exportar_Event);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaToolStripMenuItem1});
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaToolStripMenuItem1
            // 
            this.acercaToolStripMenuItem1.Name = "acercaToolStripMenuItem1";
            this.acercaToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.acercaToolStripMenuItem1.Text = "Acerca";
            this.acercaToolStripMenuItem1.Click += new System.EventHandler(this.acercaToolStripMenuItem1_Click);
            // 
            // actionsMenuPanel
            // 
            this.actionsMenuPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.actionsMenuPanel.Controls.Add(this.addButton);
            this.actionsMenuPanel.Controls.Add(this.removeButton);
            this.actionsMenuPanel.Controls.Add(this.updateButton);
            this.actionsMenuPanel.Controls.Add(this.exportButton);
            this.actionsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsMenuPanel.Location = new System.Drawing.Point(0, 24);
            this.actionsMenuPanel.Name = "actionsMenuPanel";
            this.actionsMenuPanel.Size = new System.Drawing.Size(784, 60);
            this.actionsMenuPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Image = global::CurriculumPowerRanger.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 55);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.agregarCurriculumEvent);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeButton.Image = global::CurriculumPowerRanger.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(64, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(55, 55);
            this.removeButton.TabIndex = 1;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Image = global::CurriculumPowerRanger.Properties.Resources.modify;
            this.updateButton.Location = new System.Drawing.Point(125, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(55, 55);
            this.updateButton.TabIndex = 2;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exportButton.Image = global::CurriculumPowerRanger.Properties.Resources.export;
            this.exportButton.Location = new System.Drawing.Point(186, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(55, 55);
            this.exportButton.TabIndex = 3;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.Exportar_Event);
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.tableView);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 84);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(784, 278);
            this.mainContainer.TabIndex = 2;
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.Size = new System.Drawing.Size(784, 278);
            this.tableView.TabIndex = 0;
            // 
            // mainWindowBindingSource
            // 
            this.mainWindowBindingSource.DataSource = typeof(CurriculumPowerRanger.mainWindow);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.actionsMenuPanel);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "mainWindow";
            this.Text = "Curriculums de Power Rangers";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.actionsMenuPanel.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel actionsMenuPanel;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.BindingSource mainWindowBindingSource;
    }
}

