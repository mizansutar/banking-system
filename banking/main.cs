using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void accountCreaatinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening o = new opening();
            o.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_upd l = new log_upd();
            l.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transfer tr = new transfer();
            tr.Show();
        }

        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statment s = new statment();
            s.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balance b = new balance();
            b.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawal w = new withdrawal();
            w.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposit d = new deposit();
            d.Show();

        }

        private void aPLICATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loan_application LA = new loan_application();
            LA.Show();

        }

        private void pAIDLOANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paid_Loan PL = new Paid_Loan();
            PL.Show();
        }

        private void cardApllicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            card_application ca = new card_application();
            ca.Show();
        }

        private void cardStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            card_sttscs cs = new card_sttscs();
            cs.Show();
        }
    }
}
