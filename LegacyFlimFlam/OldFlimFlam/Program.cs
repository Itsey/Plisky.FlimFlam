//using Plisky.Plumbing.Legacy;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MexInternals {

    internal static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args) {
            bool setLogOptions = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The setting of bypass in the app config ensures that Tex does not perform its static initialisation.

            Debug.Listeners.Clear();
           //Bilge.CurrentTraceLevel = TraceLevel.Off;
            // TODO ://Bilge.AddOutputDebugStringListener();

            #region Tex Trace Support

            if (args.Length > 0) {
                if (args[0] == "/debug") {
                    // Mex can not use the Tex default listener as it captures the messages it writes therefore things get overly resource
                    // intensive if they share the same listener as sender on a single mex implementation - effectivly each message recieved
                    // generates several new messages and it gets complex, quick.
                    Debug.Listeners.Clear();
                   //Bilge.AddStackInformation = true;
                   //Bilge.QueueMessages = true;
                    // TODO//Bilge.AddTCPListener("Localhost,7654,INTERACTIVE", "MexTCP");
                   //Bilge.CurrentTraceLevel = TraceLevel.Verbose;

#if TEXTFILELOG
                    string fname = @"c:\MexTraceOutput.txt";
                    if (File.Exists(fname)) {
                        File.Copy(fname, fname + ".copy.txt", true);
                        File.Delete(fname);
                    }

                   //Bilge.CurrentTraceLevel = TraceLevel.Verbose;

                    // Mex can use a file listener as this does not cause Mex to capture it and therefore it resolves the
                    // cyclic problem.  Mex can then later import this file to give a view of the logging.

                    StreamWriter sw = new StreamWriter(fname,false);
                    sw.AutoFlush = true;
                    TextWriterTraceListener twtl = new TextWriterTraceListener(sw);
                    Debug.Listeners.Add(twtl);

#endif
                }

                if (args[0] == "/log") {
                    // Added this in for logging MexPlus data.
                    setLogOptions = true;
                }
            }

            #endregion

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
           //Bilge.Initialise();
           //Bilge.InitialiseThread("Mex_UIMain_Thread");
           //Bilge.ResourceSysInfo("Application Startup");

            frmMexMainView f = new frmMexMainView();
            f.LoadViewerConfigurationData();

           //Bilge.VerboseLog("Options Loaded ok, now going to refresh the filter list for the main screen");
            f.RefreshQuickFilterList();
           //Bilge.VerboseLog("RefreshQuickFilterList completes ok, moving on to loading defaults");
            frmMexMainView.LoadDefaultFiltersAndHighlights();

           //Bilge.VerboseLog("All options and profiles are loaded, running application");

            if (setLogOptions) {
               //Bilge.VerboseLog("Detailed logging is active");
                MexCore.TheCore.Options.PersistEverything = true;
                string filename = string.Format("MexMsgs_{0}_{1}_on_{2}_{3}_{4}.csv", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                MexCore.TheCore.Options.CurrentFilename = Path.Combine(Path.GetTempPath(), filename);
            }
#if !DEBUG
            try {
#endif
            Application.Run(f);
#if !DEBUG
            } catch (Exception ex) {
               //Bilge.Dump(ex, "Exception running MexViewer Application");
                throw;
            }
#endif
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            MessageBox.Show(e.Exception.Message + " " + e.Exception.StackTrace);
        }
    }
}