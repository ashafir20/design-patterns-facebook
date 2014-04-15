using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Rageface;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class FunnyForm : Form
    {
        private const int k_RageTinyBoxesAmount = 24;
        private List<RagePersonJson> m_AllRagePersons;
        private List<PictureBox> m_RagePersonsTinyPictureBoxes;
        private RageWebController m_WebController;
        private int m_CurrentStartRangeDisplayedIndex;
        private int m_currentPicBoxIndex;

        public FunnyForm()
        {
            InitializeComponent();
            InitiailizeWebController();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void InitiailizeWebController()
        {
            m_WebController = new RageWebController();
            m_WebController.m_notifyFinishedLoadingRagePersons += onRagePersonsDownloaded;
            m_WebController.m_notifyFinishedLoadingFilteredImage += onFilteredImageDownloaded;
            m_WebController.LoadRagePersonsFromServer();
        }

        private void showBigRageFaceImageUsingCurrentTinyRagePicBox()
        {
            pictureBoxRageFace.LoadAsync(getCurrentJsonRagePerson().jpg);
        }

        private void buttonSubmitPost_Click(object sender, EventArgs e)
        {
            FacebookSession.Instance.User.PostPhoto(
                RageImageHelpers.GetJpegByteStream(pictureBoxRageFace.Image), richTextBoxDescription.Text);
            MessageBox.Show("The post was published to your facebook wall successfuly!", "Confirmation", MessageBoxButtons.OK);
        }

        private void buttonOpenInPaint_Click(object sender, EventArgs e)
        {
            RageImageHelpers.ShowImageInPaint(pictureBoxRageFace.Image);
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {       
            RageImageHelpers.ShowSaveImageDialog(pictureBoxRageFace.Image);
        }

        private void buttonOpenBrowser_Click(object sender, EventArgs e)
        {
            m_WebController.BrowseToFacebook();
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            m_WebController.URIFilterRequest(new Uri(getCurrentJsonRagePerson().jpg));
        }

        private RagePersonJson getCurrentJsonRagePerson()
        {
           return m_AllRagePersons[m_CurrentStartRangeDisplayedIndex + m_currentPicBoxIndex];
        }

        private void onFilteredImageDownloaded(Image i_Image)
        {
            pictureBoxRageFace.Image = i_Image;
        }

        private void loadRageImagesToPicBoxesAsync()
        {
            int index = m_CurrentStartRangeDisplayedIndex;
            foreach (PictureBox picBox in m_RagePersonsTinyPictureBoxes)
            {
                if (index < m_AllRagePersons.Count)
                {
                    picBox.LoadAsync(m_AllRagePersons[index].jpg);
                    index++;
                }
            }
        }

        private void buttonNextFaces_Click(object sender, EventArgs e)
        {
            int nextStartIndex = m_CurrentStartRangeDisplayedIndex + k_RageTinyBoxesAmount;
            if (nextStartIndex < m_AllRagePersons.Count)
            {
                m_CurrentStartRangeDisplayedIndex = nextStartIndex;
                showNextSeriesOfRageFaces();
            }
        }

        private void buttonPrevFaces_Click(object sender, EventArgs e)
        {
            int nextStartIndex = m_CurrentStartRangeDisplayedIndex - k_RageTinyBoxesAmount;
            if (nextStartIndex >= 0)
            {
                m_CurrentStartRangeDisplayedIndex = nextStartIndex;
                showNextSeriesOfRageFaces();
            }
        }

        private void onRagePersonsDownloaded(List<RagePersonJson> i_RagePersons)
        {
            m_AllRagePersons = i_RagePersons;
            populateRagePictureBoxes();
            loadRageImagesToPicBoxesAsync();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
            markTinyRageFaceAsSelected();
        }

        private void populateRagePictureBoxes()
        {
            m_RagePersonsTinyPictureBoxes = new List<PictureBox>(k_RageTinyBoxesAmount);
            for (int i = 0; i < k_RageTinyBoxesAmount; i++)
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(70, 70);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                picBox.Click += new EventHandler(OnRageTinyPicClick);
                m_RagePersonsTinyPictureBoxes.Add(picBox);
                panelRagePersons.Controls.Add(m_RagePersonsTinyPictureBoxes[i]);
            }
        }

        private void OnRageTinyPicClick(object sender, EventArgs e)
        {
            unMarkTinyRageFaceAsSelected();
            m_currentPicBoxIndex = m_RagePersonsTinyPictureBoxes.IndexOf(sender as PictureBox);
            markTinyRageFaceAsSelected();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
        }

        private void markTinyRageFaceAsSelected()
        {
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BorderStyle = BorderStyle.FixedSingle;
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void unMarkTinyRageFaceAsSelected()
        {
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BorderStyle = BorderStyle.None;
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BackColor = DefaultBackColor;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (m_currentPicBoxIndex < k_RageTinyBoxesAmount - 1)
            {
                unMarkTinyRageFaceAsSelected();
                m_currentPicBoxIndex++;
                markTinyRageFaceAsSelected();
                showBigRageFaceImageUsingCurrentTinyRagePicBox();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (m_currentPicBoxIndex > 0)
            {
                unMarkTinyRageFaceAsSelected();
                m_currentPicBoxIndex--;
                markTinyRageFaceAsSelected();
                showBigRageFaceImageUsingCurrentTinyRagePicBox();
            }
        }

        private void showNextSeriesOfRageFaces()
        {
            loadRageImagesToPicBoxesAsync();
            unMarkTinyRageFaceAsSelected();
            m_currentPicBoxIndex = 0;
            markTinyRageFaceAsSelected();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
        }
    }
}
