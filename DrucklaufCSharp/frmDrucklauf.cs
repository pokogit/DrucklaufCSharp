using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Deployment.Application;
using System.Reflection;
using System.Transactions;

namespace DrucklaufCSharp
{
    public partial class frmDrucklauf : Form
    {
        #region Member-Variablen
            private enum Status { NotOK, OK}
            private int _NumberOfRowsFound;
        #endregion

        #region Konstruktoren & Form-Events

            public frmDrucklauf()
            {
                InitializeComponent();  
            }

            private void frmDrucklauf_Load(object sender, EventArgs e)
            {
                // Datenbankverbindung herstellen
                ConnectToDB();
                AddAdditionalEventHandler();
            }

            private void frmDrucklauf_Shown(object sender, EventArgs e)
            {
                txtPaket.Focus();
            }

            private void frmDrucklauf_FormClosing(object sender, FormClosingEventArgs e)
            {
                DialogResult dlgResult = MessageBox.Show("Programm beenden?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlgResult)
                {
                    case DialogResult.Yes:
                        e.Cancel = DataHasChanged();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        #endregion

        #region Methoden

            /// <summary>
            /// Zusätzliche Handler implementieren
            /// </summary>
            private void AddAdditionalEventHandler()
            {
                // Den KeyDown-Events der Textfelder die Methode 'CallSearchMethod' hinzufügen
                this.txtDrucklauf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CallSearchMethod);
                this.txtPaket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CallSearchMethod);
            }

            /// <summary>
            /// Diese Methode wird durch die Events 'this.txtDrucklauf.KeyDown'
            /// und 'this.txtPaket.KeyDown' aufgerufen.
            /// </summary>
            private void CallSearchMethod(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Search();
                }
            }

            /// <summary>
            /// Verbindung mit DB herstellen
            /// </summary>
            private void ConnectToDB()
            {
                string database = string.Empty;
                string[] connString;

                clsDrucklaufConfig drucklaufConfig = new clsDrucklaufConfig(Properties.Settings.Default.configPath);

                if (MessageBox.Show("Wollen Sie die Testumgebung benutzen?", "Auswahl Umgebung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Test-DB benutzen
                    Properties.Settings.Default.Orderman_DatenConnectionString = drucklaufConfig.DB3ConnectionString;
                }
                else
                {
                    // Live-DB benutzen
                    Properties.Settings.Default.Orderman_DatenConnectionString = drucklaufConfig.DB1ConnectionString;
                }

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    Version version = Assembly.GetExecutingAssembly().GetName().Version;
                    database = string.Concat("Version ", version.Major, ".", version.Minor, ".", version.MinorRevision);
                }
                else
                {
                    connString = this.taDrucklaufPakete.Connection.ConnectionString.Split(';');
                    database = connString[0].Split('=')[1];

                    this.lblDatabase.Text = database;
                    this.lblDatabase.Icon = null;

                    if (database.ToUpper().Contains("S-DB01"))
                    {
                        this.lblDatabase.Text = String.Concat(database, " - (ACHTUNG!!! - Live-Datenbank)");
                        this.lblDatabase.Icon = Properties.Resources.Exclamation;
                    }
                }
            }

            /// <summary>
            /// Suchen-Methode
            /// </summary>
            private void Search()
            {
                if (!DataHasChanged())
                {
                    _NumberOfRowsFound =  this.taDrucklaufPakete.FillByPaketAndDrucklauf(this.dsOrderman_Daten.tblDrucklaufPakete, (int)txtPaket.Value, (int)txtDrucklauf.Value);

                    btnSave.Enabled = (_NumberOfRowsFound == 0) ? false : true;
                    if (!btnSave.Enabled) MessageBox.Show("Es wurden keine Daten gefunden.", "Suchen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }          
            }

            /// <summary>
            ///  Überprüfen, ob sich Daten geändert haben.
            ///  </summary>
            private Boolean DataHasChanged()
            {
                DialogResult dlgResult;
                DataRowView drv;
                Boolean retValue = false;

                drv = (DataRowView)(this.bsDrucklauf.Current);

                if (drv != null && drv.Row.RowState == DataRowState.Modified)
                {
                    dlgResult = MessageBox.Show("Daten wurden geändert. Vorher speichern?", "Daten geändert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (dlgResult)
                    {
                        case DialogResult.Yes:
                            // War das Speichern erfolgreich?
                            if (Save() == Status.OK)
                                retValue = false;
                            break;
                        case DialogResult.No:
                            retValue = false;
                            break;
                        case DialogResult.Cancel:
                            retValue = true;
                            break;
                    }
                }
                return retValue;
            }

            /// <summary>
            /// Speichern-Methode
            /// </summary>
            private Status Save()
            {
                Status retValue;
                StringBuilder sb = new StringBuilder();

                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        this.Validate();
                        this.bsDrucklauf.EndEdit();
                        taDrucklaufPakete.Update(this.dsOrderman_Daten.tblDrucklaufPakete);
                        MessageBox.Show("Daten gespeichert.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        scope.Complete();
                        retValue = Status.OK;
                    } 
                    catch (Exception ex)
                    {
                        sb.Clear();
                        sb.AppendLine("Fehler beim Speichern aufgetreten!");
                        sb.AppendLine(ex.Message);
                        if (ex.InnerException != null)
                        {
                            sb.AppendLine("----------------------------------------------------");
                            sb.AppendLine(ex.InnerException.Message);
                        }
                        MessageBox.Show(sb.ToString(), "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        scope.Dispose();   
                        retValue = Status.NotOK;
                    }
                }
                return retValue;
            }

        #endregion

        #region Events
            private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                Search();
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                Save();
            }

            private void txtPaket_Enter(object sender, EventArgs e)
            {
                txtPaket.SelectAll();
            }

            private void txtDrucklauf_Enter(object sender, EventArgs e)
            {
                txtDrucklauf.SelectAll();
            }
        #endregion
    }
}
