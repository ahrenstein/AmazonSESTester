// ----------------------------------------------------------------------
// <copyright file="frmAbout.cs" company="Ahrenstein">
//     Copyright (c) 2015 Ahrenstein., All Rights Reserved.
//     Authors:
//          Matthew Ahrenstein 2015 @ahrenstein
// </copyright>
// ----------------------------------------------------------------------
/**
 * Amazon SES Tester
 * OPEN SOURCE PROJECT! Use is subject to license terms in LICENSE.txt
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection; // used for grabbing Assembly info to make a nice About Box

namespace Amazon_SES_Tester
{
    /// <summary>
    /// Implements the logic code for the about box.
    /// </summary>
    public partial class frmAbout : Form
    {
        /**
         * Methods
         */
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAbout"/> class.
        /// </summary>
        public frmAbout()
        {
            string[] projectDescription = new string[]
            {
                "Amazon SES Tester.",
                "A simple program for testing Amazon SES credentials",
                "in order to determine if they will work from the host",
                "you are running the application from.",
                "",
                "\t\t*** Amazon SES Tester Credits ***",
                "Matthew Ahrenstein:",
                "\t- Core Application (Contains all functions)",
                "\t- User Interface",
                "",
                "Nevec Networks LLC:",
                "\t- Assembly Attribute Accessors (Used to grab build/version info automatically)",
            };

            InitializeComponent();
            this.lblProjectName.Text = AssemblyVersion._NAME;
            this.lblVersion.Text = "Version: " + AssemblyVersion._VERSION_STRING;
            this.lblCopyright.Text = AssemblyVersion._COPYRIGHT;
            this.txtDescription.Lines = projectDescription;
        }

        /// <summary>
        /// Event that occurs when the "Close" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    } // public partial class frmAbout : Form
} // namespace SecurePassword.GeneratorLite
