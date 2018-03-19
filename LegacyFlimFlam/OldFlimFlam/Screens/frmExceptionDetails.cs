using System;
using System.Windows.Forms;

namespace MexInternals {

    internal partial class frmExceptionDetails : Form {

        internal frmExceptionDetails() {
            InitializeComponent();
        }

        private long baseIdx; // Default 0

        internal void InitialiseOnceDatasIn(long idxUsed) {
            if (lbxExceptionHeirachy.Items.Count > 0) {
                lbxExceptionHeirachy.SelectedIndex = 0;
            }
            baseIdx = idxUsed;
        }

        private void lbxExceptionHeirachy_SelectedIndexChanged(object sender, EventArgs e) {
            // When the selection is changed the details view displays the details about the selected exception.
            LooksLikeAnException llae = (LooksLikeAnException)lbxExceptionHeirachy.SelectedItem;
            txtSelectedExceptionDetails.Text = llae.GetDescriptionFully();
        }

        private void btnShowBackTrace_Click(object sender, EventArgs e) {
            ShowFormsBackTraceView(true);
        }

        private void ShowFormsBackTraceView(bool sameThread) {
            MexCore.TheCore.ViewManager.GetBackTraceLeadingToMessage(lbxExceptionBackTrace, baseIdx, sameThread);
        }

        private void btnShowAllTraceUpToException_Click(object sender, EventArgs e) {
            ShowFormsBackTraceView(false);
        }
    }
}