using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers.Abstract;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Static;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Json;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using Newtonsoft.Json;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class FunnyForm : Form
    {
        private const string k_RageFacesURLQuery = "http://alltheragefaces.com/api/all/faces";
        private const string k_FilterByURI = "http://fonxvard.com/api/get?url=";
        private const string k_FacebookURL = "http://www.facebook.com";
        private const int k_RageTinyBoxesAmount = 24;
        private List<RagePersonJson> m_AllRagePersons;
        private List<PictureBox> m_RagePersonsTinyPictureBoxes;
        private int m_CurrentStartRangeDisplayedIndex;
        private int m_currentPicBoxIndex;

        private readonly IWebController m_WebController;

        public FunnyForm(IWebController i_WebController)
        {
            m_WebController = i_WebController;
            InitializeComponent();
            InitiailizeWebController();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_WebController.DownloadWebStringAsync(new Uri(k_RageFacesURLQuery));
        }

        private void InitiailizeWebController()
        {
            m_WebController.m_DownloadWebStringAsyncCompleted += onRagePersonsDownloaded;
            m_WebController.m_DownloadWebDataAsyncCompleted += onFilteredImageDownloaded;
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            var httpFilterUriQuery = new Uri(string.Format(k_FilterByURI + getCurrentJsonRagePerson().jpg));
            m_WebController.DownloadWebDataAsync(httpFilterUriQuery);
        }

        private void onFilteredImageDownloaded(byte[] bytes)
        {
            Image image = Image.FromStream(new MemoryStream(bytes));
            pictureBoxRageFace.Image = image;
        }
        private void onRagePersonsDownloaded(string result)
        {
            m_AllRagePersons = JsonConvert.DeserializeObject<List<RagePersonJson>>(result);
            populateRagePictureBoxes();
            loadRageImagesToPicBoxesAsync();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
            markTinyRageFaceAsSelected();
            
        }
        private void showBigRageFaceImageUsingCurrentTinyRagePicBox()
        {
            pictureBoxRageFace.LoadAsync(getCurrentJsonRagePerson().jpg);
        }

        private void buttonSubmitPost_Click(object sender, EventArgs e)
        {
            UserSingleton.Instance.LoggedInUser.PostPhoto(
                RageImageHelper.GetJpegByteStream(pictureBoxRageFace.Image), richTextBoxDescription.Text);
            MessageBox.Show("The post was published to your facebook wall successfuly!", "Confirmation", MessageBoxButtons.OK);
        }

        private void buttonOpenInPaint_Click(object sender, EventArgs e)
        {
            RageImageHelper.ShowImageInPaint(pictureBoxRageFace.Image);
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {       
            RageImageHelper.ShowSaveImageDialog(pictureBoxRageFace.Image);
        }

        private void buttonOpenBrowser_Click(object sender, EventArgs e)
        {
            Process.Start(k_FacebookURL);
        }

        private RagePersonJson getCurrentJsonRagePerson()
        {
           return m_AllRagePersons[m_CurrentStartRangeDisplayedIndex + m_currentPicBoxIndex];
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


        private void populateRagePictureBoxes()
        {
            m_RagePersonsTinyPictureBoxes = new List<PictureBox>(k_RageTinyBoxesAmount);
            for (int i = 0; i < k_RageTinyBoxesAmount; i++)
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(70, 70);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                picBox.Click += OnRageTinyPicClick;
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
