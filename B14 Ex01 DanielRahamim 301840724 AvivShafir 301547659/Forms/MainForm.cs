using System;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class MainForm : Form
    {
        private readonly LoginForm m_LoginForm;
        private readonly StatisticsForm m_StatisticsForm;
        private readonly FunnyForm m_FunnyForm;
        private readonly FactForm m_FactForm;
        private readonly CatForm m_CatForm;

        public MainForm()
        {
            InitializeComponent();
            m_StatisticsForm = new StatisticsForm();
            m_LoginForm = new LoginForm();
            m_FunnyForm = new FunnyForm(new WebController());
            m_FactForm = new FactForm(new WebController());
            m_CatForm = new CatForm(new WebController());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            showLoginForm();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void loadUserProfilePicture()
        {
            PictureBoxUser.LoadAsync(UserSingleton.Instance.LoggedInUser.PictureSqaureURL);
        }

        private void showLoginForm()
        {
            if (m_LoginForm.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
            else
            {
                updateGUIWithFacebookUserInfo();
            }
        }

        private void updateGUIWithFacebookUserInfo()
        {
            loadUserProfilePicture();
            labelWelcome.Text = "Logged In As : " + UserSingleton.Instance.LoggedInUser.Name;
        }

        private void buttonUploadFunny_Click(object sender, EventArgs e)
        {
            m_FunnyForm.Show();
        }

        private void buttonGetStatics_Click(object sender, EventArgs e)
        {
           m_StatisticsForm.Show();
        }

        private void buttonQuoteMaster_Click(object sender, EventArgs e)
        {
            m_FactForm.Show();
        }

        private void buttonRandomCat_Click(object sender, EventArgs e)
        {
            m_CatForm.Show();
        }
    }
}
