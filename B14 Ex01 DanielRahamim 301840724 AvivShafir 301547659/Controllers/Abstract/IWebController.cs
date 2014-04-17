using System;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers.Abstract
{
    public delegate void DownloadededByteCompleteEvent(byte[] result);
    public delegate void DownloadededStringCompleteEvent(string result);
    public interface IWebController
    {
        T DownloadWebData<T>(Uri i_Uri);
        void DownloadWebDataAsync(Uri i_Uri);
        void DownloadWebStringAsync(Uri i_Uri);

        event DownloadededByteCompleteEvent m_DownloadWebDataAsyncCompleted;
        event DownloadededStringCompleteEvent m_DownloadWebStringAsyncCompleted;
    }
}
