using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiones_CabalhaoJFINAL
{
    public partial class dashboard: Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDashboard.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new Home() { Dock = DockStyle.Fill };
            pnlDashboard.Controls.Add(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDashboard.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new Home() { Dock = DockStyle.Fill };
            pnlDashboard.Controls.Add(uc);
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDashboard.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new Grades() { Dock = DockStyle.Fill };
            pnlDashboard.Controls.Add(uc);
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
