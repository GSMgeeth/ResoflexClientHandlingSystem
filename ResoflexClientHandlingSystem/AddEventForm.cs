﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class AddEventForm : MetroFramework.Forms.MetroForm
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void schCancel_Click(object sender, EventArgs e)
        {
            ServiceEngineerFeedbackForm feedback = new ServiceEngineerFeedbackForm();
            feedback.ShowDialog();
        }
    }
}
