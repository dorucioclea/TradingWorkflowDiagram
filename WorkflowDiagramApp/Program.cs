﻿using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using WokflowDiagram.Nodes.Visualization;

using WorkflowDiagram.Nodes.Base;

namespace WorkflowDiagramApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.ForceDirectXPaint();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WfConstantValueNode wfConstantValueNode = new WfConstantValueNode(1.0);
            WfTableFormNode form = new WfTableFormNode();
            
            Application.Run(new MainForm());
        }
    }
}
