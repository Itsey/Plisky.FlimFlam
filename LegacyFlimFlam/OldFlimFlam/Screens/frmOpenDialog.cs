using System;
using System.IO;
using System.Windows.Forms;

namespace MexInternals {

    internal partial class frmOpenDialog : Form {

        internal string Filename {
            get { return txtFilename.Text; }
        }

        internal bool GetAsynchOK() {
            return chkAsynchImport.Checked;
        }

        internal string GetLabelIdent() {
            return txtLabelIdent.Text;
        }

        internal FileImportMethod GetFileImportMethod() {
            if (rdoImportADPlus.Checked) { return FileImportMethod.ADPlusLog; }
            if (rdoImportTypeTxtFileWriter.Checked) { return FileImportMethod.TextWriterWithTexSupport; }
            if (rdoDebugViewTex.Checked) { return FileImportMethod.DebugViewTexLog; }
            return FileImportMethod.GenericLog;
        }

        internal frmOpenDialog() {
            InitializeComponent();
        }

        internal void InitialiseDialog(string lastFileLoaded, string[] mruList) {
            txtFilename.Text = lastFileLoaded;
            lbxMRUList.Items.AddRange(mruList);
        }

        private void btnBrowseForFile_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.InitialDirectory = Environment.CurrentDirectory;
                ofd.Filter = "TexLogs (txt)|*.txt|Logs (log)|*.Log|All Files (*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    txtFilename.Text = ofd.FileName;
                }
            }
        }

        private void txtFilename_TextChanged(object sender, EventArgs e) {
            btnOk.Enabled = File.Exists(txtFilename.Text);
            if (!m_modifiedLabel) {
                txtLabelIdent.Text = Path.GetFileNameWithoutExtension(txtFilename.Text);
            }
        }

        private bool m_modifiedLabel; // Default false

        private void lbxMRUList_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbxMRUList.SelectedItem == null) { return; }
            txtFilename.Text = lbxMRUList.SelectedItem.ToString();
        }

        private void txtLabelIdent_TextChanged(object sender, EventArgs e) {
            m_modifiedLabel = true;
        }
    }
}