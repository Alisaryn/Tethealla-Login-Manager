/*
    Tethealla Login Manager
    Copyright 2022 Michelle Powers

    Icon assets from the Tethealla project (https://pioneer2.net) were used in this project.
    This project is reliant on Tethealla, but is not affiliated in any way with its developers.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;

namespace Tethealla_Login_Manager
{   
    public partial class MainForm : Form
    {
        // Global class members for the main form. 
        bool useDefaultLoginSettings = false;       // Use default login settings? (In cases where tethealla.ini was not found, or could not be read correctly.
        string[] loginSettings = new string[22];    // String array for tethealla.ini settings.

        public MainForm()
        {
            InitializeComponent();
        }       

        // Iterates through processes to check whether a specific one is running.
        private bool ProgramIsRunning(string FullPath)
        {
            string FilePath = Path.GetDirectoryName(FullPath);
            string FileName = Path.GetFileNameWithoutExtension(FullPath).ToLower();
            bool isRunning = false;

            Process[] pList = Process.GetProcessesByName(FileName);

            foreach (Process p in pList)
            {
                // A try-catch statement is needed here to catch exceptions due to weird Windows behavior, in case a program is closed while reading.
                try
                {
                    if (p.MainModule.FileName.StartsWith(FilePath, StringComparison.InvariantCultureIgnoreCase))
                    {
                        isRunning = true; // Process was found!
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }
            return isRunning;
        }

        // Patch thread function. Used to check if the patch server is running, and restart it automatically if not.
        private void PatchServerStart()
        {
            lnkPatchRunning.Invoke(new Action(() => lnkPatchRunning.Text = "Starting"));

            try
            {
                bool isPatchRunning, patchUp;

                for ( ; ; )
                {
                    isPatchRunning = ProgramIsRunning(@System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\patch_server.exe");

                    if (isPatchRunning)
                    {
                        lnkPatchDown.Hide();
                        lnkPatchRunning.Show();
                        patchUp = false;                     
                        IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
                        IPEndPoint[] endPoints = properties.GetActiveTcpListeners();

                        // In order to check uptime, check all listening ports for our patch server.
                        foreach (IPEndPoint e in endPoints)
                        {
                            if (e.Port == (int)(nmPort.Value - 1000))
                            {
                                patchUp = true;
                                lnkPatchRunning.Text = "Running";
                                lnkPatchRunning.LinkColor = Color.Green;
                                break;
                            }
                        }

                        if (!patchUp)
                        {
                            lnkPatchRunning.Text = "Starting";
                            lnkPatchRunning.LinkColor = Color.Navy;
                        }
                    }
                    else
                    {
                        lnkPatchDown.Show();
                        lnkPatchRunning.Hide();
                        if (chkPatchRestart.Checked == true)
                        {                           
                            // Restart the process and hide the console window!
                            Process patch_process = new Process();
                            patch_process.StartInfo.FileName = "patch_server.exe";
                            patch_process.StartInfo.UseShellExecute = true;
                            patch_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            patch_process.Start();
                            
                            // Some invoking is needed here, otherwise bad things can happen...
                            lnkPatchDown.Invoke(new MethodInvoker(() => lnkPatchDown.Hide()));
                            lnkPatchRunning.Invoke(new MethodInvoker(() => lnkPatchRunning.Show()));                                                
                        }
                    }            
                    Thread.Sleep(1000);
                }
            }
            catch
            {
                return;
            }
        }

        // Login thread function. Used to check if the login server is running, and restart it automatically if not.
        private void LoginServerStart()
        {
            try
            {
                bool isLoginRunning, loginUp;

                for (; ; )
                {
                    isLoginRunning = ProgramIsRunning(@System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\login_server.exe");

                    if (isLoginRunning)
                    {
                        lnkLoginDown.Hide();
                        lnkLoginRunning.Show();
                        loginUp = false;                      
                        IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
                        IPEndPoint[] endPoints = properties.GetActiveTcpListeners();

                        // In order to check uptime, check all listening ports for our patch server.
                        foreach (IPEndPoint e in endPoints)
                        {
                            if (e.Port == (int)(nmPort.Value))
                            {
                                loginUp = true;
                                lnkLoginRunning.Text = "Running";
                                lnkLoginRunning.LinkColor = Color.Green;
                                break;
                            }
                        }

                        if (!loginUp)
                        {
                            lnkLoginRunning.Text = "Starting";
                            lnkLoginRunning.LinkColor = Color.Navy;
                        }
                    }
                    else
                    {
                        lnkLoginDown.Show();
                        lnkLoginRunning.Hide();
                        if (chkLoginRestart.Checked == true)
                        {
                            // Restart the process and hide the console window!
                            Process login_process = new Process();
                            login_process.StartInfo.FileName = "login_server.exe";
                            login_process.StartInfo.UseShellExecute = true;
                            login_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            login_process.Start();
                            lnkLoginDown.Hide();
                            lnkLoginRunning.Show();
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch
            {
                return;
            }
        }

        // Write the specified user preference flag for auto-restart to our config file.
        private void write_restart_flag(int flag)
        {
            using (FileStream fs = File.Open("login_manager.ini", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fileData = new StreamWriter(fs))
                {
                    fileData.WriteLine("# Preference for 'Restart Automatically' checkboxes. 0 = disabled, 1 = enabled.");
                    fileData.Write(flag);                  
                }
                fs.Close();
            }
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {                     
            int restartFlag = 0, patchUpload = 0;
            bool useDefaultPatchSettings = false, useDefaultWelcome = false;
            // Threads to check patch and login statuses.
            Thread PatchActiveThread = new Thread(PatchServerStart);
            PatchActiveThread.IsBackground = true;
            PatchActiveThread.Start();
            Thread LoginActiveThread = new Thread(LoginServerStart);
            LoginActiveThread.IsBackground = true;
            LoginActiveThread.Start();

            lnkPatchRunning.Hide();
            lnkLoginRunning.Hide();

            // Extra handlers needed for color picking controls.
            txtNormalName.GotFocus += new EventHandler(txtNormalName_GotFocus);
            txtLocalGMName.GotFocus += new EventHandler(txtLocalGMName_GotFocus);
            txtGlobalGMName.GotFocus += new EventHandler(txtGlobalGMName_GotFocus);
            txtNormalName.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // Read login_manager.ini, ignoring comment lines.
            try
            {
                using (FileStream fs = File.Open("login_manager.ini", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string tempLine = String.Empty;

                        while (!reader.EndOfStream)
                        {
                            tempLine = reader.ReadLine();
                            if (tempLine.Substring(0, 1) != "#")
                            {
                                restartFlag = int.Parse(tempLine);                             
                                break;
                            }
                        }
                    }
                    fs.Close();
                }
            }
            catch // Not found, default to 0.
            {
                write_restart_flag(0);
            }

            if (restartFlag == 1)
            {
                chkPatchRestart.Checked = true;
                chkLoginRestart.Checked = true;
            }
            else
            {
                chkPatchRestart.Checked = false;
                chkLoginRestart.Checked = false;
            }

            
            // Read tethaella.ini, ignoring comment lines.
            try
            {
                using (FileStream fs = File.Open("tethealla.ini", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        int idx = 0;
                        string tempLine = String.Empty;

                        while (!reader.EndOfStream)
                        {
                            tempLine = reader.ReadLine();
                            if (tempLine.Substring(0, 1) != "#")
                            {
                                loginSettings[idx] = tempLine;
                                idx++;
                            }
                            if (idx > 21) break;
                        }
                    }
                }
            }
            catch // tethealla.ini not found, use default settings.
            {
                useDefaultLoginSettings = true;
            }

            if (!useDefaultLoginSettings)
            {
                txtPrivateIP.Text = loginSettings[5]; // Private login IP

                txtWelcome.Text = loginSettings[6]; // Scrolling banner welcome text

                nmPort.Value = int.Parse(loginSettings[7]); // Login port

                nmMaxClients.Value = int.Parse(loginSettings[8]); // Max number of allowed clients

                nmMaxShips.Value = int.Parse(loginSettings[9]); // Max number of allowed ships to register

                if (loginSettings[10] == "0") // Public/override IP, set to same as private IP if it's 0
                    txtPublicIP.Text = txtPrivateIP.Text;
                else txtPublicIP.Text = loginSettings[10]; // Otherwise, set to the specified public IP

                // Rare monster appearance settings
                nmHild.Value = decimal.Parse(loginSettings[11]) / 1000;
                nmRappies.Value = decimal.Parse(loginSettings[12]) / 1000;
                nmLillies.Value = decimal.Parse(loginSettings[13]) / 1000;
                nmSlimes.Value = decimal.Parse(loginSettings[14]) / 1000;
                nmMerissa.Value = decimal.Parse(loginSettings[15]) / 1000;
                nmPazuzu.Value = decimal.Parse(loginSettings[16]) / 1000;
                nmEclair.Value = decimal.Parse(loginSettings[17]) / 1000;
                nmKond.Value = decimal.Parse(loginSettings[18]) / 1000;

                // Name color settings
                txtGlobalGMName.BackColor = System.Drawing.ColorTranslator.FromHtml('#' + loginSettings[19]); // Global GM
                txtLocalGMName.BackColor = System.Drawing.ColorTranslator.FromHtml('#' + loginSettings[20]); // Local GM
                txtNormalName.BackColor = System.Drawing.ColorTranslator.FromHtml('#' + loginSettings[21]); // Normal
            }

            // Read patch.ini, ignoring comment lines.
            try
            {
                using (FileStream fs = File.Open("patch.ini", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string tempLine = String.Empty;

                        while (!reader.EndOfStream)
                        {
                            tempLine = reader.ReadLine();
                            if (tempLine.Substring(0, 1) != "#")
                            {
                                patchUpload = int.Parse(tempLine);
                                nmPatchUpload.Value = patchUpload;
                                if (patchUpload == 0)
                                {
                                    chkUnlimited.Checked = true;
                                    nmPatchUpload.ReadOnly = true;
                                    nmPatchUpload.Increment = 0;
                                }
                                break;
                            }
                        }
                    }
                    fs.Close();
                }
            }
            catch // patch.ini not found, use default setting.
            {
                useDefaultPatchSettings = true; // Has no use for now, but used maybe later!
            }

            // Read welcome.txt message.
            try
            {
                using (FileStream fs = File.Open("welcome.txt", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string tempLine = String.Empty;

                        while (!reader.EndOfStream)
                        {
                            tempLine = reader.ReadLine();
                            txtPatchWelcome.AppendLine(tempLine);
                        }
                    }
                    fs.Close();
                }
            }
            catch // welcome.txt not found, use default setting.
            {
                txtPatchWelcome.AppendLine("Unconfigured welcome.txt");
                useDefaultWelcome = true; // Has no use for now, but maybe used later!
            }
        }
      
        // Login "Save" button handler. Write back brief comment descriptions as well as our data, to keep the file clean in case of manual editing later.
        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Open("tethealla.ini", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fileData = new StreamWriter(fs))
                {
                    fileData.WriteLine("# Tethealla Server version 0.001 Configuration File");
                    fileData.WriteLine("#");
                    fileData.WriteLine("# MySQL Host");

                    if (!useDefaultLoginSettings)
                    {
                        fileData.WriteLine(loginSettings[0]);
                        fileData.WriteLine("# MySQL Username");
                        fileData.WriteLine(loginSettings[1]);
                        fileData.WriteLine("# MySQL Password");
                        fileData.WriteLine(loginSettings[2]);
                        fileData.WriteLine("# MySQL Database");
                        fileData.WriteLine(loginSettings[3]);
                        fileData.WriteLine("# MySQL Port");
                        fileData.WriteLine(loginSettings[4]);
                    }
                    else
                    {
                        fileData.WriteLine("localhost");
                        fileData.WriteLine("# MySQL Username");
                        fileData.WriteLine("mysqluser");
                        fileData.WriteLine("# MySQL Password");
                        fileData.WriteLine("mysqlpw");
                        fileData.WriteLine("# MySQL Database");
                        fileData.WriteLine("mysqldb");
                        fileData.WriteLine("# MySQL Port");
                        fileData.WriteLine("3306");
                    }
                    fileData.WriteLine("# Server IP address to bind to (your private IP)");
                    fileData.WriteLine(txtPrivateIP.Text);
                    fileData.WriteLine("# Welcome message");
                    fileData.WriteLine(txtWelcome.Text);
                    fileData.WriteLine("# Server Port (This is the port the login server listens on... it will also open port+1 for the character server... You shouldn't need to change this.)");
                    fileData.WriteLine(nmPort.Value);
                    fileData.WriteLine("# Max number of client connections");
                    fileData.WriteLine(nmMaxClients.Value);
                    fileData.WriteLine("# Max number of ships");
                    fileData.WriteLine(nmMaxShips.Value);
                    fileData.WriteLine("# Override IP (your public IP, leave 0 to just use the binded IP)");

                    // Write 0 if private and public IP are the same.
                    if (txtPublicIP.Text == txtPrivateIP.Text) 
                        fileData.WriteLine("0");
                    else 
                        fileData.WriteLine(txtPublicIP.Text);

                    fileData.WriteLine("# Rare monster appearance rate (% is basically the number divided by 1000)");
                    fileData.WriteLine("#");
                    fileData.WriteLine("# Hildebear");
                    fileData.WriteLine((int)(nmHild.Value * 1000));
                    fileData.WriteLine("# Rappies");
                    fileData.WriteLine((int)(nmRappies.Value * 1000));
                    fileData.WriteLine("# Lillies");
                    fileData.WriteLine((int)(nmLillies.Value * 1000));
                    fileData.WriteLine("# Slimes");
                    fileData.WriteLine((int)(nmSlimes.Value * 1000));
                    fileData.WriteLine("# Merissa");
                    fileData.WriteLine((int)(nmMerissa.Value * 1000));
                    fileData.WriteLine("# Pazuzu");
                    fileData.WriteLine((int)(nmPazuzu.Value * 1000));
                    fileData.WriteLine("# Dorphon Eclair");
                    fileData.WriteLine((int)(nmEclair.Value * 1000));
                    fileData.WriteLine("# Kondrieu");
                    fileData.WriteLine((int)(nmKond.Value * 1000));

                    // Write name colors as hex codes; default to #FFFFFF in case there are any issues.
                    fileData.WriteLine("# Global GM name color");
                    try
                    {
                        fileData.WriteLine(ColorTranslator.ToHtml(Color.FromArgb(txtGlobalGMName.BackColor.ToArgb())).Substring(1, 6));
                    }
                    catch
                    {
                        fileData.WriteLine("FFFFFF");
                    }
                    fileData.WriteLine("# Local GM name color");
                    try
                    {
                        fileData.WriteLine(ColorTranslator.ToHtml(Color.FromArgb(txtLocalGMName.BackColor.ToArgb())).Substring(1, 6));
                    }
                    catch
                    {
                        fileData.WriteLine("FFFFFF");
                    }
                    fileData.WriteLine("# Normal name color");
                    try
                    {
                        fileData.WriteLine(ColorTranslator.ToHtml(Color.FromArgb(txtNormalName.BackColor.ToArgb())).Substring(1, 6));
                    }
                    catch
                    {
                        fileData.WriteLine("FFFFFF");
                    }
                }
                fs.Close();
            }
            MessageBox.Show("Login settings saved.", "Login Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Minimize to system tray.
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        // Unhide the window if the tray icon is double-clicked.
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        // Start the patch server process (if it exists!)
        private void lnkPatchDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process patch_process = new Process();
                patch_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                patch_process.StartInfo.UseShellExecute = true;
                patch_process.StartInfo.FileName = "patch_server.exe";
                patch_process.Start();
                lnkPatchDown.Hide();
                lnkPatchRunning.Show();
            }
            catch
            {
                MessageBox.Show("The file 'patch_server.exe' was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Start the login server (if it exists!)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process login_process = new Process();
                login_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                login_process.StartInfo.UseShellExecute = true;
                login_process.StartInfo.FileName = "login_server.exe";
                login_process.Start();
                lnkLoginDown.Hide();
                lnkLoginRunning.Show();
            }
            catch
            {
                MessageBox.Show("The file 'login_server.exe' was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
         
        // Ensure that the login and patch processes close along with our form!
        private void stop_server_process(string server)
        {
            string FullPath = @System.IO.Path.GetDirectoryName(Application.ExecutablePath) + server;
            string FilePath = Path.GetDirectoryName(FullPath);
            string FileName = Path.GetFileNameWithoutExtension(FullPath).ToLower();
            Process[] pList = Process.GetProcessesByName(FileName);

            foreach (Process p in pList)
            {
                // A try-catch statement is needed here to catch exceptions due to weird Windows behavior, in case a program is closed while reading.
                try
                {
                    if (p.MainModule.FileName.StartsWith(FilePath, StringComparison.InvariantCultureIgnoreCase))
                    {
                        p.Kill();
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int temp;

            if (chkLoginRestart.Checked == false || chkPatchRestart.Checked == false) temp = 0;
            else temp = 1;

            chkLoginRestart.Checked = false;
            chkPatchRestart.Checked = false;
            stop_server_process("\\login_server.exe");
            stop_server_process("\\patch_server.exe");

            write_restart_flag(temp);
        }

        // Also close the server processes if their respective "Running" label is clicked.      
        private void lnkPatchRunning_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chkPatchRestart.Checked = false;
            stop_server_process("\\patch_server.exe");
        }
        private void lnkStarted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chkLoginRestart.Checked = false;
            stop_server_process("\\login_server.exe");
        }

        // Update user preference for restarting whenever either checkbox is toggled.
        private void chkRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoginRestart.Checked == true) write_restart_flag(1);
            else write_restart_flag(0);
        }
        private void chkPatchRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPatchRestart.Checked == true) write_restart_flag(1);
            else write_restart_flag(0);
        }

        // Needed in order to prevent the cursor from being visible in these textboxes!
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);       
        private void txtNormalName_GotFocus(object sender, EventArgs e)
        {
            HideCaret(txtNormalName.Handle);
        }
        private void txtLocalGMName_GotFocus(object sender, EventArgs e)
        {
            HideCaret(txtLocalGMName.Handle);
        }
        private void txtGlobalGMName_GotFocus(object sender, EventArgs e)
        {
            HideCaret(txtGlobalGMName.Handle);
        }

        // Color pickers.
        private void txtNormalName_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtNormalName.BackColor = dlg.Color;
        }
        private void txtLocalGMName_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtLocalGMName.BackColor = dlg.Color;
        }
        private void txtGlobalGMName_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)        
                txtGlobalGMName.BackColor = dlg.Color;
        }

        // If "Unlimited" checkbox is clicked, no need to edit this textbox.
        private void chkUnlimited_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnlimited.Checked == true)
            {
                nmPatchUpload.ReadOnly = true;
                nmPatchUpload.Increment = 0;
            }
            else
            {
                nmPatchUpload.ReadOnly = false;
                nmPatchUpload.Increment = 1;
            }
        }

        // Save handler for both patch.ini and welcome.txt
        private void btnPatchSave_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Open("patch.ini", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fileData = new StreamWriter(fs))
                {
                    fileData.WriteLine("# Maximum upload speed for the patch server in KB/s (Kilobytes per second)");
                    fileData.WriteLine("#");
                    fileData.WriteLine("# Setting this value to 0 will send files as fast as possible.");
                    fileData.WriteLine("#");
                    if (chkUnlimited.Checked == true)
                        fileData.WriteLine("0");
                    else fileData.WriteLine(nmPatchUpload.Value);

                }
                fs.Close();
            }

            using (FileStream fs = File.Open("welcome.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fileData = new StreamWriter(fs))
                {
                    for (int i=0;i<txtPatchWelcome.Lines.Length;i++)
                    {
                        fileData.Write(txtPatchWelcome.Lines[i] + "\n");
                    }
                }
                fs.Close();
            }

            MessageBox.Show("Patch settings saved.", "Patch Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Extended textbox function, used for easier addition of lines in our patch server welcome message textbox!
    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
