namespace MexInternals {

    /// <summary>
    /// Summary description for frmFindDialog.
    /// </summary>
    internal class frmFindDialog : System.Windows.Forms.Form {
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.TextBox txtMatchText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        internal frmFindDialog() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindDialog));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMatchText = new System.Windows.Forms.TextBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // btnOk
            //
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(377, 55);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "F&ind";
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(297, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "C&ancel";
            //
            // txtMatchText
            //
            this.txtMatchText.Location = new System.Drawing.Point(3, 12);
            this.txtMatchText.Name = "txtMatchText";
            this.txtMatchText.Size = new System.Drawing.Size(456, 20);
            this.txtMatchText.TabIndex = 2;
            //
            // chkCaseSensitive
            //
            this.chkCaseSensitive.Location = new System.Drawing.Point(3, 38);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(144, 16);
            this.chkCaseSensitive.TabIndex = 6;
            this.chkCaseSensitive.Text = "chkCaseSensitive";
            //
            // frmFindDialog
            //
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(464, 83);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.txtMatchText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFindDialog";
            this.Activated += new System.EventHandler(this.frmFindDialog_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal string GetFindMatchText() {
            return txtMatchText.Text;
        }

        internal FindMatchUsageType GetUsageType() {
            if (chkCaseSensitive.Checked) {
                return FindMatchUsageType.TextMatchCaseSensitive;
            } else {
                return FindMatchUsageType.TextMatchNoCase;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal FindMatchLocationType GetLocationType() {
            return FindMatchLocationType.CurrentPhysicalView;
        }

        private void frmFindDialog_Activated(object sender, System.EventArgs e) {
            txtMatchText.Focus();
        }

        internal enum FindMatchUsageType { TextMatchCaseSensitive, TextMatchNoCase, RegexMatch, Unknown };

        internal enum FindMatchLocationType { CurrentPhysicalView, CurrentLogicalView, CurrentViewNoFilter };

        /// <summary>
        /// Returns an active find structure from the settings specified in the dialog.
        /// </summary>
        /// <returns></returns>
        internal ActiveFindStructure GetFindStructure() {
            return new ActiveFindStructure(txtMatchText.Text, !chkCaseSensitive.Checked);
        }
    }
}