// ----------------------------------------------------------------------
// <copyright file="frmMain.cs" company="Ahrenstein">
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon_SES_Tester
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Show the About box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutBox = new frmAbout();
            aboutBox.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Populate txtServer with list of SES servers
            txtServer.Items.Add("email-smtp-us-east-1.amazonaws.com");
            txtServer.Items.Add("email-smtp.us-west-2.amazonaws.com");
            txtServer.Items.Add("email-smtp.eu-west-1.amazonaws.com");
            txtServer.Text = "email-smtp.us-west-2.amazonaws.com"; // Setting the default option

            // Populate txtPort with list of available ports
            txtPort.Items.Add("25");
            txtPort.Items.Add("587");
            txtPort.Items.Add("465");
            txtPort.Text = "587"; // Setting the default option

            // Populate txtSMTPBody with a hard-coded explanation message
            txtSMTPBody.Text = "This is a sample message sent from Amazon SES Tester! " + System.Environment.NewLine +
            "This message is used to test the ability to send e-mail via Amazon SES " +
            "from a server in order to verify that it sends properly without firewall issues." + System.Environment.NewLine + System.Environment.NewLine +
            "You can learn more about the program that sent this message at: " +
            "https://github.com/ahrenstein/AmazonSESTester" +System.Environment.NewLine + System.Environment.NewLine +
            "If you were not expecting this message, then the person who sent it is responsible for bothering you." +
            "You can either talk to them about it or file a complaint with Amazon here: https://portal.aws.amazon.com/gp/aws/html-forms-controller/contactus/AWSAbuse";

        }
        /// <summary>
        /// Function to send the message
        /// </summary>
        /// <param name="sesServer">The SES server to use</param>
        /// <param name="sesPort">The port to connect to SES over</param>
        /// <param name="smtpUser">SMTP user credential</param>
        /// <param name="smtpPassword">SMTP password credential</param>
        /// <param name="smtpSubject">SMTP Subject</param>
        /// <param name="smtpBody">SMTP Body</param>
        /// <param name="fromAddr">From Address (Must be permitted in SES)</param>
        /// <param name="toAddr">To Address (Must be permitted by SES)</param>
        private void sendMessage(string sesServer, int sesPort, string smtpUser, string smtpPassword, string smtpSubject, string smtpBody, string fromAddr, string toAddr)
        {
            // Let's create an SMTP client
            using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(sesServer, sesPort))
            {
                // Create the network credentials we will use
                client.Credentials = new System.Net.NetworkCredential(smtpUser, smtpPassword);

                // Since TLS is required, and the hardcoded text box is just for show, we will set TLS to true here
                client.EnableSsl = true;

                // Let's try sending the message
                try
                {
                    client.Send(fromAddr, toAddr, smtpSubject, smtpBody);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to send the message due to the following error: " + ex, "ERROR SENDING MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Convert the port to integer
            int sendPort = Convert.ToInt16(txtPort.Text);
            sendMessage(txtServer.Text, sendPort, txtSMTPUser.Text, txtSMTPPassword.Text, txtSMTPSubject.Text, txtSMTPBody.Text, txtFrom.Text, txtTo.Text);
        }
    }
}
