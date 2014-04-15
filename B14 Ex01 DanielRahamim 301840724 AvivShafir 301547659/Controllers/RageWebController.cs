using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Rageface;
using Newtonsoft.Json;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers
{
    public delegate void DownloadededRagePersonsDelegate(List<RagePersonJson> i_RagePersons);

    public delegate void DownloadededFilteredImageDelegate(Image i_Image);

    public class RageWebController
    {
        private const string k_RageFacesURLQuery = "http://alltheragefaces.com/api/all/faces";
        private const string k_FacebookURL = "http://www.facebook.com";
        private const string k_FilterByURI = "http://fonxvard.com/api/get?url=";
        
        public event DownloadededRagePersonsDelegate m_notifyFinishedLoadingRagePersons;

        public event DownloadededFilteredImageDelegate m_notifyFinishedLoadingFilteredImage;

        private WebClient m_WebClient = new WebClient();

        public void BrowseToFacebook()
        {
            Process.Start(k_FacebookURL);
        }

        public void LoadRagePersonsFromServer()
        {
            m_WebClient.DownloadStringCompleted += (sender, e) =>
            {
                if (m_notifyFinishedLoadingRagePersons != null)
                {
                    m_notifyFinishedLoadingRagePersons.Invoke(JsonConvert.DeserializeObject<List<RagePersonJson>>(e.Result));
                }
            };

            this.m_WebClient.DownloadStringAsync(new Uri(k_RageFacesURLQuery));
        }

        public void URIFilterRequest(Uri i_ImageUri)
        {
            Uri httpFilterUriQuery = new Uri(string.Format(k_FilterByURI + i_ImageUri));
            m_WebClient.DownloadDataCompleted += (sender, e) =>
            {
                if (m_notifyFinishedLoadingFilteredImage != null)
                {
                    m_notifyFinishedLoadingFilteredImage.Invoke(Image.FromStream(new MemoryStream(e.Result)));
                }
            };

            m_WebClient.DownloadDataAsync(httpFilterUriQuery);
        }
    }
}
