//using Plisky.Plumbing.Legacy;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MexInternals {

    /// <summary>
    /// Summary description for frmExtendedDetails.
    /// </summary>
    internal class frmExtendedDetails : System.Windows.Forms.Form {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private Panel pnlLogView;
        private Splitter splitter2;
        private Splitter splitter1;
        internal TextBox txtEntryFurtherDetails;
        internal TextBox txtSecondaryMessage;
        internal TextBox txtDebugEntry;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem selectionIsPathToolStripMenuItem;
        private ToolStripMenuItem fileExistsToolStripMenuItem;
        private ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private ToolStripMenuItem selectionIsGayMlToolStripMenuItem;
        private CheckBox chkAllowEdit;
        private ToolStripMenuItem filterSelectionToolStripMenuItem;
        private ToolStripMenuItem tsmiFilterExcludeSelection;
        private ToolStripMenuItem tsmiFilterIncludeSelection;
        private IContainer components;

        internal frmExtendedDetails() {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtendedDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAllowEdit = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlLogView = new System.Windows.Forms.Panel();
            this.txtSecondaryMessage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectionIsPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionIsGayMlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterExcludeSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterIncludeSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtEntryFurtherDetails = new System.Windows.Forms.TextBox();
            this.txtDebugEntry = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlLogView.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.chkAllowEdit);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 34);
            this.panel1.TabIndex = 4;
            //
            // chkAllowEdit
            //
            this.chkAllowEdit.AutoSize = true;
            this.chkAllowEdit.Location = new System.Drawing.Point(12, 6);
            this.chkAllowEdit.Name = "chkAllowEdit";
            this.chkAllowEdit.Size = new System.Drawing.Size(85, 17);
            this.chkAllowEdit.TabIndex = 5;
            this.chkAllowEdit.Text = "Allow editing";
            this.chkAllowEdit.UseVisualStyleBackColor = true;
            this.chkAllowEdit.CheckedChanged += new System.EventHandler(this.chkAllowEdit_CheckedChanged);
            //
            // btnOk
            //
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnOk.Location = new System.Drawing.Point(558, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = false;
            //
            // pnlLogView
            //
            this.pnlLogView.Controls.Add(this.txtSecondaryMessage);
            this.pnlLogView.Controls.Add(this.splitter2);
            this.pnlLogView.Controls.Add(this.splitter1);
            this.pnlLogView.Controls.Add(this.txtEntryFurtherDetails);
            this.pnlLogView.Controls.Add(this.txtDebugEntry);
            this.pnlLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogView.Location = new System.Drawing.Point(0, 0);
            this.pnlLogView.Name = "pnlLogView";
            this.pnlLogView.Size = new System.Drawing.Size(674, 306);
            this.pnlLogView.TabIndex = 7;
            //
            // txtSecondaryMessage
            //
            this.txtSecondaryMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecondaryMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.txtSecondaryMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSecondaryMessage.Location = new System.Drawing.Point(0, 143);
            this.txtSecondaryMessage.MinimumSize = new System.Drawing.Size(0, 19);
            this.txtSecondaryMessage.Multiline = true;
            this.txtSecondaryMessage.Name = "txtSecondaryMessage";
            this.txtSecondaryMessage.ReadOnly = true;
            this.txtSecondaryMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecondaryMessage.Size = new System.Drawing.Size(674, 51);
            this.txtSecondaryMessage.TabIndex = 3;
            this.txtSecondaryMessage.Text = "AA";
            //
            // contextMenuStrip1
            //
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionIsPathToolStripMenuItem,
            this.selectionIsGayMlToolStripMenuItem,
            this.filterSelectionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            //
            // selectionIsPathToolStripMenuItem
            //
            this.selectionIsPathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExistsToolStripMenuItem,
            this.openContainingFolderToolStripMenuItem});
            this.selectionIsPathToolStripMenuItem.Name = "selectionIsPathToolStripMenuItem";
            this.selectionIsPathToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectionIsPathToolStripMenuItem.Text = "Selection Is Path";
            //
            // fileExistsToolStripMenuItem
            //
            this.fileExistsToolStripMenuItem.Name = "fileExistsToolStripMenuItem";
            this.fileExistsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.fileExistsToolStripMenuItem.Text = "File Exists:";
            this.fileExistsToolStripMenuItem.Click += new System.EventHandler(this.fileExistsToolStripMenuItem_Click);
            //
            // openContainingFolderToolStripMenuItem
            //
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open Containing Folder:";
            this.openContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.openContainingFolderToolStripMenuItem_Click);
            //
            // selectionIsGayMlToolStripMenuItem
            //
            this.selectionIsGayMlToolStripMenuItem.Name = "selectionIsGayMlToolStripMenuItem";
            this.selectionIsGayMlToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectionIsGayMlToolStripMenuItem.Text = "Selection is Xml";
            this.selectionIsGayMlToolStripMenuItem.Click += new System.EventHandler(this.selectionIsGayMlToolStripMenuItem_Click);
            //
            // filterSelectionToolStripMenuItem
            //
            this.filterSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterExcludeSelection,
            this.tsmiFilterIncludeSelection});
            this.filterSelectionToolStripMenuItem.Name = "filterSelectionToolStripMenuItem";
            this.filterSelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.filterSelectionToolStripMenuItem.Text = "Filter Selection";
            //
            // tsmiFilterExcludeSelection
            //
            this.tsmiFilterExcludeSelection.Name = "tsmiFilterExcludeSelection";
            this.tsmiFilterExcludeSelection.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterExcludeSelection.Text = "Exclude ()";
            this.tsmiFilterExcludeSelection.Click += new System.EventHandler(this.tsmiFilterExcludeSelection_Click);
            //
            // tsmiFilterIncludeSelection
            //
            this.tsmiFilterIncludeSelection.Name = "tsmiFilterIncludeSelection";
            this.tsmiFilterIncludeSelection.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterIncludeSelection.Text = "Include ()";
            this.tsmiFilterIncludeSelection.Click += new System.EventHandler(this.txtmiFilterIncludeSelection_Click);
            //
            // splitter2
            //
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 194);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(674, 9);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            //
            // splitter1
            //
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 133);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(674, 10);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            //
            // txtEntryFurtherDetails
            //
            this.txtEntryFurtherDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtEntryFurtherDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.txtEntryFurtherDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEntryFurtherDetails.Location = new System.Drawing.Point(0, 203);
            this.txtEntryFurtherDetails.MinimumSize = new System.Drawing.Size(0, 19);
            this.txtEntryFurtherDetails.Multiline = true;
            this.txtEntryFurtherDetails.Name = "txtEntryFurtherDetails";
            this.txtEntryFurtherDetails.ReadOnly = true;
            this.txtEntryFurtherDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntryFurtherDetails.Size = new System.Drawing.Size(674, 103);
            this.txtEntryFurtherDetails.TabIndex = 4;
            this.txtEntryFurtherDetails.Text = "AA";
            //
            // txtDebugEntry
            //
            this.txtDebugEntry.BackColor = System.Drawing.Color.Lavender;
            this.txtDebugEntry.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDebugEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDebugEntry.Location = new System.Drawing.Point(0, 0);
            this.txtDebugEntry.MinimumSize = new System.Drawing.Size(0, 19);
            this.txtDebugEntry.Multiline = true;
            this.txtDebugEntry.Name = "txtDebugEntry";
            this.txtDebugEntry.ReadOnly = true;
            this.txtDebugEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugEntry.Size = new System.Drawing.Size(674, 133);
            this.txtDebugEntry.TabIndex = 1;
            //
            // frmExtendedDetails
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(674, 340);
            this.Controls.Add(this.pnlLogView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(514, 255);
            this.Name = "frmExtendedDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmExtendedDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogView.ResumeLayout(false);
            this.pnlLogView.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private string m_quickFilterText; // Default null

        private void ModifyQuickFilter(bool include) {
           //Bilge.Assert(m_quickFilterText != null, "Should not have null text selection possible, the button should be disabled if this is the case");
           //Bilge.Assert(m_quickFilterText.Length > 0, "Should not have empty text selection possible, the button should be disabled if this is the case");
            MexCore.TheCore.ViewManager.CurrentFilter.BeginFilterUpdate();
            if (include) {
                MexCore.TheCore.ViewManager.CurrentFilter.AppendIncludeString(m_quickFilterText);
            } else {
                MexCore.TheCore.ViewManager.CurrentFilter.AppendExcludeString(m_quickFilterText);
            }
            MexCore.TheCore.ViewManager.CurrentFilter.EndFilterUpdate();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
           //Bilge.Log("ExtendedDetails View, opening context menu");

            tsmiFilterExcludeSelection.Enabled = false;
            tsmiFilterIncludeSelection.Enabled = false;

            TextBox source = ((sender as ContextMenuStrip).SourceControl as TextBox);
            if (source == null) {
               //Bilge.FurtherInfo("Right click did not occur on a textbox, returning");
                return;
            }  // The right click did not occur on a textbox.

            string selectedText = source.SelectedText.Trim();
            if ((selectedText == null) || (selectedText.Length == 0)) {
               //Bilge.FurtherInfo("There was no selected text in this texbox, returning. TB:" + source.Name);
            }

           //Bilge.Log("ExtendedDetails context menu opening for a textbox - " + source.Name, selectedText ?? "No text selected");

            // There are several things that we can do with the selected text, we test to see whether it could be a folder
            // we also test to see whether it looks like xml and finally we update the filters context menu items to allow
            // people to filter based on the selection.

            selectionIsGayMlToolStripMenuItem.Enabled = DoesTextLookLikeXml(selectedText);
            selectionIsGayMlToolStripMenuItem.Tag = selectedText;

            // Now work out whether or not it could be a file or folder that is selected.

            #region Enable or disable the folder and file based right click menu.

            fileExistsToolStripMenuItem.Text = "Not a File / Path";
            fileExistsToolStripMenuItem.Enabled = false;
            openContainingFolderToolStripMenuItem.Text = "Not a File / Path";
            openContainingFolderToolStripMenuItem.Enabled = false;

            if (File.Exists(selectedText)) {
                fileExistsToolStripMenuItem.Text = "Open In Notepad.";
                fileExistsToolStripMenuItem.Enabled = true;
                fileExistsToolStripMenuItem.Tag = selectedText;
            } else {
                fileExistsToolStripMenuItem.Text = "No Such File.";
                fileExistsToolStripMenuItem.Enabled = false;
            }
            if (!string.IsNullOrEmpty(selectedText)) {
                // If it does exist then the folder will be set to open containing folder.
                try {
                    string containingFolder = Path.GetDirectoryName(selectedText);
                    if (Directory.Exists(containingFolder)) {
                        openContainingFolderToolStripMenuItem.Tag = containingFolder;
                        openContainingFolderToolStripMenuItem.Text = "Open Containing Folder";
                        openContainingFolderToolStripMenuItem.Enabled = true;
                    } else {
                        openContainingFolderToolStripMenuItem.Enabled = false;
                    }
                } catch (ArgumentException) {
                    // This indicates that the selected text was not a valid directory, therefore we are ignoring it.
                }
            }

            #endregion

            // Now set up the filters correctly so they can quick include and quick exclude.
            m_quickFilterText = selectedText;
            tsmiFilterExcludeSelection.Enabled = true;
            tsmiFilterIncludeSelection.Enabled = true;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private bool DoesTextLookLikeXml(string selectedText) {
            if (selectedText.StartsWith("<")) {
                return true;
            }
            return false;
        }

        private void selectionIsGayMlToolStripMenuItem_Click(object sender, EventArgs e) {
            // Take the selected text, store it to a file and fire up IE to go look at it.
            string selectedText = ((sender as ToolStripMenuItem).Tag as string);

           //Bilge.Assert(selectedText != null, "The selected text that made it to treatSelectionAsGayMl was null or empty");
           //Bilge.Assert(selectedText.Length > 0, "The selected text that made it to treatSelectionAsGayMl was null or empty");

            string fname = Path.GetTempFileName();

            using (StreamWriter sw = new StreamWriter(new FileStream(fname, FileMode.Open))) {
                sw.Write(selectedText);
                sw.Close();
            }

           //Bilge.Log("Written GayML to a file and now launching internet explorer to display contents");
            ProcessStartInfo psi = new ProcessStartInfo("Iexplore.exe", fname);
            Process.Start(psi);
        }

        private void fileExistsToolStripMenuItem_Click(object sender, EventArgs e) {
            string selectedText = ((sender as ToolStripMenuItem).Tag as string);

           //Bilge.Assert(selectedText != null, "The selected text that made it to open file  was null or empty");
           //Bilge.Assert(selectedText.Length > 0, "The selected text that made it to open file was null or empty");

            ProcessStartInfo psi = new ProcessStartInfo("notepad.exe", selectedText);
            Process.Start(psi);
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e) {
            string selectedText = ((sender as ToolStripMenuItem).Tag as string);

           //Bilge.Assert(selectedText != null, "The selected text that made it to open file  was null or empty");
           //Bilge.Assert(selectedText.Length > 0, "The selected text that made it to open file was null or empty");

            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe", "/e," + selectedText);
            Process.Start(psi);
        }

        private void chkAllowEdit_CheckedChanged(object sender, EventArgs e) {
            txtDebugEntry.ReadOnly = txtEntryFurtherDetails.ReadOnly = txtSecondaryMessage.ReadOnly = !chkAllowEdit.Checked;
        }

        private void tsmiFilterExcludeSelection_Click(object sender, EventArgs e) {
            ModifyQuickFilter(false);
        }

        private void txtmiFilterIncludeSelection_Click(object sender, EventArgs e) {
            ModifyQuickFilter(true);
        }
    }
}