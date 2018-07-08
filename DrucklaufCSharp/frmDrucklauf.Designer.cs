namespace DrucklaufCSharp
{
    partial class frmDrucklauf
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout grdDrucklauf_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrucklauf));
            this.txtDrucklauf = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.txtPaket = new Janus.Windows.GridEX.EditControls.NumericEditBox();
            this.grdDrucklauf = new Janus.Windows.GridEX.GridEX();
            this.dsOrderman_Daten = new DrucklaufCSharp.dsOrderman_Daten();
            this.bsDrucklauf = new System.Windows.Forms.BindingSource(this.components);
            this.taDrucklaufPakete = new DrucklaufCSharp.dsOrderman_DatenTableAdapters.taDrucklaufPakete();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.btnClose = new Janus.Windows.EditControls.UIButton();
            this.lblDrucklauf = new System.Windows.Forms.Label();
            this.lblPaket = new System.Windows.Forms.Label();
            this.ribbonStatusBar1 = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.lblDatabase = new Janus.Windows.Ribbon.LabelCommand();
            ((System.ComponentModel.ISupportInitialize)(this.grdDrucklauf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrderman_Daten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDrucklauf)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDrucklauf
            // 
            this.txtDrucklauf.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.txtDrucklauf.Location = new System.Drawing.Point(170, 12);
            this.txtDrucklauf.Name = "txtDrucklauf";
            this.txtDrucklauf.Size = new System.Drawing.Size(44, 20);
            this.txtDrucklauf.TabIndex = 1;
            this.txtDrucklauf.Text = "0";
            this.txtDrucklauf.Value = 0;
            this.txtDrucklauf.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.txtDrucklauf.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.txtDrucklauf.Enter += new System.EventHandler(this.txtDrucklauf_Enter);
            // 
            // txtPaket
            // 
            this.txtPaket.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.txtPaket.Location = new System.Drawing.Point(56, 12);
            this.txtPaket.Name = "txtPaket";
            this.txtPaket.Size = new System.Drawing.Size(44, 20);
            this.txtPaket.TabIndex = 0;
            this.txtPaket.Text = "0";
            this.txtPaket.Value = 0;
            this.txtPaket.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.txtPaket.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.txtPaket.Enter += new System.EventHandler(this.txtPaket_Enter);
            // 
            // grdDrucklauf
            // 
            this.grdDrucklauf.DataMember = "tblDrucklaufPakete";
            this.grdDrucklauf.DataSource = this.dsOrderman_Daten;
            grdDrucklauf_DesignTimeLayout.LayoutString = resources.GetString("grdDrucklauf_DesignTimeLayout.LayoutString");
            this.grdDrucklauf.DesignTimeLayout = grdDrucklauf_DesignTimeLayout;
            this.grdDrucklauf.FilterMode = Janus.Windows.GridEX.FilterMode.Manual;
            this.grdDrucklauf.GroupByBoxVisible = false;
            this.grdDrucklauf.Location = new System.Drawing.Point(12, 38);
            this.grdDrucklauf.Name = "grdDrucklauf";
            this.grdDrucklauf.Size = new System.Drawing.Size(705, 376);
            this.grdDrucklauf.TabIndex = 3;
            this.grdDrucklauf.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // dsOrderman_Daten
            // 
            this.dsOrderman_Daten.DataSetName = "dsOrderman_Daten";
            this.dsOrderman_Daten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDrucklauf
            // 
            this.bsDrucklauf.DataMember = "tblDrucklaufPakete";
            this.bsDrucklauf.DataSource = this.dsOrderman_Daten;
            // 
            // taDrucklaufPakete
            // 
            this.taDrucklaufPakete.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(642, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(561, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Speichern";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(642, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Beenden";
            this.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDrucklauf
            // 
            this.lblDrucklauf.AutoSize = true;
            this.lblDrucklauf.Location = new System.Drawing.Point(114, 16);
            this.lblDrucklauf.Name = "lblDrucklauf";
            this.lblDrucklauf.Size = new System.Drawing.Size(56, 13);
            this.lblDrucklauf.TabIndex = 7;
            this.lblDrucklauf.Text = "Drucklauf:";
            // 
            // lblPaket
            // 
            this.lblPaket.AutoSize = true;
            this.lblPaket.Location = new System.Drawing.Point(14, 16);
            this.lblPaket.Name = "lblPaket";
            this.lblPaket.Size = new System.Drawing.Size(38, 13);
            this.lblPaket.TabIndex = 8;
            this.lblPaket.Text = "Paket:";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.lblDatabase});
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 449);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(729, 23);
            // 
            // 
            // 
            this.ribbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbonStatusBar1.SuperTipComponent.ImageList = null;
            this.ribbonStatusBar1.TabIndex = 9;
            this.ribbonStatusBar1.Text = "ribbonStatusBar1";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Icon = ((System.Drawing.Icon)(resources.GetObject("lblDatabase.Icon")));
            this.lblDatabase.Key = "labelCommand1";
            this.lblDatabase.Name = "lblDatabase";
            // 
            // frmDrucklauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 472);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.lblPaket);
            this.Controls.Add(this.lblDrucklauf);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdDrucklauf);
            this.Controls.Add(this.txtPaket);
            this.Controls.Add(this.txtDrucklauf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDrucklauf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drucklauf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrucklauf_FormClosing);
            this.Load += new System.EventHandler(this.frmDrucklauf_Load);
            this.Shown += new System.EventHandler(this.frmDrucklauf_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdDrucklauf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrderman_Daten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDrucklauf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.EditControls.NumericEditBox txtDrucklauf;
        private Janus.Windows.GridEX.EditControls.NumericEditBox txtPaket;
        private Janus.Windows.GridEX.GridEX grdDrucklauf;
        private System.Windows.Forms.BindingSource bsDrucklauf;
        private dsOrderman_Daten dsOrderman_Daten;
        private dsOrderman_DatenTableAdapters.taDrucklaufPakete taDrucklaufPakete;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnSave;
        private Janus.Windows.EditControls.UIButton btnClose;
        private System.Windows.Forms.Label lblDrucklauf;
        private System.Windows.Forms.Label lblPaket;
        private Janus.Windows.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private Janus.Windows.Ribbon.LabelCommand lblDatabase;
    }
}

