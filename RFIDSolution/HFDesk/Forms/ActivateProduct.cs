﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using HFDesk.helpClass;
using System.IO;

namespace HFDesk
{
    public partial class ActivateProduct : Form
    {
        private bool m_bLicensed = false;

        public ActivateProduct()
        {
            InitializeComponent();
        }

        public ActivateProduct(bool isLicensed)
        {
            InitializeComponent();

            m_bLicensed = isLicensed;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tbx_md5code.Text.Trim()=="")
            {
                MessageBox.Show("product key can't be empty!");
                return;
            }
            if (MD5Handler.verifyMd5Hash(tbx_md5code.Text))
            {
                m_bLicensed = true;

                //DealINI.IniWriteValue("SETTING", "LICENSE", tbx_md5code.Text);

                WriteLicense2File(tbx_md5code.Text);

                groupBox1.Visible = !m_bLicensed;

                label3.Visible = m_bLicensed;

                HFDesk._licensedPorduct = true;
            }
            else
            {
                MessageBox.Show("product key is not correct!");
            }
            
        }

        private bool WriteLicense2File(string licenseString)
        {
            try
            {
                string licenseFilePath = AppDomain.CurrentDomain.BaseDirectory + "lcn.bin";

                using (BinaryWriter writer = new BinaryWriter(File.Open(licenseFilePath, FileMode.Create)))
                {
                    writer.Write(licenseString);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private void ActivateProduct_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = !m_bLicensed;

            label3.Visible = m_bLicensed;

#if DEBUG
            tbx_productCode.Text = "306C3";
#endif


#if !DEBUG
            if (!m_bLicensed)
            {
                string str = string.Empty;
                ManagementClass mcCpu = new ManagementClass("win32_Processor");
                ManagementObjectCollection mocCpu = mcCpu.GetInstances();
                foreach (ManagementObject m in mocCpu)
                {
                    str = m["Processorid"].ToString().Trim();
                    break;
                }

                tbx_productCode.Text = str.Substring(str.Length-5);
            }
#endif

            
        }
    }
}
