using System;
using System.Net;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers.Abstract;
using unirest_net.http;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers
{
    public class WebController : IWebController
    {
        private const string k_MashapKEY = "KUG53mMZefgA4hIRXTrRhBO5k8Z2zrXc";
        private readonly WebClient m_WebClient = new WebClient();
        public event DownloadededByteCompleteEvent m_DownloadWebDataAsyncCompleted;
        public event DownloadededStringCompleteEvent m_DownloadWebStringAsyncCompleted;

        public T DownloadWebData<T>(Uri i_Uri)
        {
            HttpResponse<T> response =
            Unirest.get(i_Uri.ToString())
                .header("X-Mashape-Authorization", k_MashapKEY)
                .asJson<T>();

            return response.Body;
        }

        public void DownloadWebDataAsync(Uri i_Uri)
        {
            m_WebClient.DownloadDataCompleted += (sender, e) =>
            {
                if (m_DownloadWebDataAsyncCompleted != null)
                {
                    m_DownloadWebDataAsyncCompleted.Invoke(e.Result);
                }
            };
            m_WebClient.DownloadDataAsync(i_Uri);
        }

        public void DownloadWebStringAsync(Uri i_Uri)
        {
            m_WebClient.DownloadStringCompleted += (sender, e) =>
            {
                if (m_DownloadWebStringAsyncCompleted != null)
                {
                    m_DownloadWebStringAsyncCompleted.Invoke(e.Result);
                }
            };
            m_WebClient.DownloadStringAsync(i_Uri);
        }
    }
}
