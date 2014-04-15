using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class QuoteMaster : Form
    {
        private QuoteMasterWebController m_WebController;

        public QuoteMaster()
        {
            InitializeComponent();
            m_WebController = new QuoteMasterWebController();
            m_WebController.GetQuote();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

    }
}
